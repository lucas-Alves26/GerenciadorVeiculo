using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Empresa
    {
        public int EmpId { get; set; }
        public string NomeEmp { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Desc { get; set; }
        public string Status { get; set; }

        public Empresa()
        {
        }
        public Empresa(string empId)
        {
            if (empId == "")
            {
                throw new DomainExceptions("O campo ID da empresa deve ser preenchido!");
            }
            EmpId = int.Parse(empId);
        }

        public Empresa(string nomeEmp, string cnpj, string email, string desc)
        {
            if (NomeEmp == "")
            {
                throw new DomainExceptions("O campo nome da empresa deve ser preenchido!!");
            }
            else if (cnpj == "")
            {
                throw new DomainExceptions(" O campo CNPJ da empresa deve ser preenchido!");
            }

            NomeEmp = nomeEmp;
            Cnpj = cnpj;
            Email = email;
            Desc = desc;
        }
       
        public Empresa(string empId, string nomeEmp, string cnpj, string email, string desc,string status) : this(nomeEmp,cnpj,email,desc)
        {
            if (NomeEmp == "")
            {
                throw new DomainExceptions("O campo nome deve ser preenchido!");
            }
            else if (cnpj == "")
            {
                throw new DomainExceptions(" O campo CNPJ deve ser preenchido!");
            }
            else if (status == "")
            {
                throw new DomainExceptions("O campo status deve ser preenchido!");
            }
            EmpId = int.Parse(empId);
            Status = status;
        }
   
        
    }
}
