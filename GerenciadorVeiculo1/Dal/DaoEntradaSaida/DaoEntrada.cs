using dllDao;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorVeiculo1.Dal.DaoEntradaSaida
{
    class DaoEntrada
    {
        Conexao conexao = new Conexao();
        public Entrada entrada { get; set; }

        public void efetuarEntrada()
        {
            string idMot, idVei;

            SqlDataReader dr = TrazTodosId();

            idMot = dr["MOT_INT_ID"].ToString();
            idVei = dr["VEI_INT_ID"].ToString();

            string data = entrada.DataEntrada.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();

            cmd1.CommandText = "INSERT INTO TBL_ENTRADA(SAI_INT_ID, ENT_DATE_DATA) VALUES(@idSaida,@dataEntrada)";

            cmd2.CommandText = "UPDATE TBL_SAIDA SET SAI_STR_SITUACAO = 'Finalizada' WHERE SAI_INT_ID = @idSaida";

            cmd3.CommandText = "UPDATE TBL_MOTORISTA SET MOT_STR_SITUACAO = 'Disponivel' WHERE MOT_INT_ID = @idMot";

            cmd4.CommandText = "update TBL_VEICULO SET VEI_STR_SITUACAO = 'Disponivel', VEI_DOUBLE_KM += @Odometro  WHERE VEI_INT_ID = @idVei";

            cmd1.Parameters.Add(new SqlParameter("@idSaida", entrada.IdSaida));
            cmd1.Parameters.Add(new SqlParameter("@dataEntrada", data));

            cmd2.Parameters.Add(new SqlParameter("@idSaida", entrada.IdSaida));

            cmd3.Parameters.Add(new SqlParameter("@idMot", idMot));

            cmd4.Parameters.Add(new SqlParameter("@idVei", idVei));
            cmd4.Parameters.Add(new SqlParameter("@Odometro", entrada.OdoEntrada));


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
                cmd4.Transaction = tran;
                cmd4.ExecuteNonQuery();

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

        public SqlDataReader TrazTodosId()
        {
            string query = "SELECT SAI_INT_ID, FUN_INT_ID, MOT_INT_ID, VEI_INT_ID FROM TBL_SAIDA WHERE SAI_INT_ID = " + entrada.IdSaida;

            SqlDataReader dr = conexao.CarregarVariosDados(query);

            return dr;
        }
    }
}