using dllDao;
using GerenciadorVeiculo1.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GerenciadorVeiculo1.Dal
{
    class DaoLogin
    {
        public int LoginId { get; set; }
        public string Logins { get; private set; }
        public string Senha { get; private set; }

        public DaoLogin()
        {
        }

        public DaoLogin(int loginId)
        {
            LoginId = loginId;
        }

        public DaoLogin(string logins, string senha)
        {
            Logins = logins;
            Senha = senha;
        }




    }
}
