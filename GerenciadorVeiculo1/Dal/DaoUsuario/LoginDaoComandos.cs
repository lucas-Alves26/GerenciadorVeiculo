using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllDao;
using GerenciadorVeiculo1.View;
using GerenciadorVeiculo1.View.GerEntradaSaida;

namespace GerenciadorVeiculo1.Dal
{
    public class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;


        // vai verificar no banco se existe login e senha
        public bool verificarLogin(string login, string senha)
        {
            cmd.CommandText = "select LOG_INT_ID,LOG_STR_LOGIN,LOG_STR_SENHA from tbl_logins where LOG_STR_LOGIN = @login and LOG_STR_SENHA = @senha";
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
            //Pega o id do login e passa para o fmrprincipal para depois ser passado para o fmrSaida
            dr = con.CarregarVariosDados("select LOG_INT_ID from tbl_logins where LOG_STR_LOGIN = '" + login + "' and LOG_STR_SENHA = '" + senha + "'");
            string idLog = dr["LOG_INT_ID"].ToString();


            con.desconectar();
            return tem;       
        }

      

    }
}
