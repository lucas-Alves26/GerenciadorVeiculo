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


namespace GerenciadorVeiculo1.View
{
    public partial class fmrCadastroUs : Form
    {
        public fmrCadastroUs()
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
            DaoLogin login = new DaoLogin(txtLoginUs.Text,txtSenhaUs.Text);
            login.cadastroLog();
            DateTime date = DateTime.Parse(txtNasc.Text);
            char sexo = char.Parse(cbxSexo.Text);

            DaoCadastroUs daoCadastroUs = new DaoCadastroUs(txtName.Text, date, txtCpf.Text, txtCnh.Text, txtRg.Text, cbxCargo.Text, sexo, txtEmail.Text);
            daoCadastroUs.CadastraUsuario();

            
          DaoTelefon daoTelefon = new DaoTelefon(int.Parse(txtDdd.Text),txtOperadora.Text,int.Parse(txtCelular.Text),int.Parse(txtFixo.Text));
          daoTelefon.CadastroTel();

            /*DaoEndereco daoEndereco = new DaoEndereco(int.Parse(txtNumeroUs.Text), int.Parse(txtCepUs.Text), txtComplementoUs.Text, txtCidUs.Text, txtEstadoUs.Text, txtBairroUs.Text, txtRuaUs.Text);
            daoEndereco.CadastroEnd();*/
        
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
