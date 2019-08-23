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
   
        public DaoCadastroUs()
        {

        }

        Conexao conexao = new Conexao();

        public DataTable ConsultaUsuario()
        {          
            string query = "SELECT F.FUN_INT_ID AS Id, F.FUN_STR_NOME AS Nome, F.FUN_STR_RG AS RG, T.TEL_INT_CELULAR AS Celular FROM TBL_FUNCIONARIO AS F INNER JOIN TBL_TELEFONE AS T ON T.FUN_INT_ID = F.FUN_INT_ID;";
            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlDataAdapter da = new SqlDataAdapter(query, con);
             DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

        public void DeletUsuario(int id)
        { 
            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();
            SqlCommand cmd6 = con.CreateCommand();
            SqlCommand cmd7 = con.CreateCommand();

            

            cmd1.CommandText = "DELETE TBL_ENDERECO WHERE END_INT_ID =" + id.ToString();
            cmd2.CommandText = "DELETE TBL_CIDADE  WHERE CID_INT_ID =" + id.ToString();
            cmd3.CommandText = "DELETE TBL_ESTADO WHERE EST_INT_ID = " + id.ToString();
            cmd4.CommandText = "DELETE TBL_ESTADO_FUNCIONARIO WHERE EST_INT_ID =" + id.ToString();
            cmd5.CommandText = "DELETE TBL_TELEFONE WHERE TEL_INT_ID =" + id.ToString();
            cmd6.CommandText = "DELETE TBL_FUNCIONARIO WHERE FUN_INT_ID =" + id.ToString();
            cmd7.CommandText = "DELETE TBL_LOGINS WHERE LOG_INT_ID =" + id.ToString();

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
                cmd5.Transaction = tran;
                cmd5.ExecuteNonQuery();
                cmd6.Transaction = tran;
                cmd6.ExecuteNonQuery();
                cmd7.Transaction = tran;
                cmd7.ExecuteNonQuery();

                tran.Commit();

            }catch(SqlException ex)
            {
                tran.Rollback();

                string erro = ex.Message;
                erro += " Erro ao deletar !!!";
            }
            finally
            {
                con.Close();
            }
        }

        public void CadastraUsuario(string login,string senha)
        {

        }
    }
}
