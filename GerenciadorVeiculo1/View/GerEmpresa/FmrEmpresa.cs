﻿using GerenciadorVeiculo1.Dal.DaoEmpresa;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.View.GerEmpresa
{
    public partial class FmrEmpresa : Form
    {
        string status = "ATIVO";
        string idSelect = "";
        string idEmp;

        DaoEmpresa DaoEmpresa = new DaoEmpresa();


        public FmrEmpresa()
        {
            InitializeComponent();
            dgEmpresa.DataSource = DaoEmpresa.ConsultaEmpresa(status);
        }
        

        private void FmrEmpresa_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             status = "ATIVO";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             status = "TODOS";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgEmpresa.DataSource = DaoEmpresa.ConsultaEmpresa(status);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                DaoEmpresa.empresa = new Empresa(idSelect);

                DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    
                    DaoEmpresa.DeleteEmpresa();
                    MessageBox.Show("Deletado com sucesso!");
                }
            }       
            catch(DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ao clicar na informação da coluna desejada vai pegar informação e
            //passar ao txtId
            var valor = dgEmpresa[e.ColumnIndex, e.RowIndex].Value.ToString();
            idSelect = valor;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (idSelect == "")
            {
                MessageBox.Show("Selecione o ID empresa!");
            }
            else
            {
                //recebe o id colocado no txtboxId
                FmrEditarEmp editarEmp = new FmrEditarEmp();
                editarEmp.GetId(idSelect);
                editarEmp.ShowDialog();
            }

        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FmrCadastroEmp fmrCadastroEmp = new FmrCadastroEmp();
            fmrCadastroEmp.ShowDialog();
        }
    }
}
