using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Entrada
    {

        public int IdEntrada { get; set; }
        public int IdSaida { get; set; }
        public DateTime DataEntrada { get; set; }
        public double OdoEntrada { get; set; }
        public TimeSpan HoraEntrada { get; set; }

        public Entrada()
        {
        }

        public Entrada(string idSaida, string dataEntrada, string odoEntrada, string hora)
        {

            if (odoEntrada == "")
            {
                throw new DomainExceptions("O campo odometro deve ser preenchido!");
            }

            else if (dataEntrada == "")
            {
                throw new DomainExceptions(" O campo data de entrada deve ser preenchido!");
            }

            else if (hora == "")
            {
                throw new DomainExceptions(" O campo hora deve ser preenchido!");
            }





            IdSaida = int.Parse(idSaida);
                DataEntrada = DateTime.Parse(dataEntrada);
                OdoEntrada = double.Parse(odoEntrada);
                HoraEntrada = TimeSpan.Parse(hora);
        
        }
    }
}
