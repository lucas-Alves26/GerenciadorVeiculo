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
using GerenciadorVeiculo1.View.GerMotorista;
using GerenciadorVeiculo1.View.GerEmpresa;
using GerenciadorVeiculo1.View.GerVeiculo;
using GerenciadorVeiculo1.View.GerEntradaSaida;
using GerenciadorVeiculo1.View.GerManutencao;

namespace GerenciadorVeiculo1.View
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrTelaUsuario telaUsuario = new fmrTelaUsuario();
            telaUsuario.MdiParent = this;
            telaUsuario.Show();
        
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrMotorista fmrMotorista = new FmrMotorista();
            fmrMotorista.Show();
        }

        private void gerenciarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEmpresa empresa = new FmrEmpresa();
            empresa.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEmpresa empresa = new FmrEmpresa();
            empresa.Show();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrVeiculos veiculo = new FmrVeiculos();
            veiculo.Show();
        }

        private void gerenciarSaidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrConsultaSaida fmrConsultaSaida = new FmrConsultaSaida();
            fmrConsultaSaida.Show();
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrSaida fmrSaida = new FmrSaida();
            fmrSaida.Show();
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNovo fmrManutencao = new btnNovo();
            fmrManutencao.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
