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

namespace GerenciadorVeiculo1.Dal.DaoMotorista
{
    class DaoMotorista
    {
        public Motorista motorista { get; set; }
        public Telefone telefone { get; set; }
        public Endereco endereco { get; set; }
        public Cnh cnh { get; set; }
        public Empresa empresa { get; set; }

        Conexao conexao = new Conexao();

        public DaoMotorista()
        {
        }

        //Carrega Dados para o ger motorista
        public DataTable ConsultaMotorista()
        {
            string query = "SELECT M.MOT_INT_ID AS Id, M.MOT_STR_NOME AS Nome, M.MOT_STR_RG AS RG," +
                " T.TEL_INT_CELULAR AS Celular FROM TBL_MOTORISTA AS M INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = M.TEL_INT_ID";
            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        //Deletando motorista
        public void DeletMotorista()
        {
            string idEnd, idEndMot, idFot, idTel, idCnh;

            //query para trazer todos os ID
            string query = "SELECT T.TEL_INT_ID, EM.MOT_INT_ID, E.END_INT_ID,FT.FOT_INT_ID, CH.CNH_INT_ID,EP.EMP_INT_ID FROM TBL_MOTORISTA AS M "
           + " INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = M.TEL_INT_ID "
           + " INNER JOIN TBL_ENDERECO_MOTORISTA AS EM ON M.MOT_INT_ID = EM.MOT_INT_ID "
           + " INNER JOIN TBL_ENDERECO AS E ON EM.END_INT_ID = E.END_INT_ID "
           + " INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = M.FOT_INT_ID "
           + " INNER JOIN TBL_CNH AS CH ON CH.CNH_INT_ID = M.CNH_INT_ID "
           + " INNER JOIN TBL_EMPRESA AS EP ON EP.EMP_INT_ID = M.EMP_INT_ID"
           + " WHERE M.MOT_INT_ID = " + motorista.Id;

            // variavel tipo DataReader recebendo todos os ID
            SqlDataReader dr;
            dr = conexao.CarregarVariosDados(query);

            //Passando os ID para as Variaveis
            idTel = dr["TEL_INT_ID"].ToString();
            idEndMot = dr["MOT_INT_ID"].ToString();
            idEnd = dr["END_INT_ID"].ToString();
            idFot = dr["FOT_INT_ID"].ToString();
            idCnh = dr["CNH_INT_ID"].ToString();

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();
            SqlCommand cmd6 = con.CreateCommand();

            cmd1.CommandText = "DELETE TBL_ENDERECO_MOTORISTA WHERE MOT_INT_ID = " + idEndMot;
            cmd2.CommandText = "DELETE TBL_ENDERECO WHERE END_INT_ID = " + idEnd;
            cmd3.CommandText = "DELETE TBL_MOTORISTA WHERE MOT_INT_ID = " + motorista.Id.ToString();
            cmd4.CommandText = "DELETE TBL_FOTO WHERE FOT_INT_ID = " + idFot;
            cmd5.CommandText = "DELETE TBL_TELEFONE WHERE TEL_INT_ID = " + idTel;
            cmd6.CommandText = "DELETE TBL_CNH WHERE CNH_INT_ID = " + idCnh;

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
                cmd5.Transaction = tran;
                cmd5.ExecuteNonQuery();
                cmd6.Transaction = tran;
                cmd6.ExecuteNonQuery();

                tran.Commit();
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
        //Metodo que cadastra Motorista
        public void CadastraMotorista()
        {
            //string que recebem datas e converte para um formato aceitavel para BD
            string nasc = motorista.Nasc.ToString("yyyy-MM-dd");
            string validade = cnh.CnhValidade.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();

            cmd1.CommandText = "INSERT INTO TBL_TELEFONE(TEL_INT_DDD, TEL_INT_CELULAR, TEL_INT_FIXO, TEL_STR_OPERADORA) VALUES (@ddd, @celular, @fixo, @ope)";

            cmd2.CommandText = "INSERT INTO TBL_ENDERECO(END_STR_RUA, END_INT_NUMERO, END_STR_BAIRRO, END_INT_CEP, END_STR_COMPLEMENTO, CID_INT_ID, EST_INT_CODUF)"
                 + "VALUES(@rua, @numEnd, @bairro, @cep, @complemento,@cidadeId, @estadoCodUF)";

            cmd3.CommandText = "INSERT INTO TBL_CNH(CNH_STR_CATEGORIA,CNH_STR_REGISTRO,CNH_DATE_VALIDADE)VALUES" +
                "(@categoria,@registro,@validade)";

            cmd4.CommandText = "INSERT INTO TBL_MOTORISTA(MOT_STR_NOME,MOT_DATE_NASC,MOT_STR_CPF,MOT_STR_RG,MOT_STR_SEXO,MOT_STR_EMAIL,EMP_INT_ID, MOT_STR_STATUS, MOT_STR_SITUACAO)"
                 + "VALUES(@name, '" + nasc + "', @cpf, @rg, @sexo, @email, @empId,'ATIVO','Disponivel')";

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

            cmd3.Parameters.Add(new SqlParameter("@categoria", cnh.Categoria));
            cmd3.Parameters.Add(new SqlParameter("@registro", cnh.Registro));
            cmd3.Parameters.Add(new SqlParameter("@validade", validade));

            cmd4.Parameters.Add(new SqlParameter("@name", motorista.Name));
            cmd4.Parameters.Add(new SqlParameter("@cpf", motorista.Cpf));
            cmd4.Parameters.Add(new SqlParameter("@rg", motorista.Rg));
            cmd4.Parameters.Add(new SqlParameter("@sexo", motorista.Sexo));
            cmd4.Parameters.Add(new SqlParameter("@email", motorista.Email));
            cmd4.Parameters.Add(new SqlParameter("@empId", empresa.EmpId));

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
            //Traz o ultimo ID Cnh para fazer o relacionamento
            string query = "SELECT MAX(CNH_INT_ID) FROM TBL_CNH";
            string cnhId = conexao.SelecioneId(query);//Armazena o ID

            query = "SELECT MAX(TEL_INT_ID) FROM TBL_TELEFONE";
            string telId = conexao.SelecioneId(query);

            query = "SELECT MAX(FOT_INT_ID) FROM TBL_FOTO";
            string fotId = conexao.SelecioneId(query);

            query = "SELECT MAX(MOT_INT_ID) FROM TBL_MOTORISTA";
            string motId = conexao.SelecioneId(query);

            query = "SELECT MAX(END_INT_ID) FROM TBL_ENDERECO";
            string endId = conexao.SelecioneId(query);

            //relacionas os ID das outras tabelas a TBL_FUNCIONARIO
            query = "UPDATE TBL_MOTORISTA SET CNH_INT_ID = " + cnhId + ", TEL_INT_ID = " + telId + ", FOT_INT_ID = " + fotId + " WHERE MOT_INT_ID = " + motId;
            conexao.ExecutaInstrucaoNaBase(query);

            //insere as chaves estrangeira de N,N TBL_ENDERECO_FUNCIONARIO
            query = "INSERT INTO TBL_ENDERECO_MOTORISTA(END_INT_ID,MOT_INT_ID) VALUES (" + endId + "," + motId + ")";
            conexao.ExecutaInstrucaoNaBase(query);
        }   
        //traz todos os ID
        public SqlDataReader TrazTodosId()
        {
            string query = "SELECT T.TEL_INT_ID, EM.MOT_INT_ID, E.END_INT_ID,FT.FOT_INT_ID, CH.CNH_INT_ID,EP.EMP_INT_ID FROM TBL_MOTORISTA AS M "
          + " INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = M.TEL_INT_ID "
          + " INNER JOIN TBL_ENDERECO_MOTORISTA AS EM ON M.MOT_INT_ID = EM.MOT_INT_ID "
          + " INNER JOIN TBL_ENDERECO AS E ON EM.END_INT_ID = E.END_INT_ID "
          + " INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = M.FOT_INT_ID "
          + " INNER JOIN TBL_CNH AS CH ON CH.CNH_INT_ID = M.CNH_INT_ID "
          + " INNER JOIN TBL_EMPRESA AS EP ON EP.EMP_INT_ID = M.EMP_INT_ID"
          + " WHERE M.MOT_INT_ID = " + motorista.Id;

            SqlDataReader dr = conexao.CarregarVariosDados(query);

            return dr ;
        }
        //traz todos os dados do Motorista
        public SqlDataReader SelectMotorista(string id)
        {
            //nesse select existe convert que está convertendo a data de nasc para trazer a data sem a hora
            //o 103 é o tipo de formado Britânico/francês
            string query = "SELECT M.MOT_INT_ID, M.MOT_STR_NOME,CONVERT(VARCHAR(10),M.MOT_DATE_NASC,103) AS NASC,M.MOT_STR_CPF,M.MOT_STR_RG,M.MOT_STR_SEXO,M.MOT_STR_EMAIL,C.CNH_STR_REGISTRO,CONVERT(VARCHAR(10),c.CNH_DATE_VALIDADE,103) AS VALIDADE,C.CNH_STR_CATEGORIA,"
            +" T.TEL_INT_CELULAR,T.TEL_STR_OPERADORA,T.TEL_INT_FIXO,T.TEL_INT_DDD, EP.EMP_STR_NOME AS EMPRESA, ED.END_STR_RUA, ED.END_INT_NUMERO,ED.END_STR_COMPLEMENTO, "
            +" ED.END_STR_BAIRRO, ED.END_INT_CEP, ES.EST_STR_NOME, CD.CID_STR_NOME, FT.FOTO FROM TBL_MOTORISTA AS M"
            +" INNER JOIN TBL_CNH AS C ON C.CNH_INT_ID = M.CNH_INT_ID "
            +" INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = M.TEL_INT_ID"
            +" INNER JOIN TBL_EMPRESA AS EP ON EP.EMP_INT_ID = M.EMP_INT_ID"
            +" INNER JOIN TBL_ENDERECO_MOTORISTA AS EM ON EM.MOT_INT_ID = M.MOT_INT_ID"
            +" INNER JOIN TBL_ENDERECO AS ED ON ED.END_INT_ID = EM.END_INT_ID"
            +" INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = ED.EST_INT_CODUF"
            +" INNER JOIN TBL_CIDADE AS CD ON CD.CID_INT_ID = ED.CID_INT_ID"
            +" INNER JOIN TBL_FOTO AS FT ON FT.FOT_INT_ID = M.FOT_INT_ID"
            +" WHERE M.MOT_INT_ID = " + id;


            SqlDataReader dt = conexao.CarregarVariosDados(query);

            return dt;
        }
        //busca todos os motorista pelo ID da empresa
        public DataTable SelectMotoristasPelaEmpresa(string idEmpresa)
        {
            string query = "SELECT MOT_INT_ID, MOT_STR_NOME FROM TBL_MOTORISTA WHERE MOT_STR_SITUACAO = 'Disponivel' AND EMP_INT_ID = " + idEmpresa;
            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }

        public DataTable MotoristasViagemDisponivel(string idEmpresa,string idSaida)
        {
            string query = "SELECT M.MOT_INT_ID, M.MOT_STR_NOME FROM TBL_MOTORISTA AS M"
            +" INNER JOIN TBL_SAIDA AS S ON S.MOT_INT_ID = M.MOT_INT_ID"
            +" WHERE EMP_INT_ID = "+idEmpresa+" AND S.SAI_INT_ID = "+idSaida+" OR(M.MOT_STR_SITUACAO = 'Disponivel' AND EMP_INT_ID = "+ idEmpresa +")";

            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }

        public SqlDataReader SelectCnh(string idMot)
        {
            string query = "SELECT C.CNH_INT_ID, C.CNH_STR_REGISTRO, CONVERT(VARCHAR(10),C.CNH_DATE_VALIDADE,103) AS NASC FROM TBL_MOTORISTA AS M INNER JOIN TBL_CNH AS C ON M.CNH_INT_ID = C.CNH_INT_ID WHERE MOT_INT_ID = " + idMot;
            SqlDataReader dt = conexao.CarregarVariosDados(query);
            return dt;
        }


        public void UpdateMotorista()
        {
            string idEnd, idTel, idCnh;

            //string que recebem datas e converte para um formato aceitavel para BD
            string nasc = motorista.Nasc.ToString("yyyy-MM-dd");
            string validade = cnh.CnhValidade.ToString("yyyy-MM-dd");


            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand cmd5 = con.CreateCommand();

            // variavel tipo DataReader recebendo todos os ID
            SqlDataReader dr = TrazTodosId();

            //Passando os ID para as Variaveis
            idTel = dr["TEL_INT_ID"].ToString();
            idEnd = dr["END_INT_ID"].ToString();
            idCnh = dr["CNH_INT_ID"].ToString();

            cmd1.CommandText = "UPDATE TBL_MOTORISTA SET MOT_STR_NOME = @name, MOT_DATE_NASC = @nasc, MOT_STR_CPF = @cpf, MOT_STR_RG = @rg, MOT_STR_SEXO = @sexo, MOT_STR_EMAIL= @email, EMP_INT_ID = @EmpId WHERE MOT_INT_ID = @id";
            cmd2.CommandText = "UPDATE TBL_TELEFONE SET TEL_INT_DDD = @ddd , TEL_INT_FIXO = @fixo, TEL_INT_CELULAR = @celular ,TEL_STR_OPERADORA = @operadora WHERE TEL_INT_ID = @id";
            cmd3.CommandText = "UPDATE TBL_ENDERECO SET END_STR_RUA = @rua , END_INT_NUMERO = @numEnd , END_STR_COMPLEMENTO = @complemento , END_STR_BAIRRO = @bairro,END_INT_CEP = @cep , EST_INT_CODUF = @estadoCodUF , CID_INT_ID = @cidadeId WHERE END_INT_ID = @id";
            cmd4.CommandText = "UPDATE TBL_CNH SET CNH_STR_REGISTRO = @registro, CNH_DATE_VALIDADE = @validade, CNH_STR_CATEGORIA = @categoria WHERE CNH_INT_ID = @id ";

            cmd1.Parameters.Add(new SqlParameter("@name", motorista.Name));
            cmd1.Parameters.Add(new SqlParameter("@nasc", nasc));
            cmd1.Parameters.Add(new SqlParameter("@cpf", motorista.Cpf));
            cmd1.Parameters.Add(new SqlParameter("@rg", motorista.Rg));
            cmd1.Parameters.Add(new SqlParameter("@sexo", motorista.Sexo));
            cmd1.Parameters.Add(new SqlParameter("@email", motorista.Email));
            cmd1.Parameters.Add(new SqlParameter("@id", motorista.Id));
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

            cmd4.Parameters.Add(new SqlParameter("@registro", cnh.Registro));
            cmd4.Parameters.Add(new SqlParameter("@validade", validade));
            cmd4.Parameters.Add(new SqlParameter("@categoria", cnh.Categoria));
            cmd4.Parameters.Add(new SqlParameter("@id", idCnh));

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