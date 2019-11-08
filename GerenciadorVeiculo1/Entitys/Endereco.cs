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

        public Endereco(string estadoId,string cidadeId = "0")
        {
            EstadoId = int.Parse(estadoId);
            CidadeId = int.Parse(cidadeId);
        }

        public Endereco(int estadoId, int cidadeId, string rua, string numeroRua, string cep, string complemento, string bairro)
        {

            if (estadoId == 0)
            {
                throw new DomainExceptions(" O campo estado deve ser preenchido!");
            }

            else if (cidadeId == 0)
            {
                throw new DomainExceptions(" O campo cidade deve ser preenchido!");
            }

            else if (rua == "")
            {
                throw new DomainExceptions(" O campo rua deve ser preenchido!");
            }

            else if (numeroRua=="")
            {
                throw new DomainExceptions(" O campo numero da rua deve ser preenchido!");
            }

            else if (bairro == "")
            {
                throw new DomainExceptions(" O campo bairro deve ser preenchido!");
            }
            else if (cep == "")
            {
                cep = "0";
            }

            EstadoId = estadoId;
            CidadeId = cidadeId;
            Rua = rua;
            NumeroRua = int.Parse(numeroRua);
            Cep = int.Parse(cep);
            Complemento = complemento;
            Bairro = bairro;
        }
    }
}
