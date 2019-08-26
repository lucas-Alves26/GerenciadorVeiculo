using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
      abstract class  Pessoa
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cnh { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, char sexo, string cpf, string rg, string cnh, DateTime dataNasc, string email)
           
        {
            Nome = nome;
            Sexo = sexo;
            Cpf = cpf;
            Rg = rg;
            Cnh = cnh;
            DataNasc = dataNasc;
            Email = email;
        }
    }
}
