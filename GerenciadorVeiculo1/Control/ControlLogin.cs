﻿using GerenciadorVeiculo1.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Control
{
    class ControlLogin
    {
        public bool tem = false;
        public string mensagem = "";
        public string id;
        public void Setlog(string id)
        {   
            this.id = id;
        }

        public string Getlog(string id)
        {
            return id;
        }


        public bool acessar(string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
    }
}
