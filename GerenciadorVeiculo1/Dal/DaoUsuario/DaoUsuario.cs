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

        //consulta alguns dados do usuário
        public DataTable ConsultaUsuario()
        {
            string query = "SELECT F.FUN_INT_ID AS Id, F.FUN_STR_NOME AS Nome, F.FUN_STR_RG AS RG, T.TEL_INT_CELULAR AS Celular FROM TBL_FUNCIONARIO AS F INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = F.TEL_INT_ID;";
            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        //deleta todos o usuario conforme o ID selecionado
        public void DeletUsuario()
        {
            string idFun, idTel, idEnd, idFot,idLog;

            string query = "SELECT F.FUN_INT_ID, T.TEL_INT_ID, E.END_INT_ID, FT.FOT_INT_ID, L.LOG_INT_ID  FROM TBL_FUNCIONARIO AS F "
            +" INNER JOIN TBL_ENDERECO_FUNCIONARIO AS EF ON EF.FUN_INT_ID = F.FUN_INT_ID "
            +" INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EF.END_INT_ID "
            +" INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = F.TEL_INT_ID "
            +" INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = F.FOT_INT_ID "
            +" INNER JOIN TBL_LOGINS AS L ON L.LOG_INT_ID = F.LOG_INT_ID "
            +" WHERE F.FUN_INT_ID =" + usuario.UsuarioId.ToString();

            SqlDataReader dt = conexao.CarregarVariosDados(query);

            idFun = dt["FUN_INT_ID"].ToString();
            idTel = dt["TEL_INT_ID"].ToString();
            idEnd = dt["END_INT_ID"].ToString();
            idFot = dt["FOT_INT_ID"].ToString();
            idLog = dt["LOG_INT_ID"].ToString();

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();
            SqlCommand cmd6 = con.CreateCommand();
            SqlCommand cmd7 = con.CreateCommand();


            cmd1.CommandText = "DELETE TBL_ENDERECO_FUNCIONARIO WHERE FUN_INT_ID = " + idFun;
            cmd2.CommandText = "DELETE TBL_ENDERECO WHERE END_INT_ID = " + idEnd;
            cmd3.CommandText = "DELETE TBL_FUNCIONARIO WHERE FUN_INT_ID = " + idFun;
            cmd4.CommandText = "DELETE TBL_FOTO WHERE FOT_INT_ID = "+ idFot;
            cmd5.CommandText = "DELETE TBL_TELEFONE WHERE TEL_INT_ID = " + idTel;
            cmd6.CommandText = "DELETE TBL_LOGINS WHERE LOG_INT_ID = " + idLog;
            
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
            cmd6.Transaction = tran;
            cmd6.ExecuteNonQuery();

            tran.Commit();

            con.Close();
        }
        public void CadastraUsuario()
        {

            string nasc = usuario.Nasc.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();

            cmd1.CommandText = "INSERT INTO TBL_LOGINS(LOG_STR_LOGIN, LOG_STR_SENHA) VALUES ('"+logins.Log+"','"+logins.Senha+"')";

            cmd2.CommandText = "INSERT INTO TBL_TELEFONE(TEL_INT_DDD,TEL_INT_CELULAR,TEL_INT_FIXO,TEL_STR_OPERADORA)"
            + "VALUES(@ddd, @celular, @fixo, @ope)";

            cmd3.CommandText = "INSERT INTO TBL_ENDERECO (END_STR_RUA,END_INT_NUMERO,END_STR_BAIRRO,END_INT_CEP,END_STR_COMPLEMENTO,CID_INT_ID,EST_INT_CODUF)"
            + "VALUES(@rua, @numEnd, @bairro, @cep, @complemento,@cidadeId, @estadoCodUF)";

            cmd4.CommandText = "INSERT INTO TBL_FUNCIONARIO(FUN_STR_NOME, FUN_DATE_NASC, FUN_STR_CPF,FUN_STR_RG, FUN_STR_CARGO, FUN_STR_SEXO, FUN_STR_EMAIL) "
            +"VALUES(@name, '" + nasc + "', @cpf,@rg, @cargo, @sexo, @email)";

   

            cmd2.Parameters.Add(new SqlParameter("@ddd", telefone.Ddd));
            cmd2.Parameters.Add(new SqlParameter("@celular",telefone.Celular));
            cmd2.Parameters.Add(new SqlParameter("@fixo", telefone.Fixo));
            cmd2.Parameters.Add(new SqlParameter("@ope", telefone.Operadora));

            cmd3.Parameters.Add(new SqlParameter("@rua", endereco.Rua));
            cmd3.Parameters.Add(new SqlParameter("@numEnd", endereco.NumeroRua));
            cmd3.Parameters.Add(new SqlParameter("@bairro", endereco.Bairro));
            cmd3.Parameters.Add(new SqlParameter("@cep", endereco.Cep));
            cmd3.Parameters.Add(new SqlParameter("@complemento", endereco.Complemento));
            cmd3.Parameters.Add(new SqlParameter("@cidadeId", endereco.CidadeId));
            cmd3.Parameters.Add(new SqlParameter("@estadoCodUF", endereco.EstadoId));

            cmd4.Parameters.Add(new SqlParameter("@name", usuario.Name));
            cmd4.Parameters.Add(new SqlParameter("@cpf", usuario.Cpf));
            cmd4.Parameters.Add(new SqlParameter("@rg", usuario.Rg));
            cmd4.Parameters.Add(new SqlParameter("@cargo", usuario.Cargo));
            cmd4.Parameters.Add(new SqlParameter("@sexo", usuario.Sexo));
            cmd4.Parameters.Add(new SqlParameter("@email", usuario.Email));

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
                cmd4.Transaction = tran;
                cmd4.ExecuteNonQuery();

                tran.Commit();

                RelacionandoId();

            }
            catch (DomainExceptions)
            {
                throw new DomainExceptions("Erro ao cadastra o dados do usuário! ");
            }
            finally
            {
                con.Close();
                
            }

        }
        //Metodo que adiciona as chaves estrangeiras
        public void RelacionandoId()
        {
            //Traz o ultimo ID login para fazer o relacionamento
            string query = "SELECT MAX(LOG_INT_ID) FROM TBL_LOGINS";
            string logId = conexao.SelecioneId(query);//Armazena o ID

            query = "SELECT MAX(TEL_INT_ID) FROM TBL_TELEFONE";
            string telId = conexao.SelecioneId(query);

            query = "SELECT MAX(FOT_INT_ID) FROM TBL_FOTO";
            string fotId = conexao.SelecioneId(query);

            query = "SELECT MAX(FUN_INT_ID) FROM TBL_FUNCIONARIO";
            string funId = conexao.SelecioneId(query);

            query = "SELECT MAX(END_INT_ID) FROM TBL_ENDERECO";
            string endId = conexao.SelecioneId(query);

            //relacionas os ID das outras tabelas a TBL_FUNCIONARIO
            query = "UPDATE TBL_FUNCIONARIO SET LOG_INT_ID = "+logId+", TEL_INT_ID = "+telId+", FOT_INT_ID = "+fotId+" WHERE FUN_INT_ID = "+funId;
            conexao.ExecutaInstrucaoNaBase(query);

            //insere as chaves estrangeira de N,N TBL_ENDERECO_FUNCIONARIO
            query = "INSERT INTO TBL_ENDERECO_FUNCIONARIO(END_INT_ID,FUN_INT_ID) VALUES (" + endId + "," +funId+ ")";
            conexao.ExecutaInstrucaoNaBase(query);
        }
        //Seleciona todos os dados da tabela tbl_funcionario do usuario
        public SqlDataReader TrazTodosId()
        {
            string query = "SELECT F.FUN_INT_ID, T.TEL_INT_ID, E.END_INT_ID, FT.FOT_INT_ID, L.LOG_INT_ID  FROM TBL_FUNCIONARIO AS F "
            + " INNER JOIN TBL_ENDERECO_FUNCIONARIO AS EF ON EF.FUN_INT_ID = F.FUN_INT_ID "
            + " INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EF.END_INT_ID "
            + " INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = F.TEL_INT_ID "
            + " INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = F.FOT_INT_ID "
            + " INNER JOIN TBL_LOGINS AS L ON L.LOG_INT_ID = F.LOG_INT_ID "
            + " WHERE F.FUN_INT_ID =" + usuario.UsuarioId.ToString();

            SqlDataReader dr = conexao.CarregarVariosDados(query);

            return dr;
        }
        public SqlDataReader SelectUsuario(string id)
        {
            //nesse select existe convert que está convertendo a data de nasc para trazer a data sem a hora
            //o 103 é o tipo de formado Britânico/francês
            string query = "SELECT F.FUN_STR_NOME,CONVERT(VARCHAR(10),F.FUN_DATE_NASC,103) AS NASC, F.FUN_STR_CPF, F.FUN_STR_RG, F.FUN_STR_CARGO, F.FUN_STR_SEXO, F.FUN_STR_EMAIL, T.TEL_INT_DDD, T.TEL_INT_CELULAR,"
            + " T.TEL_INT_FIXO, T.TEL_STR_OPERADORA, E.END_STR_RUA, E.END_INT_NUMERO, E.END_STR_COMPLEMENTO, E.END_STR_BAIRRO, E.END_INT_CEP, ES.EST_STR_NOME, C.CID_STR_NOME, "
            +" FT.FOTO FROM TBL_FUNCIONARIO AS F "
            +" INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = F.TEL_INT_ID "
            +" INNER JOIN TBL_ENDERECO_FUNCIONARIO AS EF ON EF.FUN_INT_ID = F.FUN_INT_ID "
            +" INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EF.END_INT_ID "
            +" INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = E.EST_INT_CODUF "
            +" INNER JOIN TBL_CIDADE AS C ON C.CID_INT_ID = E.CID_INT_ID "
            +" INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = F.FOT_INT_ID "
            +" WHERE F.FUN_INT_ID = " + id;

            SqlDataReader dt = conexao.CarregarVariosDados(query);

            return dt;
        }
        //atualiza os dados do usuário
        public void UpdateUsuario()
        {
            string idEnd, idTel, idFot;
            //string que recebem datas e converte para um formato aceitavel para BD
            string nasc = usuario.Nasc.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();

            // variavel tipo DataReader recebendo todos os ID
            SqlDataReader dr = TrazTodosId();

            //Passando os ID para as Variaveis
            idTel = dr["TEL_INT_ID"].ToString();
            idEnd = dr["END_INT_ID"].ToString();
            idFot = dr["FOT_INT_ID"].ToString();


            cmd1.CommandText = "UPDATE TBL_FUNCIONARIO SET FUN_STR_NOME = @name, FUN_DATE_NASC = @nasc , FUN_STR_CPF = @cpf, FUN_STR_RG = @rg, FUN_STR_CARGO = @cargo, FUN_STR_SEXO = @sexo, FUN_STR_EMAIL = @email WHERE FUN_INT_ID = @idFun";

            cmd2.CommandText = "UPDATE TBL_TELEFONE SET TEL_INT_DDD = @ddd, TEL_INT_FIXO = @fixo , TEL_INT_CELULAR = @celular , TEL_STR_OPERADORA = @operadora WHERE TEL_INT_ID = @idTel";

            cmd3.CommandText = "UPDATE TBL_ENDERECO SET END_STR_RUA = @rua , END_INT_NUMERO = @numEnd , END_STR_COMPLEMENTO = @complemento , END_STR_BAIRRO = @bairro,END_INT_CEP = @cep ,"
                + "EST_INT_CODUF = @estadoCodUF , CID_INT_ID = @cidadeId WHERE END_INT_ID = @idEnd";



            cmd1.Parameters.Add(new SqlParameter("@name", usuario.Name));
            cmd1.Parameters.Add(new SqlParameter("@nasc", nasc));
            cmd1.Parameters.Add(new SqlParameter("@cpf", usuario.Cpf));
            cmd1.Parameters.Add(new SqlParameter("@rg", usuario.Rg));
            cmd1.Parameters.Add(new SqlParameter("@cargo", usuario.Cargo));
            cmd1.Parameters.Add(new SqlParameter("@sexo", usuario.Sexo));
            cmd1.Parameters.Add(new SqlParameter("@email", usuario.Email));
            cmd1.Parameters.Add(new SqlParameter("@idFun", usuario.UsuarioId));

            cmd2.Parameters.Add(new SqlParameter("@ddd", telefone.Ddd));
            cmd2.Parameters.Add(new SqlParameter("@celular", telefone.Celular));
            cmd2.Parameters.Add(new SqlParameter("@fixo", telefone.Fixo));
            cmd2.Parameters.Add(new SqlParameter("@operadora", telefone.Operadora));
            cmd2.Parameters.Add(new SqlParameter("@idTel", idTel));

            cmd3.Parameters.Add(new SqlParameter("@rua", endereco.Rua));
            cmd3.Parameters.Add(new SqlParameter("@numEnd", endereco.NumeroRua));
            cmd3.Parameters.Add(new SqlParameter("@complemento", endereco.Complemento));
            cmd3.Parameters.Add(new SqlParameter("@bairro", endereco.Bairro));
            cmd3.Parameters.Add(new SqlParameter("@cep", endereco.Cep));
            cmd3.Parameters.Add(new SqlParameter("@cidadeId", endereco.CidadeId));
            cmd3.Parameters.Add(new SqlParameter("@estadoCodUF", endereco.EstadoId));
            cmd3.Parameters.Add(new SqlParameter("@idEnd", idEnd));

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

            }
            catch (DomainExceptions)
            {
                throw new DomainExceptions("Erro ao atualizar dados do usuário! ");
            }
            finally
            {
                con.Close();
            }

        }

    }

}
