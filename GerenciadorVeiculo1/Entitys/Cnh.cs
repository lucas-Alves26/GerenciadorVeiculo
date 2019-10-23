using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Cnh
    {
        public int CnhId { get; set; }
        public long Registro { get; set; }
        public DateTime CnhValidade { get; set; }
        public  string Categoria { get; set; }

        public Cnh()
        {
        }

        public Cnh(string registro, string cnhValidade, string categoria)
        {

            if (cnhValidade == "" || cnhValidade.Length <= 9)
            {
                throw new DomainExceptions("Digite a Data de validade!");
            }
            else if (registro == "")
            {
                throw new DomainExceptions(" O numero de registro deve ser preenchido!");
            }
            else if (categoria == ""|| categoria =="categoria")
            {            
                throw new DomainExceptions(" A categoria deve ser preenchida!");
            }

            Registro = long.Parse(registro);
            CnhValidade = DateTime.Parse(cnhValidade);
            Categoria = categoria;
        }
    }
}
