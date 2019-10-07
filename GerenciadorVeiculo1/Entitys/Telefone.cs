﻿using GerenciadorVeiculo1.Exceptions;
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


            if (celular == "")
            {
                throw new DomainExceptions("O campo celular deve ser preenchido ! ");
            }

            if (fixo == "")
            {
                fixo = "0";
            }
            if (ddd == "")
            {
                ddd = "0";
            }

            Ddd = int.Parse(ddd);
            Celular = int.Parse(celular);
            Fixo = int.Parse(fixo);
            Operadora = operadora;
        }



    }
}
