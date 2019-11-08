using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Veiculo
    {
        public int VeiId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public string Renavam { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public int Lugares { get; set; }
        public double Km { get; set; }
        public int AnoFab { get; set; }
        public int ModeloAno { get; set; }
        public string Status { get; set; }
        public string Tipo { get; set; }

        public Veiculo()
        {
        }

        public Veiculo(string veiId)
        {
            VeiId = int.Parse(veiId);
        }

        public Veiculo(string marca, string modelo,string placa, string chassi, string renavam, string cor, string combustivel, string lugares, string km, string dateFab, string modeloAno,string tipo)
        {
            if (marca == "" || marca.Length <= 3)
            {
                throw new DomainExceptions("O campo marca do veículo deve ser preenchido!");
            }
            else if (modelo == "")
            {
                throw new DomainExceptions("O campo modelo do veículo deve ser preenchido!");
            }
            else if (placa == "")
            {
                throw new DomainExceptions("O campo placa do veículo deve ser preenchido!");
            }
            else if (chassi == "")
            {
                throw new DomainExceptions("O campo chassis do veículo deve ser preenchido!");
            }

            else if (renavam =="")
            {
                throw new DomainExceptions("O campo renavam do veículo deve ser preenchido!");
            }

            else if (cor == "")
            {
                throw new DomainExceptions("O campo cor do veículo deve ser preenchido!");
            }

            else if (km == "")
            {
                throw new DomainExceptions("O campo quilometragem do veículo deve ser preenchido!");
            }

            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Chassi = chassi;
            Renavam = renavam;
            Cor = cor;
            Combustivel = combustivel;
            Lugares = int.Parse(lugares);
            Km = double.Parse(km);
            AnoFab = int.Parse(dateFab);
            ModeloAno = int.Parse(modeloAno);
            Tipo = tipo;
        }

        public Veiculo(string veiId, string marca, string modelo,string placa, string chassi, string renavam, string cor, string combustivel, string lugares, string km, string dateFab, string modeloAno, string status, string tipo) : 
            this(marca,modelo,placa,chassi,marca,cor,combustivel,lugares,km,dateFab,modeloAno,tipo)
        {
            Status = Status;
            VeiId = int.Parse(veiId);
        }
    }
}
