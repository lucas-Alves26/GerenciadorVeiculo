using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Dal
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        // vai verificar no banco se existe login e senha
        public bool verificarLogin(string login, string senha)
        {
            cmd.CommandText = "select * from tbl_logins where LOG_STR_LOGIN = @login and LOG_STR_SENHA = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();// pega informação do banco de dados para ser guardado

                // se houver linhas no banco de dados
                if (dr.HasRows)
                {
                    tem = true;
                }
              
            }

            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados";
            }

            
            con.desconectar();
            return tem;

           

           
        }

        
    }
}
