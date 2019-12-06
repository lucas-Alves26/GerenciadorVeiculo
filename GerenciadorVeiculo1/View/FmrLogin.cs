using GerenciadorVeiculo1.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.View
{
    public partial class FmrLogin : Form
    {
        string id;
        public void Setlog(string id)
        {          
            this.id = id;
        }

        public FmrLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FmrLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "*****";
            }
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuário";
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            ControlLogin conLogin = new ControlLogin();
            conLogin.acessar(txtUsuario.Text, txtSenha.Text);

            if (conLogin.mensagem.Equals(""))
            {
                if (conLogin.tem)
                {
                    //Oculta o primeiro formulario
                    Hide();

                    FormPrincipal principal = new FormPrincipal();
                    principal.Show();

                }
                else
                {
                    MessageBox.Show("Login não encontrado", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(conLogin.mensagem);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
