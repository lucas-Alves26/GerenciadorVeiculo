using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dllDao
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

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

        public void ExecutaInstrucaoNaBase(string QuerySQL)
        {

            string strConxao = StrConexao();
            //"Data Source=MSV_R01M13\\UNIP;Initial Catalog=dbAula02;Integrated Security=True";
            string Query = QuerySQL;
            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand sqlCommand = new SqlCommand(Query, con);

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

        public DataTable CarregarDados(string sql)
        {
            string query = sql;
            //Cria conexão com banco de dados
            SqlConnection con = new SqlConnection(StrConexao());

            con.Open();
            //Cria um dataadapter para receber o select do banco de dados
            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            
            //SqlCommand cmd = new SqlCommand(query, con);

            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            con.Close();
            return dt;
        }


    }
}

