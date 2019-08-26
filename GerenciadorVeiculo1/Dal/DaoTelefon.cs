using System.Data;
using System.Data.SqlClient;
using dllDao;


namespace GerenciadorVeiculo1.Dal
{
    class DaoTelefon
    {
        public int TelefoneId { get; set; }
        public string Ddd { get; set; }
        public string Operadora { get; set; }
        public int Numero { get; set; }

        public DaoTelefon()
        {
           
        }

        public DaoTelefon(int telefoneId)
        {
            TelefoneId = telefoneId;
        }

        public DaoTelefon(string ddd, string operadora, int numero)
        {
            Ddd = ddd;
            Operadora = operadora;
            Numero = numero;
        }

        public void DeleteTel() {

            Conexao conexao = new Conexao();
            string query = "DELETE TBL_TELEFONE WHERE TEL_INT_ID =" + TelefoneId.ToString();
            conexao.ExecutaInstrucaoNaBase(query);

        }
    }
}
