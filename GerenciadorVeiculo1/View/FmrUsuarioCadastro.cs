using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorVeiculo1.Dal;
using GerenciadorVeiculo1.Exceptions;


namespace GerenciadorVeiculo1.View
{
    public partial class fmrCadastro : Form
    {
        public fmrCadastro()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void FmrUsuarioCadastro_Load(object sender, EventArgs e)
        {
            cbxSexo.Items.Add("F");
            cbxSexo.Items.Add("M");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCepUs_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvarUs_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtNasc.Text == "" || txtCpf.Text == "" || txtRg.Text == "" || txtCnh.Text == "" || cbxCargo.Text == "" || cbxSexo.Text == "")
            {
                MessageBox.Show("Todos os dados pessoas com * devem ser preenchidos!");
            }
            else if (txtDdd.Text == "" || txtTel.Text == "" || txtCel.Text == "" || txtOpe.Text == "")
            {
                MessageBox.Show("Todos os dados Telefonicos com * devem ser preenchidos!");
            }
            else if (txtRua.Text == "" || txtNum.Text == "" || txtComp.Text == "" || txtBairro.Text == "" || txtEstado.Text == "" || txtCidade.Text == "" || txtCep.Text == "")
            {
                MessageBox.Show("Todos os dados de endereço com * devem ser preenchidos!");
            }
            else if (txtLogin.Text == "" || txtSenha.Text == "" || txtSenha2.Text == "")
            {
                MessageBox.Show("Todos os dados de acesso com * devem ser preenchidos!");
            }
            else
            {
                string name = txtName.Text;
                DateTime nasc = DateTime.Parse(txtNasc.Text);
                string cpf = txtCpf.Text;
                string rg = txtRg.Text;
                string cnh = txtCnh.Text;
                string email = txtEmail.Text;
                string cargo = cbxCargo.Text;
                char sexo = char.Parse(cbxSexo.Text);
                int ddd = int.Parse(txtDdd.Text);
                int tel = int.Parse(txtTel.Text);
                int cel = int.Parse(txtCel.Text);
                string ope = txtOpe.Text;
                string rua = txtRua.Text;
                int num = int.Parse(txtNum.Text);
                string comp = txtComp.Text;
                string bairro = txtBairro.Text;
                string cidade = txtCidade.Text;
                string estado = txtEstado.Text;
                int cep = int.Parse(txtCep.Text);
                string login = txtLogin.Text;
                string senha = txtSenha.Text;
                string senha2 = txtSenha2.Text;



                if (senha == senha2)
                {
                    DaoLogin log = new DaoLogin(login, senha);
                    log.cadastroLog();
                }
                else
                {
                    MessageBox.Show("Senhas diferentes!");
                }

                try
                {
                    DaoCadastroUs daoCadastroUs = new DaoCadastroUs(name, nasc, cpf, cnh, rg, cargo, sexo, email);
                    daoCadastroUs.CadastraUsuario();
                    DaoTelefon daoTelefon = new DaoTelefon(ddd, ope, cel, tel);
                    daoTelefon.CadastroTel();
                    DaoEndereco daoEndereco = new DaoEndereco(rua, num, cep, comp, cidade, estado, bairro);
                    daoEndereco.CadastroEnd();
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Erro! "+ ex.Message);
                }

                finally
                {
                    MessageBox.Show("Cadastrado com sucesso");
                }


            }
            
        }
        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtNasc.TextLength)
                {
                    case 0:
                        txtNasc.Text = "";
                        break;

                    case 2:
                        txtNasc.Text = txtNasc.Text + "/";
                        txtNasc.SelectionStart = 4;
                        break;

                    case 5:
                        txtNasc.Text = txtNasc.Text + "/";
                        txtNasc.SelectionStart = 6;
                        break;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
