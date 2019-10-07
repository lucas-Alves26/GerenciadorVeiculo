﻿using dllDao;
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
            string query = "SELECT F.FUN_INT_ID AS Id, F.FUN_STR_NOME AS Nome, F.FUN_STR_RG AS RG, T.TEL_INT_CELULAR AS Celular FROM TBL_FUNCIONARIO AS F INNER JOIN TBL_TELEFONE AS T ON T.FUN_INT_ID = F.FUN_INT_ID;";
            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        //deleta todos o usuario conforme o ID selecionado
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
        //Cadastra todas as informações do usuario
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
                throw new DomainExceptions("Erro ao cadastra o dados do usuário! ");
            }
            finally
            {
                con.Close();
            }

        }
        //Retorna apenas o loginID
        public string SelecioneId()
        {
            string id;
            Conexao conexao = new Conexao();
            string query = "SELECT MAX(LOG_INT_ID) FROM TBL_LOGINS";

            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand sqlCommand = new SqlCommand(query, con);


            sqlCommand.Connection = conexao.conectar();
            id = sqlCommand.ExecuteScalar().ToString();
            if (id == "")
            {
                throw new DomainExceptions("Não tem nenhum id login registrado na base de dados!");
            }
            conexao.desconectar();
            return id;
        }
        //Seleciona todos os dados da tabela tbl_funcionario do usuario
        public SqlDataReader SelectUsuario(string id)
        {

            //nesse select existe convert que está convertendo a data de nasc para trazer a data sem a hora
            //o 103 é o tipo de formado Britânico/francês
            string query = "SELECT F.FUN_STR_NOME AS NOME, CONVERT(VARCHAR(11),F.FUN_DATE_NASC,103) AS NASC, F.FUN_STR_CPF AS CPF, F.FUN_STR_CNH AS CNH, F.FUN_STR_RG AS RG, "
            + "F.FUN_STR_CARGO AS CARGO, F.FUN_STR_SEXO AS SEXO, FUN_STR_EMAIL AS EMAIL, T.TEL_INT_DDD AS DDD, T.TEL_INT_CELULAR AS TEL, T.TEL_INT_FIXO AS FIX, "
            +"T.TEL_STR_OPERADORA AS OPE, E.END_STR_RUA AS RUA, E.END_INT_NUMERO AS NUMERO, E.END_STR_COMPLEMENTO AS COMPLEMENTO, E.END_STR_BAIRRO AS BAIRRO, "
            + "E.END_INT_CEP AS CEP, ES.EST_STR_NOME AS ESTADO, C.CID_STR_NOME AS CIDADE, FT.FOTO AS FOTO "
            + "FROM TBL_FUNCIONARIO AS F "
            +"INNER JOIN TBL_TELEFONE AS T ON T.FUN_INT_ID = F.FUN_INT_ID "
            +"INNER JOIN TBL_ENDERECO_FUNCIONARIO AS EF ON EF.END_INT_ID = F.FUN_INT_ID "
            +"INNER JOIN TBL_ENDERECO AS E ON EF.END_INT_ID = E.END_INT_ID "
            +"INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = E.EST_INT_CODUF "
            +"INNER JOIN TBL_CIDADE AS C ON E.CID_INT_ID = C.CID_INT_ID "
            +"INNER JOIN TBL_FOTO AS FT ON FT.FUN_INT_ID = F.FUN_INT_ID "
            + "WHERE F.FUN_INT_ID = "+ id;

            SqlDataReader dt = conexao.CarregarVariosDados(query);

            return dt;
        }
        //atualiza os dados do usuário
        public void UpdateUsuario(string id)
        {
            string nasc = usuario.Nasc.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            //SqlCommand cmd2 = con.CreateCommand();
            //SqlCommand cmd3 = con.CreateCommand();
            //SqlCommand cmd4 = con.CreateCommand();

            cmd1.CommandText = "UPDATE TBL_FUNCIONARIO SET FUN_STR_NOME = @name, FUN_DATE_NASC = "+nasc+", FUN_STR_CPF = @cpf, FUN_STR_RG = @rg, FUN_STR_CNH = @cnh, FUN_STR_CARGO = @cargo, FUN_STR_SEXO = @sexo, FUN_STR_EMAIL = @email WHERE FUN_INT_ID = @id";
           


            cmd1.Parameters.Add(new SqlParameter("@name", usuario.Name));
            cmd1.Parameters.Add(new SqlParameter("@cpf", usuario.Cpf));
            cmd1.Parameters.Add(new SqlParameter("@cnh", usuario.Cnh));
            cmd1.Parameters.Add(new SqlParameter("@rg", usuario.Rg));
            cmd1.Parameters.Add(new SqlParameter("@cargo", usuario.Cargo));
            cmd1.Parameters.Add(new SqlParameter("@sexo", usuario.Sexo));
            cmd1.Parameters.Add(new SqlParameter("@email", usuario.Email));
            cmd1.Parameters.Add(new SqlParameter("@id", id));

            //cmd2.Parameters.Add(new SqlParameter("@ddd", telefone.Ddd));
            //cmd2.Parameters.Add(new SqlParameter("@celular", telefone.Celular));
            //cmd2.Parameters.Add(new SqlParameter("@fixo", telefone.Fixo));
            //cmd2.Parameters.Add(new SqlParameter("@operadora", telefone.Operadora));
            //cmd2.Parameters.Add(new SqlParameter("@id", id));

            //cmd3.Parameters.Add(new SqlParameter("@rua", endereco.Rua));
            //cmd3.Parameters.Add(new SqlParameter("@numEnd", endereco.NumeroRua));
            //cmd3.Parameters.Add(new SqlParameter("@bairro", endereco.Bairro));
            //cmd3.Parameters.Add(new SqlParameter("@cep", endereco.Cep));
            //cmd3.Parameters.Add(new SqlParameter("@complemento", endereco.Complemento));
            //cmd3.Parameters.Add(new SqlParameter("@cidadeId", endereco.CidadeId));
            //cmd3.Parameters.Add(new SqlParameter("@estadoCodUF", endereco.EstadoId));

            try
            {
                con.Open();

                SqlTransaction tran = con.BeginTransaction();

                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                //cmd2.Transaction = tran;
                //cmd2.ExecuteNonQuery();
                //cmd3.Transaction = tran;
                //cmd3.ExecuteNonQuery();

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
