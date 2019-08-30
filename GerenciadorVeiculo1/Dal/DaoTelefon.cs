using System;
using System.Data;
using System.Data.SqlClient;
using dllDao;



namespace GerenciadorVeiculo1.Dal
{
    class DaoTelefon
    {
        public int TelefoneId { get; set; }
        public int Ddd { get; set; }
        public string Operadora { get; set; }
        public int Celular { get; set; }
        public int Fixo { get; set; }

        public DaoTelefon()
        {           
        }

        public DaoTelefon(int telefoneId)
        {
            TelefoneId = telefoneId;
        }

        public DaoTelefon(int ddd, string operadora, int celular, int fixo)
        {
            Ddd = ddd;
            Celular = celular;
            Fixo = fixo;
            Operadora = operadora;
        }

        public void DeleteTel()
        {
            Conexao conexao = new Conexao();
            string query = "DELETE TBL_TELEFONE WHERE TEL_INT_ID =" + TelefoneId.ToString();
            conexao.ExecutaInstrucaoNaBase(query);
        }

        public void CadastroTel()
        {
            DaoLogin daoLogin = new DaoLogin();
            string id = daoLogin.SelecioneId();

            Conexao conexao = new Conexao();
            SqlConnection con = new SqlConnection(conexao.StrConexao());
        
       
                string query = "INSERT INTO TBL_TELEFONE(TEL_INT_DDD,TEL_INT_CELULAR,TEL_INT_FIXO,TEL_STR_OPERADORA,FUN_INT_ID)" +
                                  " VALUES(@ddd, @celular, @fixo, @operadora, @id)";

                SqlCommand sqlCommand = new SqlCommand(query,con);
                sqlCommand.Parameters.Add(new SqlParameter("@ddd", Ddd));
                sqlCommand.Parameters.Add(new SqlParameter("@celular", Celular));
                sqlCommand.Parameters.Add(new SqlParameter("@fixo", Fixo));
                sqlCommand.Parameters.Add(new SqlParameter("@operadora",Operadora));
                sqlCommand.Parameters.Add(new SqlParameter("@id",id));

                con.Open();
                sqlCommand.ExecuteNonQuery();

                con.Close();
            
        }
    }
}
