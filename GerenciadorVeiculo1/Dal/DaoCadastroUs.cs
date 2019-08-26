using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorVeiculo1.View;
using System.Data;
using System.Data.SqlClient;
using dllDao;


namespace GerenciadorVeiculo1.Dal
{
    class DaoCadastroUs
    {
        public int UsuarioId { get; set; }

        public DaoCadastroUs()
        {

        }

        public DaoCadastroUs(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        

        public DataTable ConsultaUsuario()
        {
            Conexao conexao = new Conexao();

            string query = "SELECT F.FUN_INT_ID AS Id, F.FUN_STR_NOME AS Nome, F.FUN_STR_RG AS RG, T.TEL_INT_CELULAR AS Celular FROM TBL_FUNCIONARIO AS F INNER JOIN TBL_TELEFONE AS T ON T.FUN_INT_ID = F.FUN_INT_ID;";
            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlDataAdapter da = new SqlDataAdapter(query, con);
             DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

          public void DeletUsuario()
            {
               Conexao conexao = new Conexao();

               string query = "DELETE TBL_FUNCIONARIO WHERE FUN_INT_ID =" + UsuarioId.ToString();
               conexao.ExecutaInstrucaoNaBase(query);
              
            }



            public void CadastraUsuario(string login,string senha)
            {

            }
             
    }


}
