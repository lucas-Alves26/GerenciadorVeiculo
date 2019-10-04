using dllDao;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using GerenciadorVeiculo1.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace GerenciadorVeiculo1.Dal
{
    class DaoUsuario
    {
        public Usuario usuario { get; set; }
        public Logins logins { get; set; }
        public Telefone telefone { get; set; }
        public Endereco endereco { get; set; }

        Conexao conexao = new Conexao();

        public DaoUsuario()
        {
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
            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();


            cmd1.CommandText = "DELETE TBL_ENDERECO_FUNCIONARIO WHERE FUN_INT_ID =" + usuario.UsuarioId.ToString();
            cmd2.CommandText = "DELETE TBL_ENDERECO WHERE END_INT_ID =" + usuario.UsuarioId.ToString();       
            cmd3.CommandText = "DELETE TBL_TELEFONE WHERE TEL_INT_ID =" + usuario.UsuarioId.ToString();
            cmd4.CommandText = "DELETE TBL_FUNCIONARIO WHERE FUN_INT_ID =" + usuario.UsuarioId.ToString();
            cmd5.CommandText = "DELETE TBL_LOGINS WHERE LOG_INT_ID =" + usuario.UsuarioId.ToString();

            con.Open();

            SqlTransaction tran = con.BeginTransaction();

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



            tran.Commit();

            con.Close();
        }

        //cadastra login 
        public void cadastroLog()
        {
            try
            {
                string query = "INSERT INTO TBL_LOGINS(LOG_STR_LOGIN, LOG_STR_SENHA) VALUES('" + logins.Log + "', '" + logins.Senha + "')";
                conexao.ExecutaInstrucaoNaBase(query);
            }
            catch (DomainExceptions)
            {
                throw new DomainExceptions("Erro ao cadastra o login e senha!");
            }
        }

        public void CadastraUsuario()
        {
            string nasc = usuario.Nasc.ToString("yyyy-MM-dd");
            DaoLogin daoLogin = new DaoLogin();
            string id = SelecioneId();

            SqlConnection con = new SqlConnection(conexao.StrConexao());
         
                SqlCommand cmd1 = con.CreateCommand();
                SqlCommand cmd2 = con.CreateCommand();
                SqlCommand cmd3 = con.CreateCommand();
                SqlCommand cmd4 = con.CreateCommand();

                cmd1.CommandText = "INSERT INTO TBL_FUNCIONARIO(FUN_STR_NOME, FUN_DATE_NASC, FUN_STR_CPF, FUN_STR_CNH, FUN_STR_RG, FUN_STR_CARGO, FUN_STR_SEXO, FUN_STR_EMAIL, LOG_INT_ID) VALUES(@name, '" + nasc + "', @cpf, @cnh, @rg, @cargo, @sexo, @email, @id)";
                cmd2.CommandText = "INSERT INTO TBL_TELEFONE(TEL_INT_DDD,TEL_INT_CELULAR,TEL_INT_FIXO,TEL_STR_OPERADORA,FUN_INT_ID) VALUES(@ddd, @celular, @fixo, @operadora, @id)";
                cmd3.CommandText = "INSERT INTO TBL_ENDERECO (END_STR_RUA,END_INT_NUMERO,END_STR_BAIRRO,END_INT_CEP,END_STR_COMPLEMENTO,CID_INT_ID,EST_INT_CODUF)"
                + "VALUES(@rua, @numEnd, @bairro, @cep, @complemento,@cidadeId, @estadoCodUF)";


                cmd1.Parameters.Add(new SqlParameter("@name", usuario.Name));
                cmd1.Parameters.Add(new SqlParameter("@cpf", usuario.Cpf));
                cmd1.Parameters.Add(new SqlParameter("@cnh", usuario.Cnh));
                cmd1.Parameters.Add(new SqlParameter("@rg", usuario.Rg));
                cmd1.Parameters.Add(new SqlParameter("@cargo", usuario.Cargo));
                cmd1.Parameters.Add(new SqlParameter("@sexo", usuario.Sexo));
                cmd1.Parameters.Add(new SqlParameter("@email", usuario.Email));
                cmd1.Parameters.Add(new SqlParameter("@id", id));

                cmd2.Parameters.Add(new SqlParameter("@ddd", telefone.Ddd));
                cmd2.Parameters.Add(new SqlParameter("@celular", telefone.Celular));
                cmd2.Parameters.Add(new SqlParameter("@fixo", telefone.Fixo));
                cmd2.Parameters.Add(new SqlParameter("@operadora", telefone.Operadora));
                cmd2.Parameters.Add(new SqlParameter("@id", id));

                cmd3.Parameters.Add(new SqlParameter("@rua", endereco.Rua));
                cmd3.Parameters.Add(new SqlParameter("@numEnd", endereco.NumeroRua));
                cmd3.Parameters.Add(new SqlParameter("@bairro", endereco.Bairro));
                cmd3.Parameters.Add(new SqlParameter("@cep", endereco.Cep));
                cmd3.Parameters.Add(new SqlParameter("@complemento", endereco.Complemento));
                cmd3.Parameters.Add(new SqlParameter("@cidadeId", endereco.CidadeId));
                cmd3.Parameters.Add(new SqlParameter("@estadoCodUF", endereco.EstadoId));

            try
            {
                con.Open();

                SqlTransaction tran = con.BeginTransaction();

                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                cmd3.Transaction = tran;
                cmd3.ExecuteNonQuery();

                tran.Commit();

                string query = "INSERT INTO TBL_ENDERECO_FUNCIONARIO(END_INT_ID,FUN_INT_ID) VALUES (" + id + "," + id + ")";
                conexao.ExecutaInstrucaoNaBase(query);

            }
            catch (DomainExceptions)
            {
                throw new DomainExceptions("Erro ao cadastra o dados do usuario! ");
            }
            finally
            {
                con.Close();
            }
            
        }

        public DataTable RetornaEstado()
        {
             string query = "SELECT EST_INT_CODUF, EST_STR_NOME FROM TBL_ESTADO";
             DataTable dt = conexao.CarregarDados(query);
             return dt;
        }

        public DataTable RetornaCidade(string id)
        {
            string query = "SELECT CID_INT_ID, CID_STR_NOME FROM TBL_CIDADE WHERE EST_INT_CODUF=" + id;
            DataTable dt = conexao.CarregarDados(query);
            return dt;
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
            if (id=="")
            {
                throw new DomainExceptions("Não tem nenhum id login registrado na base de dados!");
            }
            conexao.desconectar();
            return id;
        }



    }

}
