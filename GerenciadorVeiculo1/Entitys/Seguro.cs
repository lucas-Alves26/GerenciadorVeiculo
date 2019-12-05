using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Seguro
    {
        public int SegId { get; set; }
        public string Nome { get; set; }
        public DateTime  DateIni { get; set; }
        public DateTime  DateFin { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }

        public Seguro(int segId)
        {
            SegId = segId;
        }

        public Seguro(string nome, string dateIni, string dateFin, string tipo)
        {
            if (dateIni == "")
            {
                dateIni = "01/01/1989";
            }

            if (dateFin == "")
            {
                dateFin = "01/01/1989";
            }

            if(dateIni != "" && dateFin == "01/01/1989")
            {
                throw new DomainExceptions("O campo vigência final do seguro deve ser preenchido!");
            }
         
            if (dateIni == "01/01/1989" && dateFin != "")
                {
                    throw new DomainExceptions("O campo vigência inicial do seguro deve ser preenchido!");
                }

            Nome = nome;
            DateIni = DateTime.Parse(dateIni);
            DateFin = DateTime.Parse(dateFin);
            Tipo = tipo;
        
        }                
    }
}
