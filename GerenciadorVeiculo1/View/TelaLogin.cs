using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorVeiculo1.Control;



namespace GerenciadorVeiculo1.View
{
    public partial class tlaLogin : Form
    {
        public tlaLogin()
        {
            InitializeComponent();
        }

        private void tlaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ControlLogin conLogin = new ControlLogin();
            conLogin.acessar(txtLogin.Text, txtSenha.Text);

            if (conLogin.mensagem.Equals(""))
            {
                if (conLogin.tem)
                {
                    //Oculta o primeiro formulario
                    Hide();

                    fmrPrincipal principal = new fmrPrincipal();
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
    }
}
