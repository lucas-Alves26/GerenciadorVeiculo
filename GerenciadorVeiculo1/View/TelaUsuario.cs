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

namespace GerenciadorVeiculo1.View
{
    public partial class fmrTelaUsuario : Form
    {
        public fmrTelaUsuario()
        {
            InitializeComponent();

            // ao abrir o frm ja abre com as informações de usuarios cadastrados
            DaoUsuario daoCadastroUs = new DaoUsuario();
            dgUsuario.DataSource = daoCadastroUs.ConsultaUsuario();

            
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
            DaoUsuario DaoUs = new DaoUsuario();
            DaoUs.usuario = new Usuario(int.Parse(txtId.Text));
            DaoUs.DeletUsuario();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DaoUsuario daoCadastroUs = new DaoUsuario();
            dgUsuario.DataSource = daoCadastroUs.ConsultaUsuario();

        }
    }
}
