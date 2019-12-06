﻿using GerenciadorVeiculo1.Dal.DaoManutencao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.View.GerManutencao
{
    public partial class FmrManutConsut : Form
    {
        DaoManutencao daoManutencao = new DaoManutencao();

        string id;
        public void GetId(string id)
        {
            this.id = id;
        }

        public FmrManutConsut()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtValor.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FmrManutConsut_Load(object sender, EventArgs e)
        {
            SqlDataReader dt = daoManutencao.SelectManut(id);
            txtEmpresa.Text = dt["EMP_STR_NOME"].ToString();
            txtPlaca.Text = dt["VEI_STR_PLACA"].ToString();
            txtModelo.Text = dt["VEI_STR_MODELO"].ToString();
            txtObsManut.Text = dt["SERV_STR_OBS"].ToString();
            txtOdo.Text = dt["VEI_DOUBLE_KM"].ToString();
            cbxServico.Text = dt["SERV_STR_SERVICO"].ToString();
            cbxTipo.Text = dt["SERV_STR_TIPO_SERV"].ToString();
            txtData.Text = dt["DATA"].ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAviso.Text = "Serviço finalizado";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtHoraFin.TextLength)
                {
                    case 0:
                        txtHoraFin.Text = "";
                        break;
                    case 2:
                        txtHoraFin.Text = txtHoraFin.Text + ":";
                        txtHoraFin.SelectionStart = 4;
                        break;

                        //case 5:
                        //    txtHora.Text = txtHora.Text + ":";
                        //    txtHora.SelectionStart = 6;
                        //    break;
                }
            }

        }

        private void txtHoraIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtHoraIni.TextLength)
                {
                    case 0:
                        txtHoraIni.Text = "";
                        break;
                    case 2:
                        txtHoraIni.Text = txtHoraIni.Text + ":";
                        txtHoraIni.SelectionStart = 4;
                        break;
                }

            }
        }
    }
}