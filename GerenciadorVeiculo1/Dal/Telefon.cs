using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Telefon
    {

        public string Ddd { get; set; }
        public string Operadora { get; set; }
        public int Numero { get; set; }

        public Telefon()
        {

        }

        public Telefon(string ddd, string operadora, int numero)
        {
            Ddd = ddd;
            Operadora = operadora;
            Numero = numero;
        }

   
    }
}
