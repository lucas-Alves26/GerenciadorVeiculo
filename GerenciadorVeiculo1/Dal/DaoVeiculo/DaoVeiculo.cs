using dllDao;
using GerenciadorVeiculo1.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Dal.DaoVeiculo
{
    class DaoVeiculo
    {
        public Empresa empresa { get; set; }
        public Veiculo veiculo { get; set; }

        Conexao conexao = new Conexao();
        public DataTable ConsultaVeiculo(string status)
        {
            string query = "";
            //traz as empresas que tem como status = ativo
            if (status == "ATIVO")
            {
                query = "SELECT v.VEI_INT_ID as ID, V.VEI_STR_MODELO AS Modelo, V.VEI_STR_PLACA AS Placa, E.EMP_STR_NOME AS Empresa, V.VEI_STR_STATUS AS Situação FROM TBL_VEICULO AS V "
                +"INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID WHERE V.VEI_STR_STATUS = 'ATIVO' ORDER BY EMP_STR_NOME ASC";
            }
            //traz todas as empresas
            else
            {
                query = "SELECT v.VEI_INT_ID as ID, V.VEI_STR_MODELO AS Modelo, V.VEI_STR_PLACA AS Placa, E.EMP_STR_NOME AS Empresa, V.VEI_STR_STATUS AS Situação FROM TBL_VEICULO AS V "
               + "INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID ORDER BY EMP_STR_NOME ASC";
            }

            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        public SqlDataReader TrazTodosId()
        {
            string query = "SELECT v.VEI_INT_ID, E.EMP_INT_ID FROM TBL_VEICULO AS V "
            +"INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID WHERE V.VEI_INT_ID = " + veiculo.VeiId.ToString();

            SqlDataReader dr = conexao.CarregarVariosDados(query);
            return dr;
        }
        public void DeleteVeiculo()
        {
            string query = "DELETE TBL_VEICULO WHERE VEI_INT_ID = " + veiculo.VeiId.ToString();
            conexao.ExecutaInstrucaoNaBase(query);
        }
    }
}
