using GerenciadorVeiculo1.Exceptions;
using GerenciadorVeiculo1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GerenciadorVeiculo1.Entitys
{
    class Telefone
    {

        public int TelefoneId { get; set; }
        public int Ddd { get; set; }
        public string Operadora { get; set; }
        public int Celular { get; set; }
        public int Fixo { get; set; }

        public Telefone()
        {
        }

        public Telefone(int telefoneId)
        {
            TelefoneId = telefoneId;
        }

        public Telefone(string ddd, string operadora, string celular, string fixo)
        {

            if (celular == "" && fixo == "")
            {
                throw new DomainExceptions("Pelo menos um numero de telefone deve ser preenchido ! ");
            }
            else if (celular.Length < 9)
            {
                throw new DomainExceptions("O numero do celular está muito curto ! ");
            }

            else if (fixo != "" && fixo.Length < 8)
            {
                throw new DomainExceptions("O numero do telefone está muito curto ! ");
            }
            else if (fixo == "")
            {
                fixo = "0";
            }
            else if (celular == "")
            {
                fixo = null;
            }
            else if (ddd == "")
            {
                ddd = null;
            }

            Ddd = int.Parse(ddd);
            Celular = int.Parse(celular);
            Fixo = int.Parse(fixo);
            Operadora = operadora;
        }



    }
}
