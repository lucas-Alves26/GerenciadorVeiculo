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
            DaoCadastroUs us = new DaoCadastroUs();
            dgUsuario.DataSource = us.ConsultaUsuario();
        }

        private void fmrTelaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
    }
}
