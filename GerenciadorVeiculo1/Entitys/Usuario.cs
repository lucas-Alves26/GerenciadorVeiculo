using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Usuario
    {
        public int UsuarioId { get; private set; }
        public string Name { get; private set; }
        public DateTime Nasc { get; private set; }
        public string Cpf { get; private set; }
        public string Cnh { get; private set; }
        public string Rg { get; private set; }
        public string Cargo { get; private set; }
        public char Sexo { get; private set; }
        public string Email { get; private set; }
        public Endereco Endereco { get; set; }
        public Logins Logins { get; set; }



        public Usuario()
        {
            Logins = new Logins();
            Endereco = new Endereco();
        }

        public Usuario(int id)
        {
            UsuarioId = id;
        }

        public Usuario(string name, DateTime nasc, string cpf, string cnh, string rg, string cargo, char sexo, string email)
        {

            if (sexo != 'M' && sexo != 'F')
            {
                throw new DomainExceptions("O campo Sexo deve ser preenchido ! ");
            }

            else if (name == "")
            {
                throw new DomainExceptions(" O nome deve ser preenchido ! ");
            }

            else if (nasc == null)
            {
                throw new DomainExceptions(" Data de nascimento deve ser preenchida ! ");
            }

            else if (cpf == "")
            {
                throw new DomainExceptions(" O CPF deve ser preenchido ! ");
            }

            else if (rg == "" || cargo == "")
            {
                throw new DomainExceptions(" O RG deve ser Preenchido ! ");
            }

            else if (cargo == "" || cargo == "Cargo")
            {
                throw new DomainExceptions(" O cargo deve ser Preenchido ! ");
            }

            Name = name;
            Nasc = nasc;
            Cpf = cpf;
            Cnh = cnh;
            Rg = rg;
            Cargo = cargo;
            Sexo = sexo;
            Email = email;
        }
    }

}

