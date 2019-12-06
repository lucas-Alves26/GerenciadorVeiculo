using dllDao;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorVeiculo1.Dal.DaoManutencao
{
    class DaoManutencao
    {
        Conexao conexao = new Conexao();
        public Manutencao manutencao { get; set; }

        public void RegistrarManutecao()
        {

            string data = manutencao.Data.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();

            cmd1.CommandText = "INSERT INTO TBL_MANUTENCAO(VEI_INT_ID,MAN_DATE_DATA)"
            + " VALUES(@idVei,@date)";

            cmd2.CommandText = "update TBL_VEICULO SET VEI_STR_SITUACAO = 'Manutenção'  WHERE VEI_INT_ID = @idVei";


            cmd1.Parameters.Add(new SqlParameter("@idVei", manutencao.IdVei));
            //cmd1.Parameters.Add(new SqlParameter("@servico", manutencao.Servico));
            //cmd1.Parameters.Add(new SqlParameter("@tipoServ", manutencao.TipoServ));
            cmd1.Parameters.Add(new SqlParameter("@date", data));
            //cmd1.Parameters.Add(new SqlParameter("@obs", manutencao.Obs));

            cmd2.Parameters.Add(new SqlParameter("@idVei", manutencao.IdVei));
  


            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();

                tran.Commit();

                //registra o tipo de serviço a ser realizado no BD
                RegistrarServico();

            }
            catch (Exception)
            {
                tran.Rollback();
            }
            finally
            {
                con.Close();
            }
            //Traz o ultimo ID da TBL_SERVICO para fazer o relacionamento
            string query = "SELECT MAX(SERV_INT_ID) FROM TBL_SERVICO ";
            string idServ = conexao.SelecioneId(query);
            //Traz o ultimo ID da TBL_MANUTENCAO para usar no WHERE
            query = "SELECT MAX(MAN_INT_ID) FROM TBL_MANUTENCAO ";
            string idMan = conexao.SelecioneId(query);

            //adiciona o idServiço na tabela TBL_MANUTENCAO
            query = "UPDATE TBL_SERVICO SET MAN_INT_ID = " + idMan + " WHERE SERV_INT_ID = " + idServ;
            conexao.ExecutaInstrucaoNaBase(query);
        }

        public void RegistrarServico()
        {
            string query = "INSERT INTO TBL_SERVICO(SERV_STR_SERVICO,SERV_STR_TIPO_SERV,SERV_STR_OBS) "
                + " VALUES('"+manutencao.Servico+"','"+manutencao.TipoServ+"','"+manutencao.Obs+"')";
            conexao.ExecutaInstrucaoNaBase(query);

        }

        public void FinalizarManutecao()
        {
            string hora = manutencao.HoraFin.ToString();

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();


            cmd1.CommandText = "UPDATE TBL_MANUTENCAO SET MAN_TIME_HORA_FIN = @hora, MAN_DOU_VALOR = @valor WHERE MAN_INT_ID = " + manutencao.IdManut;

            cmd2.CommandText = "UPDATE TBL_VEICULO SET VEI_STR_SITUACAO = 'Disponivel' WHERE VEI_INT_ID = " + manutencao.IdVei;


            cmd1.Parameters.Add(new SqlParameter("@idVei", manutencao.IdVei));
            cmd1.Parameters.Add(new SqlParameter("@hora", hora));
            cmd1.Parameters.Add(new SqlParameter("@valor", manutencao.Valor.ToString()));

            cmd2.Parameters.Add(new SqlParameter("@idVei", manutencao.IdVei));



            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();

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

        public DataTable SelectManutencao(string op)
        {
            string query = "";

            if (op == "Todas")
            {
                query = "SELECT  DISTINCT M.MAN_INT_ID,V.VEI_STR_PLACA,V.VEI_STR_MARCA,V.VEI_STR_MODELO, V.VEI_STR_COMBUSTIVEL,CONVERT(VARCHAR(10),M.MAN_DATE_DATA,103) AS Data , V.VEI_DOUBLE_KM FROM TBL_MANUTENCAO AS M "
                + " INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = M.VEI_INT_ID"
                + " INNER JOIN TBL_SERVICO AS S ON S.MAN_INT_ID = M.MAN_INT_ID"
                + " WHERE M.MAN_DOU_VALOR IS NULL";
            }
            //else if (op == "Dia")
            //{
            //    string data = DateTime.Now.ToString("yyyy-MM-dd");

            //    query = "SELECT S.SAI_INT_ID AS ID, V.VEI_STR_PLACA AS Placa, V.VEI_STR_MODELO AS Modelo, M.MOT_STR_NOME AS Motorista,E.EMP_STR_NOME AS Empresa, CONVERT(VARCHAR(10), S.SAI_DATE_DATA, 103) AS DATA FROM TBL_SAIDA AS S"
            //      + " INNER JOIN TBL_VEICULO AS V ON V.VEI_INT_ID = S.VEI_INT_ID"
            //      + " INNER JOIN TBL_MOTORISTA AS M ON M.MOT_INT_ID = S.MOT_INT_ID"
            //      + " INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = M.EMP_INT_ID  WHERE S.SAI_DATE_DATA = '" + data + "' AND SAI_STR_SITUACAO = 'Viagem' ";
            //}


            DataTable dt = conexao.CarregarDados(query);

            return dt;
        }

        public SqlDataReader SelectManut(string id)
        {
            //nesse select existe convert que está convertendo a data de nasc para trazer a data sem a hora
            //o 103 é o tipo de formado Britânico/francês
            string query = "SELECT CONVERT(VARCHAR(10),M.MAN_DATE_DATA,103) AS DATA, M.MAN_INT_ID,M.MAN_DOU_VALOR,M.MAN_TIME_HORA_INI,MAN_TIME_HORA_FIN,V.VEI_STR_PLACA,V.VEI_STR_MODELO,V.VEI_DOUBLE_KM,"
            + " P.EMP_INT_ID, P.EMP_STR_NOME, S.SERV_STR_SERVICO, S.SERV_STR_TIPO_SERV,S.SERV_STR_OBS FROM TBL_MANUTENCAO AS M"
            + " INNER JOIN TBL_VEICULO AS V ON M.VEI_INT_ID = V.VEI_INT_ID"
            + " INNER JOIN TBL_EMPRESA AS P ON P.EMP_INT_ID = V.EMP_INT_ID"
            + " INNER JOIN TBL_SERVICO AS S ON S.MAN_INT_ID = M.MAN_INT_ID"
            + " WHERE M.MAN_INT_ID = " + id;

            SqlDataReader dt = conexao.CarregarVariosDados(query);

            return dt;
        }
    }

    
}
