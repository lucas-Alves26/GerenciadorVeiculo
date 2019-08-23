﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dllDao
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();


       // public string StrConfiguracao { get; set; }



        public Conexao()
        {

            con.ConnectionString = @"Data Source=DESKTOP-LUCAS\SQLEXPRESS;Initial Catalog=DB_GER_VEICULO;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            //se a conexao estiver fechada vai abrir a conexao
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        // vai fechar a conexão
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public string StrConexao()
        {
            return @"Data Source=DESKTOP-LUCAS\SQLEXPRESS;Initial Catalog=DB_GER_VEICULO;Integrated Security=True";
        }

        public void ExecutarQuery(string QuerySQL)
            {
                string strConexao = StrConexao();
                string query = QuerySQL;
                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(query, con);

        try
         {
                con.Open();
              sqlCommand.ExecuteNonQuery();
         }

                catch (Exception ex)
                {
                    string erro = ex.Message;
                    erro += "   !!!";
                }

                finally
                {

                con.Close();
                }

        }

    }
}
