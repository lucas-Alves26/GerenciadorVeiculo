using System.Data;
using System.Data.SqlClient;
using dllDao;

namespace GerenciadorVeiculo1.Dal
{

    class DaoEndereco
    {
        public int EnderecoId { get; set; }
        public int NumeroRua { get; set; }
        public int Cep { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }    

        public DaoEndereco()
        {
        }

        public DaoEndereco(int enderecoId)
        {
            EnderecoId = enderecoId;
        }

        public DaoEndereco(int numeroRua, int cep, string complemento, string cidade, string estado, string bairro)
        {
            NumeroRua = numeroRua;
            Cep = cep;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            Bairro = bairro;
        }

        public void DeleteEnd()
        {
            Conexao conexao = new Conexao();

            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();
      
            cmd1.CommandText = "DELETE TBL_ENDERECO WHERE END_INT_ID =" + EnderecoId.ToString();
            cmd2.CommandText = "DELETE TBL_CIDADE  WHERE CID_INT_ID =" + EnderecoId.ToString();
            cmd3.CommandText = "DELETE TBL_ESTADO WHERE EST_INT_ID = " + EnderecoId.ToString();
            cmd4.CommandText = "DELETE TBL_ESTADO_FUNCIONARIO WHERE EST_INT_ID =" + EnderecoId.ToString();
 

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
            catch (SqlException ex)
            {
                tran.Rollback();

                string erro = ex.Message;
                erro += " Erro ao deletar !!!";
            }
            finally
            {
                con.Close();
            }
        }


    }
}
