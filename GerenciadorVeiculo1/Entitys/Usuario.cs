using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Usuario : Cliente
    {
        public int UsuarioId { get; private set; }
        //public string Name { get; private set; }
        //public DateTime Nasc { get; private set; }
        //public string Cpf { get; private set; }
        //public string Rg { get; private set; }
        //public string Cargo { get; private set; }
        //public char Sexo { get; private set; }
        //public string Email { get; private set; }
        public Endereco Endereco { get; set; }
        public Logins Logins { get; set; }

        public Usuario()
        {
        }

        public Usuario(string id)
        {
            if(id =="")
            {
                throw new DomainExceptions("Digite o ID o usuário!");
            }

            UsuarioId = int.Parse(id);
        }

        public Usuario(string name, string nasc, string cpf, string rg, string cargo, char sexo, string email)
            : base(name,nasc,cpf,rg,sexo,email)
        {
            //if (nasc == "" || nasc.Length <= 9)
            //{
            //    throw new DomainExceptions("O campo data de nascimeto deve ser preenchido corretamente!");
            //}

            //else if (name == "")
            //{
            //    throw new DomainExceptions(" O campo nome deve ser preenchido!");
            //}

            //else if (cpf == "")
            //{
            //    throw new DomainExceptions(" O campo CPF deve ser preenchido!");
            //}

            //else if (rg == "")
            //{
            //    throw new DomainExceptions(" O campo RG deve ser preenchido!");
            //}

                  //else if (sexo != 'M' && sexo != 'F')
            //{
            //    throw new DomainExceptions("O campo Sexo deve ser preenchido!");
            //}

            if (cargo == "" || cargo == "Cargo")
            {
                throw new DomainExceptions(" O campo cargo deve ser preenchido!");
            }
            
            Cargo = cargo;

        }

        public Usuario(string usuarioId, string name, string nasc, string cpf, string rg, string cargo, char sexo, string email) : this(name,nasc,cpf,rg,cargo,sexo,email)
        {
            if (nasc == "" || nasc.Length <= 9)
            {
                throw new DomainExceptions("Digite a Data de nascimeto!");
            }

            else if (name == "")
            {
                throw new DomainExceptions(" O nome deve ser preenchido ! ");
            }

            else if (cpf == "")
            {
                throw new DomainExceptions(" O CPF deve ser preenchido ! ");
            }

            else if (rg == "")
            {
                throw new DomainExceptions(" O RG deve ser Preenchido ! ");
            }

            else if (cargo == "" || cargo == "Cargo")
            {
                throw new DomainExceptions(" O cargo deve ser Preenchido ! ");
            }

            if (sexo != 'M' && sexo != 'F')
            {
                throw new DomainExceptions("O campo Sexo deve ser preenchido ! ");
            }

            UsuarioId = int.Parse(usuarioId);
          
        }
    }

}

