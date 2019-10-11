using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GerenciadorVeiculo1.Dal;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;

namespace GerenciadorVeiculo1.View
{
    public partial class fmrTelaUsuario : Form
    {
        DaoUsuario DaoUs = new DaoUsuario();

        string usuarioID;

        public string GetUsuarioID()
        {
            return usuarioID;
        }


        public fmrTelaUsuario()
        {
            InitializeComponent();

            // ao abrir o frm ja abre com as informações de usuarios cadastrados
            
            dgUsuario.DataSource = DaoUs.ConsultaUsuario();

            
        }

        private void fmrTelaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ao clicar na informação da coluna desejada vai pegar informação e
            //passar ao txtId
            var valor = dgUsuario[e.ColumnIndex, e.RowIndex].Value.ToString();
            txtId.Text = valor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DaoUsuario us = new DaoUsuario();
            dgUsuario.DataSource = us.ConsultaUsuario();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            fmrCadastro cadastroUs = new fmrCadastro();
            cadastroUs.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DaoUs.usuario = new Usuario(txtId.Text);
                DaoUs.DeletUsuario();
                MessageBox.Show("Deletado com sucesso!");
            }
            catch (DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgUsuario.DataSource = DaoUs.ConsultaUsuario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
               MessageBox.Show("Coloque o ID do usuário para consultar");
           
            }
            else
            {
                    usuarioID = txtId.Text;
                    FmrDadosUs dadosUs = new FmrDadosUs();
                    dadosUs.GetId(usuarioID);
                    dadosUs.Show();
            }    
        }
    }
}
