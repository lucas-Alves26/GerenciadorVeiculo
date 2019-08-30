using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorVeiculo1.Dal;
using System.Data;
using System.Data.SqlClient;
using dllDao;


namespace GerenciadorVeiculo1.Dal
{
    class DaoLogin
    {
        public int LoginId { get; set; }
        public string Logins { get; private set;}
        public string Senha { get; private set;}

        public DaoLogin()
        {
        }

        public DaoLogin(int loginId)
        {
            LoginId = loginId;
        }

        public DaoLogin(string logins, string senha)
        {
            Logins = logins;
            Senha = senha;
        }
   
        public void DeleteLog()
        {
            Conexao conexao = new Conexao();
            string query= "DELETE TBL_LOGINS WHERE LOG_INT_ID =" + LoginId.ToString();
            conexao.ExecutaInstrucaoNaBase(query);
        }

        public void cadastroLog()
        {
            Conexao conexao = new Conexao();
            string query = "INSERT INTO TBL_LOGINS(LOG_STR_LOGIN, LOG_STR_SENHA) VALUES('"+Logins.ToString()+"', '"+Senha.ToString()+"')";
            conexao.ExecutaInstrucaoNaBase(query);
        }

        public string SelecioneId()
        {
            string id;
            Conexao conexao = new Conexao();
            string query = "SELECT MAX(LOG_INT_ID) FROM TBL_LOGINS";
            
            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand sqlCommand = new SqlCommand(query, con);
            

            sqlCommand.Connection = conexao.conectar();

            id = sqlCommand.ExecuteScalar().ToString();

            conexao.desconectar();
            
            return id;
        }

        

    }
}
