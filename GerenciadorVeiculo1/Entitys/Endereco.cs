using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Endereco
    {
        public int NumeroRua { get; set; }
        public int Cep { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }    

        public Endereco()
        {
        }

        public Endereco(int numeroRua, int cep, string complemento, string cidade, string estado, string bairro)
        {
            NumeroRua = numeroRua;
            Cep = cep;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            Bairro = bairro;
        }
    }
}
