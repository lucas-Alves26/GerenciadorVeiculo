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
    }
}
