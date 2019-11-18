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

namespace GerenciadorVeiculo1.Dal.DaoVeiculo
{
    class DaoVeiculo
    {
        public Empresa empresa { get; set; }
        public Veiculo veiculo { get; set; }
        public Telefone telefone { get; set; }
        public Endereco endereco { get; set; }
        public Seguro seguro { get; set; }

        Conexao conexao = new Conexao();
        public DataTable ConsultaVeiculo(string status)
        {
            string query = "";
            //traz as empresas que tem como status = ativo
            if (status == "ATIVO")
            {
                query = "SELECT v.VEI_INT_ID as ID, V.VEI_STR_MODELO AS Modelo, V.VEI_STR_PLACA AS Placa, E.EMP_STR_NOME AS Empresa, V.VEI_STR_STATUS AS Situação FROM TBL_VEICULO AS V "
                +"INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID WHERE V.VEI_STR_STATUS = 'ATIVO' ORDER BY EMP_STR_NOME ASC";
            }
            //traz todas as empresas
            else
            {
                query = "SELECT v.VEI_INT_ID as ID, V.VEI_STR_MODELO AS Modelo, V.VEI_STR_PLACA AS Placa, E.EMP_STR_NOME AS Empresa, V.VEI_STR_STATUS AS Situação FROM TBL_VEICULO AS V "
               + "INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID ORDER BY EMP_STR_NOME ASC";
            }

            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        public SqlDataReader TrazTodosId()
        {
            string query = "SELECT v.VEI_INT_ID, E.EMP_INT_ID, S.SEG_INT_ID FROM TBL_VEICULO AS V "
            +"INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID "
            +"INNER JOIN TBL_SEGURO_VEICULO AS SV ON v.VEI_INT_ID = SV.VEI_INT_ID "
            + "INNER JOIN TBL_SEGURO AS S ON S.SEG_INT_ID = SV.SEG_INT_ID WHERE v.VEI_INT_ID = " + veiculo.VeiId.ToString();

            SqlDataReader dr = conexao.CarregarVariosDados(query);
            return dr;
        }
        public void DeleteVeiculo()
        {
            string segId;

            SqlDataReader dr;
            dr = TrazTodosId();

            //Passando os ID para as Variaveis
            segId = dr["SEG_INT_ID"].ToString();
       
            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();

            cmd1.CommandText = "DELETE TBL_SEGURO_VEICULO WHERE VEI_INT_ID = " + veiculo.VeiId.ToString();
            cmd2.CommandText = "DELETE TBL_VEICULO WHERE VEI_INT_ID = " + veiculo.VeiId.ToString();
            cmd3.CommandText = "DELETE TBL_SEGURO WHERE SEG_INT_ID = " + segId.ToString();

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
            }
            catch (Exception)
            {
                tran.Rollback();

                throw new DomainExceptions("Erro, ao excluir a veículo, verifique se não á motoristas cadastrados que ainda estão vinculados a essa empresa.");
            }
            finally
            {
                con.Close();
            }
        }
        public void CadastraVeiculo()
        {
            //string que recebem datas e converte para um formato aceitavel para BD
            string dateIni = seguro.DateIni.ToString("yyyy-MM-dd");
            string dateFin =seguro.DateFin.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();

            if (dateIni == "1989-01-01" || dateFin == "1989-01-01")
            {
                cmd1.CommandText = "INSERT INTO TBL_SEGURO(SEG_STR_STATUS) " +
                "VALUES('INATIVO')";
            }
            else
            {
                cmd1.CommandText = "INSERT INTO TBL_SEGURO(SEG_STR_NOME, SEG_DATE_INICIAL, SEG_DATE_FINAL, SEG_STR_TIPO, SEG_STR_STATUS) " +
                "VALUES(@segNome, @dateIni, @dateFDinal,@tipo, 'ATIVO')";
            }

            cmd2.CommandText = "INSERT INTO TBL_VEICULO (EMP_INT_ID,EST_INT_CODUF,VEI_STR_MARCA,VEI_STR_MODELO,VEI_STR_PLACA,VEI_STR_CHASSI,VEI_STR_RENAVAM,VEI_STR_COR,VEI_STR_COMBUSTIVEL,VEI_STR_LUGARES,VEI_DOUBLE_KM,VEI_DATE_FAB,VEI_DATE_ANO_MODELO,VEI_STR_STATUS,VEI_STR_TIPO) " +
            " VALUES (@emp,@uf,@marca,@modelo,@placa,@chassi,@renavam,@cor,@combustivel,@lugar,@km,@anoFab,@anoMod,'ATIVO',@tipo)";


            cmd1.Parameters.Add(new SqlParameter("@segNome", seguro.Nome));
            cmd1.Parameters.Add(new SqlParameter("@dateIni", dateIni));
            cmd1.Parameters.Add(new SqlParameter("@dateFDinal", dateFin));
            cmd1.Parameters.Add(new SqlParameter("@tipo", seguro.Tipo));

            cmd2.Parameters.Add(new SqlParameter("@emp", empresa.EmpId));
            cmd2.Parameters.Add(new SqlParameter("@uf", endereco.EstadoId));
            cmd2.Parameters.Add(new SqlParameter("@marca", veiculo.Marca));
            cmd2.Parameters.Add(new SqlParameter("@modelo", veiculo.Modelo));
            cmd2.Parameters.Add(new SqlParameter("@placa", veiculo.Placa));
            cmd2.Parameters.Add(new SqlParameter("@chassi", veiculo.Chassi));
            cmd2.Parameters.Add(new SqlParameter("@renavam", veiculo.Renavam));
            cmd2.Parameters.Add(new SqlParameter("@cor", veiculo.Cor));
            cmd2.Parameters.Add(new SqlParameter("@combustivel", veiculo.Combustivel));
            cmd2.Parameters.Add(new SqlParameter("@lugar", veiculo.Lugares.ToString()));
            cmd2.Parameters.Add(new SqlParameter("@km", veiculo.Km.ToString()));
            cmd2.Parameters.Add(new SqlParameter("@anoFab",veiculo.AnoFab.ToString()));
            cmd2.Parameters.Add(new SqlParameter("@anoMod", veiculo.ModeloAno.ToString()));
            cmd2.Parameters.Add(new SqlParameter("@tipo", veiculo.Tipo));

            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();

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
        public void RelacionandoId()
        {

            string query = "SELECT MAX(VEI_INT_ID) FROM TBL_VEICULO";
            string veiId = conexao.SelecioneId(query);

            query = "SELECT MAX(SEG_INT_ID) FROM TBL_SEGURO";
            string segId = conexao.SelecioneId(query);

            //insere as chaves estrangeira de N,N TBL_ENDERECO_FUNCIONARIO
            query = "INSERT INTO TBL_SEGURO_VEICULO(SEG_INT_ID,VEI_INT_ID) VALUES (" + segId + "," + veiId + ")";
            conexao.ExecutaInstrucaoNaBase(query);
        }
        public DataTable RetornaSeguros()
        {
            string query = "SELECT DISTINCT SEG_STR_NOME FROM TBL_SEGURO";
            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        public SqlDataReader SelectVeiculo(string id)
        {
            //nesse select existe convert que está convertendo a data de nasc para trazer a data sem a hora
            //o 103 é o tipo de formado Britânico/francês
            string query = "SELECT v.VEI_INT_ID, E.EMP_INT_ID, S.SEG_INT_ID,V.VEI_STR_MARCA,V.VEI_STR_MODELO,V.VEI_STR_PLACA,V.VEI_STR_RENAVAM,V.VEI_STR_CHASSI,V.VEI_STR_COR,V.VEI_STR_COMBUSTIVEL,V.VEI_STR_LUGARES, "
            + "V.VEI_DOUBLE_KM,V.VEI_DATE_FAB,V.VEI_DATE_ANO_MODELO,V.VEI_STR_TIPO,E.EMP_STR_NOME,S.SEG_STR_NOME,S.SEG_STR_TIPO,CONVERT(VARCHAR(10), S.SEG_DATE_INICIAL, 103) AS DATEINI, CONVERT(VARCHAR(10), S.SEG_DATE_FINAL, 103) AS DATEFIN, "
            +"ES.EST_STR_NOME, V.VEI_STR_STATUS FROM TBL_VEICULO AS V "
            +"INNER JOIN TBL_EMPRESA AS E ON E.EMP_INT_ID = V.EMP_INT_ID "
            +"INNER JOIN TBL_SEGURO_VEICULO AS SV ON v.VEI_INT_ID = SV.VEI_INT_ID "
            +"INNER JOIN TBL_SEGURO AS S ON S.SEG_INT_ID = SV.SEG_INT_ID "
            +"INNER JOIN TBL_ESTADO AS ES ON ES.EST_INT_CODUF = V.EST_INT_CODUF "
            +"WHERE V.VEI_INT_ID = " + id;

            SqlDataReader dt = conexao.CarregarVariosDados(query);

            return dt;
        }
        public DataTable RetornaMarca()
        {
            string query = "SELECT DISTINCT VEI_STR_MARCA from tbl_veiculo";
            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        public DataTable RetornaModelo(string marca)
        {
            string query = "SELECT DISTINCT VEI_STR_MODELO from TBL_VEICULO where VEI_STR_MARCA = '" + marca+"'";
            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        public void UpdateVeiculo()
        {

            string idSeg;

            // variavel tipo DataReader recebendo todos os ID
            SqlDataReader dr = TrazTodosId();

            //Passando os ID para as Variaveis
            idSeg = dr["SEG_INT_ID"].ToString();

            //string que recebem datas e converte para um formato aceitavel para BD
            string dateIni = seguro.DateIni.ToString("yyyy-MM-dd");
            string dateFin = seguro.DateFin.ToString("yyyy-MM-dd");

            SqlConnection con = new SqlConnection(conexao.StrConexao());

       
            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();

            /*NA CLASSE VEICULO SE O USUARIO NÃO PREENCHER O SEGURO ELE VAI
            RETORNA ESSAS DATAS PERMANECENDO O SEGURO INATIVO.*/
            if (dateIni == "1989-01-01" || dateFin == "1989-01-01")
            {
                cmd1.CommandText = "UPDATE TBL_SEGURO SET SEG_STR_STATUS = 'INATIVO' WHERE SEG_INT_ID = @idSeg";
            }
            else
            {
                cmd1.CommandText = "UPDATE TBL_SEGURO SET SEG_STR_NOME = @segNome, SEG_DATE_INICIAL = @dateIni, SEG_DATE_FINAL = @dateFDinal, SEG_STR_TIPO = @tipo WHERE SEG_INT_ID = @idSeg";
            }

            cmd2.CommandText = "UPDATE TBL_VEICULO SET EMP_INT_ID = @emp, EST_INT_CODUF = @uf, VEI_STR_MARCA = @marca, VEI_STR_MODELO = @modelo, VEI_STR_PLACA = @placa,"
            + " VEI_STR_CHASSI = @chassi, VEI_STR_RENAVAM = @renavam, VEI_STR_COR = @cor, VEI_STR_COMBUSTIVEL = @combustivel, VEI_STR_LUGARES = @lugar," 
            + " VEI_DOUBLE_KM = @km, VEI_DATE_FAB = @anoFab, VEI_DATE_ANO_MODELO = @anoMod, VEI_STR_TIPO = @tipo, VEI_STR_STATUS = @status WHERE VEI_INT_ID = " + veiculo.VeiId.ToString();


            cmd1.Parameters.Add(new SqlParameter("@idSeg", idSeg));
            cmd1.Parameters.Add(new SqlParameter("@segNome", seguro.Nome));
            cmd1.Parameters.Add(new SqlParameter("@dateIni", dateIni));
            cmd1.Parameters.Add(new SqlParameter("@dateFDinal", dateFin));
            cmd1.Parameters.Add(new SqlParameter("@tipo", seguro.Tipo));


            cmd2.Parameters.Add(new SqlParameter("@emp", empresa.EmpId));
            cmd2.Parameters.Add(new SqlParameter("@uf", endereco.EstadoId));
            cmd2.Parameters.Add(new SqlParameter("@marca", veiculo.Marca));
            cmd2.Parameters.Add(new SqlParameter("@modelo", veiculo.Modelo));
            cmd2.Parameters.Add(new SqlParameter("@placa", veiculo.Placa));
            cmd2.Parameters.Add(new SqlParameter("@chassi", veiculo.Chassi));
            cmd2.Parameters.Add(new SqlParameter("@renavam", veiculo.Renavam));
            cmd2.Parameters.Add(new SqlParameter("@cor", veiculo.Cor));
            cmd2.Parameters.Add(new SqlParameter("@combustivel", veiculo.Combustivel));
            cmd2.Parameters.Add(new SqlParameter("@lugar", veiculo.Lugares.ToString()));
            cmd2.Parameters.Add(new SqlParameter("@km", veiculo.Km.ToString()));
            cmd2.Parameters.Add(new SqlParameter("@anoFab", veiculo.AnoFab.ToString()));
            cmd2.Parameters.Add(new SqlParameter("@anoMod", veiculo.ModeloAno.ToString()));
            cmd2.Parameters.Add(new SqlParameter("@tipo", veiculo.Tipo));
            cmd2.Parameters.Add(new SqlParameter("@status", veiculo.Status));

            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;

            cmd2.ExecuteNonQuery();

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
    }
}
