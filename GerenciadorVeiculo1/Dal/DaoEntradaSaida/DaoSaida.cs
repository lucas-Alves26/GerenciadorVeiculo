using dllDao;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorVeiculo1.Dal.DaoEntradaSaida
{
    class DaoSaida
    {
        Conexao conexao = new Conexao();
        public Saida saida { get; set; }

        public void InserirSaida()
        {
         
            string data = saida.Data.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();

            if (saida.Desc == "")
            {
                cmd1.CommandText = "INSERT INTO TBL_SAIDA(SAI_STR_SITUACAO, FUN_INT_ID, MOT_INT_ID, VEI_INT_ID, SAI_DATE_DATA) VALUES( 'Viagem', " + saida.IdFun + " ," + saida.IdMot + " , " + saida.IdVei + " ,'" + data + "')";
            }
            else
            {
                cmd1.CommandText = "INSERT INTO TBL_SAIDA(SAI_STR_SITUACAO, FUN_INT_ID, MOT_INT_ID, VEI_INT_ID, SAI_DATE_DATA, SAI_STR_DESC) VALUES('Viagem', " + saida.IdFun + " ," + saida.IdMot + " , " + saida.IdVei + " ,'" + data + "','" + saida.Desc + "')";
                
            }

            cmd2.CommandText = "UPDATE TBL_MOTORISTA SET MOT_STR_SITUACAO = 'Viagem' WHERE MOT_INT_ID = " + saida.IdMot.ToString();
            cmd3.CommandText = "UPDATE TBL_VEICULO SET VEI_STR_SITUACAO = 'Viagem' WHERE VEI_INT_ID = " +saida.IdVei.ToString();

            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                cmd3.Transaction = tran;
                cmd3.ExecuteNonQuery();

                tran.Commit();
                
            }
            catch (Exception)
            {
                tran.Rollback();

            }
            finally
            {
                con.Close();
            }
  
        }
        public DataTable SelectSaidaDeVeiculos(string op)
        {
            string query = "";

            if (op == "Todas")
            { 
              query = "SELECT S.SAI_INT_ID AS ID, V.VEI_STR_PLACA AS Placa, V.VEI_STR_MODELO AS Modelo, M.MOT_STR_NOME AS Motorista,E.EMP_STR_NOME AS Empresa, CONVERT(VARCHAR(10), S.SAI_DATE_DATA, 103) AS DATA FROM TBL_SAIDA AS S"
                + " INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID"
                + " INNER JOIN TBL_MOTORISTA AS M ON M.MOT_INT_ID = S.MOT_INT_ID"
                + " INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID WHERE SAI_STR_SITUACAO = 'Viagem' ORDER BY S.SAI_DATE_DATA DESC";                               
            }

            else if (op == "Dia")
            {
                string data = DateTime.Now.ToString("yyyy-MM-dd");

                query = "SELECT S.SAI_INT_ID AS ID, V.VEI_STR_PLACA AS Placa, V.VEI_STR_MODELO AS Modelo, M.MOT_STR_NOME AS Motorista,E.EMP_STR_NOME AS Empresa, CONVERT(VARCHAR(10), S.SAI_DATE_DATA, 103) AS DATA FROM TBL_SAIDA AS S"
                  + " INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID"
                  + " INNER JOIN TBL_MOTORISTA AS M ON M.MOT_INT_ID = S.MOT_INT_ID"
                  + " INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID  WHERE S.SAI_DATE_DATA = '" + data+ "' AND SAI_STR_SITUACAO = 'Viagem' ";
            }

            DataTable dt = conexao.CarregarDados(query);

            return dt;
        }

        public SqlDataReader ConsultarSaida(string id)
        {
            //nesse select existe convert que está convertendo a data de nasc para trazer a data sem a hora
            //o 103 é o tipo de formado Britânico/francês
            string query = "SELECT S.SAI_INT_ID, E.EMP_STR_NOME,M.MOT_STR_NOME, C.CNH_STR_REGISTRO, V.VEI_STR_PLACA, V.VEI_STR_MARCA, V.VEI_STR_MODELO, V.VEI_STR_CHASSI, V.VEI_DOUBLE_KM ,CONVERT(VARCHAR(10),S.SAI_DATE_DATA,103) AS DATA, S.SAI_STR_DESC FROM TBL_SAIDA AS S"
            + " INNER JOIN TBL_MOTORISTA AS M ON S.MOT_INT_ID = M.MOT_INT_ID"
            + " INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID"
            + " INNER JOIN TBL_CNH AS C ON C.CNH_INT_ID = M.MOT_INT_ID"
            + " INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID WHERE S.SAI_INT_ID = " + id;

            SqlDataReader dt = conexao.CarregarVariosDados(query);

            return dt;
        }
    }
}
