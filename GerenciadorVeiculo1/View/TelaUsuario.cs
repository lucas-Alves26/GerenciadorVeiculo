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

namespace GerenciadorVeiculo1.View
{
    public partial class fmrTelaUsuario : Form
    {
        public fmrTelaUsuario()
        {
            InitializeComponent();

            // ao abrir o frm ja abre com as informações de usuarios cadastrados
            DaoCadastroUs daoCadastroUs = new DaoCadastroUs();
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
            DaoCadastroUs us = new DaoCadastroUs();
            dgUsuario.DataSource = us.ConsultaUsuario();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            fmrCadastroUs cadastroUs = new fmrCadastroUs();
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
           
            DaoCadastroUs daoCadastroUs = new DaoCadastroUs();
            daoCadastroUs.DeletUsuario(int.Parse(txtId.Text));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DaoCadastroUs daoCadastroUs = new DaoCadastroUs();

            dgUsuario.DataSource = daoCadastroUs.ConsultaUsuario();

        }
    }
}
