using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Manutencao
    {
        public int IdManut { get; set; }
        public int IdVei { get; set; }
        public string Servico { get; set; }
        public string TipoServ { get; set; }
        public string Obs { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraIni { get; set; }
        public TimeSpan HoraFin { get; set; }

        public Manutencao()
        {
        }

        public Manutencao(string idVei, string servico, string tipoServ, string obs, string data, string horaIni)
        {
             if (idVei == "")
            {
                throw new DomainExceptions(" O campo placa do veículo deve ser preenchido!");
            }

            else if (servico == "")
            {
                throw new DomainExceptions(" O campo serviço deve ser preenchido!");
            }

            else if (tipoServ == "")
            {
                throw new DomainExceptions(" O campo tipo de serviço deve ser preenchido!");
            }

            else if (data == "")
            {
                throw new DomainExceptions(" O campo data deve ser preenchido!");
            }


            IdVei = int.Parse(idVei);
            Servico = servico;
            TipoServ = tipoServ;
            Obs = obs;
            Data = DateTime.Parse(data);
            HoraIni = TimeSpan.Parse(horaIni);
        }


        public Manutencao(string idVei, string servico, string tipoServ, string obs, double valor, string data, string horaIni, string horaFin) 
          :this(idVei,servico,tipoServ,obs,data,horaIni)

        {
            if (idVei == "")
            {
                throw new DomainExceptions(" O campo placa do veículo deve ser preenchido!");
            }

            else if (servico == "")
            {
                throw new DomainExceptions(" O campo serviço deve ser preenchido!");
            }

            else if (tipoServ == "")
            {
                throw new DomainExceptions(" O campo tipo de serviço deve ser preenchido!");
            }

            else if (data == "")
            {
                throw new DomainExceptions(" O campo data deve ser preenchido!");
            }

            else if (horaIni == "")
            {
                throw new DomainExceptions(" O campo hora inicial deve ser preenchido!");
            }

            else if (horaFin == "")
            {
                throw new DomainExceptions(" O campo hora final ser preenchido!");
            }

            Valor = valor;  
            HoraFin = TimeSpan.Parse(horaFin);
        }
    }
}
