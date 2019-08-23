using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorVeiculo1.Dal;
using System.Data;
using System.Data.SqlClient;
using dllDao;


namespace GerenciadorVeiculo1.Entitys
{
    class Login
    {
        public int LoginId { get; set; }
        public string Logins { get; private set;}
        public string Senha { get; private set;}

        public Login(string logins, string senha)
        {
            Logins = logins;
            Senha = senha;
        }
        public Login(int loginId)
        {
            LoginId = loginId;
        }

        public void DeleLog()
        {
            Conexao conexao = new Conexao();
            
            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand cmd7 = con.CreateCommand();

            cmd7.CommandText = "DELETE TBL_LOGINS WHERE LOG_INT_ID =" + LoginId.ToString();

            con.Open();

            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd7.Transaction = tran;
                cmd7.ExecuteNonQuery();

                tran.Commit();

            }
            catch (SqlException ex)
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

    }
}
