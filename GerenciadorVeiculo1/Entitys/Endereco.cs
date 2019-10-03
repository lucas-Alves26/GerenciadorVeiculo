using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Endereco
    {
        public int EnderecoId { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
        public string Rua { get; set; }
        public int NumeroRua { get; set; }
        public int Cep { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }

        public Endereco()
        {
        }

        public Endereco(int estadoId,int cidadeId)
        {
            EstadoId = estadoId;
            CidadeId = cidadeId;
        }

        public Endereco(int estadoId, int cidadeId, string rua, int numeroRua, int cep, string complemento, string bairro)
        {

            if (estadoId == 0)
            {
                throw new DomainExceptions(" O estado deve ser preenchido ! ");
            }

            else if (cidadeId == 0)
            {
                throw new DomainExceptions(" A cidade deve ser preenchida ! ");
            }

            else if (rua == "")
            {
                throw new DomainExceptions(" A rua deve ser preenchida ! ");
            }

            else if (numeroRua==0)
            {
                throw new DomainExceptions(" O numero da rua deve ser preenchido ! ");
            }

            else if (cep == 0)
            {
                throw new DomainExceptions(" O CEP deve ser preenchido ! ");
            }
            else if (bairro == "")
            {
                throw new DomainExceptions(" O bairro deve ser preenchido ! ");
            }

            EstadoId = estadoId;
            CidadeId = cidadeId;
            Rua = rua;
            NumeroRua = numeroRua;
            Cep = cep;
            Complemento = complemento;
            Bairro = bairro;
        }
    }
}
