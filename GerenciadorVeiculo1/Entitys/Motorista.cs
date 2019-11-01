using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Motorista : Cliente
    {
        public Motorista(string id) : base (id)
        {
        }

        public Motorista(string name, string nasc, string cpf, string rg, char sexo, string email)
            : base(name,nasc,cpf,rg,sexo,email)
        {
        }
        public Motorista(string id, string name, string nasc, string cpf, string rg, char sexo, string email)
           : base(name, nasc, cpf, rg, sexo, email)
        {
            Id = int.Parse(id);
        }
    }
}
