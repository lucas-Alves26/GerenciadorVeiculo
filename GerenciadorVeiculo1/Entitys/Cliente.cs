using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Cliente
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public DateTime Nasc { get; protected set; }
        public string Cpf { get; protected set; }
        public string Rg { get; protected set; }
        public string Cargo { get; protected set; }
        public char Sexo { get; protected set; }
        public string Email { get; protected set; }


        public Cliente()
        {
        }

        public Cliente(string id)
        {
            if (id == "")
            {
                throw new DomainExceptions("O campo ID deve ser preenchido!");
            }
            Id = int.Parse(id);
        }

        public Cliente(string name, string nasc, string cpf, string rg, char sexo, string email)
        {
            if (nasc == "" || nasc.Length <= 9)
            {
                throw new DomainExceptions("O campo data de nascimeto deve ser preenchido!");
            }

            else if (name == "")
            {
                throw new DomainExceptions(" O campo nome deve ser preenchido!");
            }

            else if (cpf == "")
            {
                throw new DomainExceptions(" O campo CPF deve ser preenchido!");
            }

            else if (rg == "")
            {
                throw new DomainExceptions(" O campo RG deve ser Preenchido!");
            }

            if (sexo != 'M' && sexo != 'F')
            {
                throw new DomainExceptions("O campo Sexo deve ser preenchido!");
            }

            Name = name;
            Nasc = DateTime.Parse(nasc);
            Cpf = cpf;
            Rg = rg;
            Sexo = sexo;
            Email = email;

        }

        public Cliente(string id, string name, string nasc, string cpf, string rg, string cargo, char sexo, string email) 
           : this(name,nasc,cpf,rg,sexo,email)
        {
            if (nasc == "" || nasc.Length <= 9)
            {
                throw new DomainExceptions("O campo data de nascimeto deve ser preenchido!");
            }

            else if (name == "")
            {
                throw new DomainExceptions(" O campo nome deve ser preenchido!");
            }

            else if (cpf == "")
            {
                throw new DomainExceptions(" O campo CPF deve ser preenchido!");
            }

            else if (rg == "")
            {
                throw new DomainExceptions(" O campo RG deve ser Preenchido!");
            }

            if (sexo != 'M' && sexo != 'F')
            {
                throw new DomainExceptions("O campo Sexo deve ser preenchido!");
            }

            Id = int.Parse(id);
        }
    }
}
