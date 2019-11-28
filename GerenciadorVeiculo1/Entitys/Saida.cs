using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Saida
    {
        public int IdFun { get; set; }
        public int IdMot { get; set; }
        public int IdVei { get; set; }
        public string Desc { get; set; }
        public string Cnh { get; set; }
        public string Marca { get; set; }
        public DateTime Data { get; set; }

        public Saida()
        {
        }

        public Saida(string idMot, string idVei, string desc, string data, string cnh, string marca, string idFun = "1")
        {
             if (cnh == "")
            {
                throw new DomainExceptions(" Selecione o motorista!");
            }

            else if (marca == "")
            {
                throw new DomainExceptions(" Selecione a placa do veiculo!");
            }

            if (data == "" || data.Length <= 9)
            {
                throw new DomainExceptions("O campo data deve ser preenchido corretamente!");
            }

            IdFun = int.Parse(idFun);
            IdMot = int.Parse(idMot);
            IdVei = int.Parse(idVei);
            Data = DateTime.Parse(data);
            Desc = desc;       
        }
    }
}
