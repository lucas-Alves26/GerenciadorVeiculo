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
        public int EmpId { get; set; }

        public Motorista(string id) : base (id)
        {
        }

        public Motorista(string name, string nasc, string cpf, string rg, char sexo, string email/*, *//*string empId*/)
            : base(name,nasc,cpf,rg,sexo,email)
        {
            //if (empId == "")
            //{
            //    throw new DomainExceptions("O nome da empresa deve ser preenchido!");
            //}

            //EmpId = int.Parse(empId);
        }
        public Motorista(string id, string name, string nasc, string cpf, string rg, char sexo, string email)
    : base(name, nasc, cpf, rg, sexo, email)
        {
            Id = int.Parse(id);
        }

    }
}
