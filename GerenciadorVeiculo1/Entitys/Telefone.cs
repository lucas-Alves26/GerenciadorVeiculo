using GerenciadorVeiculo1.Exceptions;
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

        public Telefone(int ddd, string operadora, int celular, int fixo)
        {

            if (celular == 0)
            {
                throw new DomainExceptions("O coampo celular deve ser preenchida ! ");
            }

            Ddd = ddd;
            Celular = celular;
            Fixo = fixo;
            Operadora = operadora;
        }

    }
}
