using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Entitys
{
    class Logins
    {
        public int LoginId { get; private set; }
        public string Log { get; private set; }
        public string Senha { get; private set; }

        public Logins()
        {
        }

        public Logins(int loginId)
        {
            LoginId = loginId;
        }

        public Logins(string log, string senha, string confirmaSenha)
        {

            if (log == "")
            {
                throw new DomainExceptions(" O Login deve ser preenchido ! ");
            }

            else if (senha == "")
            {
                throw new DomainExceptions(" A senha deve ser preenchida ! ");
            }

            else if(confirmaSenha == "")
            {
                throw new DomainExceptions(" A confirmação de senha deve ser preenchida ! ");
            }

            else if (senha != confirmaSenha)
            {
                throw new DomainExceptions(" As senhas são diferentes ! ");
            }

            Log = log;
            Senha = senha;
        }

    }
}
