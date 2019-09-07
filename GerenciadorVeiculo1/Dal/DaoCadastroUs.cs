using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorVeiculo1.View;
using System.Data;
using System.Data.SqlClient;
using dllDao;
using GerenciadorVeiculo1.Exceptions;



namespace GerenciadorVeiculo1.Dal
{
    class DaoCadastroUs
    {
        public int UsuarioId { get; set; }
        public string Name { get; set; }
        public DateTime Nasc { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public string Rg { get; set; }
        public string Cargo { get; set; }
        public char Sexo { get; set; } 
        public string Email { get; set; }
        
        public DaoCadastroUs()
        {
        }

        public DaoCadastroUs(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        public DaoCadastroUs(string name, DateTime nasc, string cpf, string cnh, string rg, string cargo, char sexo, string email)
        {
            Name = name;
            Nasc = nasc;
            Cpf = cpf;
            Cnh = cnh;
            Rg = rg;
            Cargo = cargo;
            Sexo = sexo;
            Email = email;
        }

        public DataTable ConsultaUsuario()
        {
            Conexao conexao = new Conexao();

            string query = "SELECT F.FUN_INT_ID AS Id, F.FUN_STR_NOME AS Nome, F.FUN_STR_RG AS RG, T.TEL_INT_CELULAR AS Celular FROM TBL_FUNCIONARIO AS F INNER JOIN TBL_TELEFONE AS T ON T.FUN_INT_ID = F.FUN_INT_ID;";
            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();
            return dt;
        }

        public void DeletUsuario()
        {
               Conexao conexao = new Conexao();
               string query = "DELETE TBL_FUNCIONARIO WHERE FUN_INT_ID =" + UsuarioId.ToString();
               conexao.ExecutaInstrucaoNaBase(query);
        }


        public void CadastraUsuario()
        {
            string nasc = Nasc.ToString("yyyy-MM-dd");

            DaoLogin daoLogin = new DaoLogin();
            string id = daoLogin.SelecioneId();

            
            

            Conexao conexao = new Conexao();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LUCAS\SQLEXPRESS;Initial Catalog=DB_GER_VEICULO;Integrated Security=True");

            string query = "INSERT INTO TBL_FUNCIONARIO(FUN_STR_NOME, FUN_DATE_NASC, FUN_STR_CPF, FUN_STR_CNH, FUN_STR_RG, FUN_STR_CARGO, FUN_STR_SEXO, FUN_STR_EMAIL, LOG_INT_ID) VALUES(@name, '"+nasc+"', @cpf, @cnh, @rg, @cargo, @sexo, @email, @id)";

            SqlCommand sqlCommand = new SqlCommand(query,con);

            sqlCommand.Parameters.Add(new SqlParameter("@name", Name));
            sqlCommand.Parameters.Add(new SqlParameter("@cpf", Cpf));
            sqlCommand.Parameters.Add(new SqlParameter("@cnh", Cnh));
            sqlCommand.Parameters.Add(new SqlParameter("@rg", Rg));
            sqlCommand.Parameters.Add(new SqlParameter("@cargo", Cargo));
            sqlCommand.Parameters.Add(new SqlParameter("@sexo", Sexo));
            sqlCommand.Parameters.Add(new SqlParameter("@email", Email));
            sqlCommand.Parameters.Add(new SqlParameter("@id", id));

            con.Open();

            //executa query        
            sqlCommand.ExecuteNonQuery();

            con.Close();
        
        }
             
    }

}
