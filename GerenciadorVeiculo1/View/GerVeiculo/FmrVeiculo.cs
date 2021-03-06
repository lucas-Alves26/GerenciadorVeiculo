﻿using GerenciadorVeiculo1.Dal.DaoVeiculo;
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

namespace GerenciadorVeiculo1.View.GerVeiculo
{
    public partial class FmrVeiculos : Form
    {
        string status = "ATIVO";
        string idSelect = "";

        DaoVeiculo dao = new DaoVeiculo();

      

        public FmrVeiculos()
        {
            InitializeComponent();
        }

        private void FmrVeiculos_Load(object sender, EventArgs e)
        {
            dgVeiculo.DataSource = dao.ConsultaVeiculo(status);
        }

        private void Disponiveis_CheckedChanged(object sender, EventArgs e)
        {
            status = "ATIVO";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            status = "TODOS";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgVeiculo.DataSource = dao.ConsultaVeiculo(status);
        }

        private void dgVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ao clicar na informação da coluna desejada vai pegar informação e
            //passar ao txtId
            var valor = dgVeiculo[e.ColumnIndex, e.RowIndex].Value.ToString();
            idSelect = valor;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {       
            try
            {
                dao.veiculo = new Veiculo(idSelect);
                DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {

                    dao.DeleteVeiculo();
                    MessageBox.Show("Deletado com sucesso!");
                }
            }
            catch (DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FmrCadastroVei fmrCadastroVei = new FmrCadastroVei();
            fmrCadastroVei.ShowDialog();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            


            if (idSelect == "")
            {
                MessageBox.Show("Selecione o ID do usuário para consultar");
            }
            else
            {
                try
                {
                    //recebe o id colocado no txtboxId
                    FmrEditarVei fmrEditarVei = new FmrEditarVei();
                    fmrEditarVei.GetId(idSelect);
                    fmrEditarVei.ShowDialog();
                }
                catch (DomainExceptions ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
