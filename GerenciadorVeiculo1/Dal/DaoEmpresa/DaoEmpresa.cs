using dllDao;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Dal.DaoEmpresa
{
    class DaoEmpresa
    {
        public Empresa empresa { get; set; }
        public Telefone telefone { get; set; }
        public Endereco endereco { get; set; }

        Conexao conexao = new Conexao();

        //consulta inicial das empresas
        public DataTable ConsultaEmpresa(string status)
        {
            string query = "";
            //traz as empresas que tem como status = ativo
            if (status == "ATIVO")
            {
                query = "SELECT EP.EMP_INT_ID AS ID, EP.EMP_STR_NOME AS NOME, EMP_STR_CNPJ AS CNPJ, T.TEL_INT_CELULAR AS CELULAR, T.TEL_INT_FIXO AS FIXO"
                + " FROM TBL_EMPRESA AS EP INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = EP.TEL_INT_ID WHERE EP.EMP_STR_STATUS = 'ATIVO'";
            }
            //traz todas as empresas
            else
            {
                query = "SELECT EP.EMP_INT_ID AS ID, EP.EMP_STR_NOME AS NOME, EMP_STR_CNPJ AS CNPJ, T.TEL_INT_CELULAR AS CELULAR, T.TEL_INT_FIXO AS FIXO"
               + " FROM TBL_EMPRESA AS EP INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = EP.TEL_INT_ID";
            }

            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        //traz todos os ID
        public SqlDataReader TrazTodosId()
        {
            string query = "SELECT EP.EMP_INT_ID, T.TEL_INT_ID, EDP.EMP_INT_ID, E.END_INT_ID FROM TBL_EMPRESA AS EP"
            + " INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = EP.TEL_INT_ID"
            + " INNER JOIN TBL_ENDERECO_EMPRESA AS EDP ON EDP.EMP_INT_ID = EP.EMP_INT_ID"
            + " INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EDP.END_INT_ID WHERE EP.EMP_INT_ID = " + empresa.EmpId.ToString();

            SqlDataReader dr = conexao.CarregarVariosDados(query);
            return dr;
        }
        //Deleta empresa
        public void DeleteEmpresa()
        {
            string idTel, idEndEmp, idEnd;

            SqlDataReader dr;
            dr = TrazTodosId();

            //Passando os ID para as Variaveis
            idTel = dr["TEL_INT_ID"].ToString();
            idEndEmp = dr["EMP_INT_ID"].ToString();
            idEnd = dr["END_INT_ID"].ToString();

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();

            cmd1.CommandText = "DELETE TBL_ENDERECO_EMPRESA WHERE EMP_INT_ID = " + empresa.EmpId;
            cmd2.CommandText = "DELETE TBL_ENDERECO WHERE END_INT_ID = " + idEnd;
            cmd3.CommandText = "DELETE TBL_EMPRESA WHERE EMP_INT_ID = " + empresa.EmpId;
            cmd4.CommandText = "DELETE TBL_TELEFONE WHERE TEL_INT_ID = " + idTel;

            con.Open();

            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                cmd3.Transaction = tran;
                cmd3.ExecuteNonQuery();
                cmd4.Transaction = tran;
                cmd4.ExecuteNonQuery();

                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();

                throw new DomainExceptions("Erro, ao excluir a empresa, verifique se não á motoristas cadastrados que ainda estão vinculados a essa empresa.");
            }
            finally
            {
                con.Close();
            }
        }
        //Cadastra empresa
        public void cadastraEmpresa()
        {

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();

            cmd1.CommandText = "INSERT INTO TBL_TELEFONE(TEL_INT_DDD, TEL_INT_CELULAR, TEL_INT_FIXO, TEL_STR_OPERADORA) VALUES (@ddd, @celular, @fixo, @ope)";

            cmd2.CommandText = "INSERT INTO TBL_ENDERECO(END_STR_RUA, END_INT_NUMERO, END_STR_BAIRRO, END_INT_CEP, END_STR_COMPLEMENTO, CID_INT_ID, EST_INT_CODUF)"
                 + "VALUES(@rua, @numEnd, @bairro, @cep, @complemento,@cidadeId, @estadoCodUF)";

            cmd3.CommandText = "INSERT INTO TBL_EMPRESA(EMP_STR_NOME,EMP_STR_CNPJ,EMP_STR_EMAIL,EMP_STR_STATUS)" +
                "VALUES(@empNome, @cnpj, @email,'ATIVO')";


            cmd1.Parameters.Add(new SqlParameter("@ddd", telefone.Ddd));
            cmd1.Parameters.Add(new SqlParameter("@celular", telefone.Celular));
            cmd1.Parameters.Add(new SqlParameter("@fixo", telefone.Fixo));
            cmd1.Parameters.Add(new SqlParameter("@ope", telefone.Operadora));

            cmd2.Parameters.Add(new SqlParameter("@rua", endereco.Rua));
            cmd2.Parameters.Add(new SqlParameter("@numEnd", endereco.NumeroRua));
            cmd2.Parameters.Add(new SqlParameter("@bairro", endereco.Bairro));
            cmd2.Parameters.Add(new SqlParameter("@cep", endereco.Cep));
            cmd2.Parameters.Add(new SqlParameter("@complemento", endereco.Complemento));
            cmd2.Parameters.Add(new SqlParameter("@cidadeId", endereco.CidadeId));
            cmd2.Parameters.Add(new SqlParameter("@estadoCodUF", endereco.EstadoId));

            cmd3.Parameters.Add(new SqlParameter("@empNome", empresa.NomeEmp));
            cmd3.Parameters.Add(new SqlParameter("@cnpj", empresa.Cnpj));
            cmd3.Parameters.Add(new SqlParameter("@email", empresa.Email));

            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                cmd3.Transaction = tran;
                cmd3.ExecuteNonQuery();

                tran.Commit();

                RelacionandoId();

            }
            catch (Exception)
            {
                tran.Rollback();
            }
            finally
            {
                con.Close();

            }

        }
        //Relaciona as chaves estrangeiras nas tabelas
        public void RelacionandoId()
        {
            string query = "SELECT MAX(TEL_INT_ID) FROM TBL_TELEFONE";
            string telId = conexao.SelecioneId(query);

            query = "SELECT MAX(END_INT_ID) FROM TBL_ENDERECO";
            string endId = conexao.SelecioneId(query);

            query = "SELECT MAX(EMP_INT_ID) FROM TBL_EMPRESA";
            string empId = conexao.SelecioneId(query);

            //relacionas os ID das outras tabelas a TBL_FUNCIONARIO
            query = "UPDATE TBL_EMPRESA SET TEL_INT_ID = " + telId + " WHERE EMP_INT_ID = " + empId;
            conexao.ExecutaInstrucaoNaBase(query);

            //insere as chaves estrangeira de N,N TBL_ENDERECO_FUNCIONARIO
            query = "INSERT INTO TBL_ENDERECO_EMPRESA(END_INT_ID,EMP_INT_ID) VALUES (" + endId + "," + empId + ")";
            conexao.ExecutaInstrucaoNaBase(query);
        }
        //traz todos os dados da Empresa
        public SqlDataReader SelectEmpresa(string id)
        {
            //nesse select existe convert que está convertendo a data de nasc para trazer a data sem a hora
            //o 103 é o tipo de formado Britânico/francês
            string query = "SELECT EP.EMP_INT_ID, EP.EMP_STR_NOME,EP.EMP_STR_CNPJ,EP.EMP_STR_DESC,EP.EMP_STR_EMAIL,EP.EMP_STR_STATUS,"
            + " T.TEL_INT_CELULAR,T.TEL_STR_OPERADORA,T.TEL_INT_DDD, T.TEL_INT_FIXO,E.END_STR_RUA,E.END_INT_NUMERO,E.END_STR_BAIRRO,"
            + " E.END_STR_COMPLEMENTO,E.END_INT_CEP, ES.EST_STR_NOME, C.CID_STR_NOME FROM TBL_EMPRESA AS EP "
            + " INNER JOIN TBL_TELEFONE AS T ON EP.TEL_INT_ID = T.TEL_INT_ID"
            + " INNER JOIN TBL_ENDERECO_EMPRESA AS EE ON EE.EMP_INT_ID = EP.EMP_INT_ID"
            + " INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EE.END_INT_ID"
            + " INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = E.EST_INT_CODUF"
            + " INNER JOIN TBL_CIDADE AS C ON C.CID_INT_ID = E.CID_INT_ID"
            + " WHERE EP.EMP_INT_ID = " + id;

            SqlDataReader dt = conexao.CarregarVariosDados(query); 
            return dt;
        }
        public void UpdateEmpresa()
        {
            string idEnd, idTel;

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();

            // variavel tipo DataReader recebendo todos os ID
            SqlDataReader dr = TrazTodosId();

            //Passando os ID para as Variaveis
            idTel = dr["TEL_INT_ID"].ToString();
            idEnd = dr["END_INT_ID"].ToString();

            cmd1.CommandText = "UPDATE TBL_EMPRESA SET EMP_STR_NOME = @name, EMP_STR_CNPJ = @cnpj, EMP_STR_DESC = @desc, EMP_STR_EMAIL = @email ,EMP_STR_STATUS = @status WHERE EMP_INT_ID = " + empresa.EmpId;
            cmd2.CommandText = "UPDATE TBL_TELEFONE SET TEL_INT_DDD = @ddd , TEL_INT_FIXO = @fixo, TEL_INT_CELULAR = @celular ,TEL_STR_OPERADORA = @operadora WHERE TEL_INT_ID = @id";
            cmd3.CommandText = "UPDATE TBL_ENDERECO SET END_STR_RUA = @rua , END_INT_NUMERO = @numEnd , END_STR_COMPLEMENTO = @complemento , END_STR_BAIRRO = @bairro,END_INT_CEP = @cep , EST_INT_CODUF = @estadoCodUF , CID_INT_ID = @cidadeId WHERE END_INT_ID = @id";
           
            cmd1.Parameters.Add(new SqlParameter("@name", empresa.NomeEmp));
            cmd1.Parameters.Add(new SqlParameter("@cnpj", empresa.Cnpj));
            cmd1.Parameters.Add(new SqlParameter("@desc", empresa.Desc));
            cmd1.Parameters.Add(new SqlParameter("@email", empresa.Email));
            cmd1.Parameters.Add(new SqlParameter("@status", empresa.Status));
            cmd1.Parameters.Add(new SqlParameter("@EmpId", empresa.EmpId));

            cmd2.Parameters.Add(new SqlParameter("@ddd", telefone.Ddd));
            cmd2.Parameters.Add(new SqlParameter("@celular", telefone.Celular));
            cmd2.Parameters.Add(new SqlParameter("@fixo", telefone.Fixo));
            cmd2.Parameters.Add(new SqlParameter("@operadora", telefone.Operadora));
            cmd2.Parameters.Add(new SqlParameter("@id", idTel));

            cmd3.Parameters.Add(new SqlParameter("@rua", endereco.Rua));
            cmd3.Parameters.Add(new SqlParameter("@numEnd", endereco.NumeroRua));
            cmd3.Parameters.Add(new SqlParameter("@complemento", endereco.Complemento));
            cmd3.Parameters.Add(new SqlParameter("@bairro", endereco.Bairro));
            cmd3.Parameters.Add(new SqlParameter("@cep", endereco.Cep));
            cmd3.Parameters.Add(new SqlParameter("@cidadeId", endereco.CidadeId));
            cmd3.Parameters.Add(new SqlParameter("@estadoCodUF", endereco.EstadoId));
            cmd3.Parameters.Add(new SqlParameter("@id", idEnd));

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
                throw new DomainExceptions("Erro ao atualizar dados da Empresa!");
            }
            finally
            {
                con.Close();
            }
        }
    }
}