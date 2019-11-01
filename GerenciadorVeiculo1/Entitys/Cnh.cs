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
                throw new DomainExceptions("O campo data de validade deve ser preenchido!");
            }
            else if (registro == "")
            {
                throw new DomainExceptions(" O campo numero de registro deve ser preenchido!");
            }
            else if (categoria == ""|| categoria =="categoria")
            {            
                throw new DomainExceptions(" O campo categoria deve ser preenchido!");
            }

            Registro = long.Parse(registro);
            CnhValidade = DateTime.Parse(cnhValidade);
            Categoria = categoria;
        }
    }
}
