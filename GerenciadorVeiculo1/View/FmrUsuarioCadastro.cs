using dllDao;
using GerenciadorVeiculo1.Dal;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GerenciadorVeiculo1.View
{
    public partial class fmrCadastro : Form
    {
        //iniciando contrutor
        DaoUsuario usuario = new DaoUsuario();
        Conexao conexao = new Conexao();
        Bitmap bmp;//trabalha com os pixos da img

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

        public void FmrUsuarioCadastro_Load(object sender, EventArgs e)
        {

            cbxSex.Items.Add("F");
            cbxSex.Items.Add("M");
            popularEstadoUF();


        }

        public void popularEstadoUF()
        {
            cbxEstado.ValueMember = "EST_INT_CODUF";
            cbxEstado.DisplayMember = "EST_STR_NOME";
            cbxEstado.DataSource = usuario.RetornaEstado();// carrega a coluna nomeCliente dentro cbx
        }

        public void salvarImg()
        {
            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);
            byte[] foto = memory.ToArray();

            if (foto!=null)
            {
                int usuarioid = int.Parse(usuario.SelecioneId());
                string strConexao = conexao.StrConexao();

                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand command = new SqlCommand("INSERT INTO TBL_FOTO (FUN_INT_ID, FOTO) VALUES(@funcId, @imagem)", con);
                SqlParameter image = new SqlParameter("@imagem", SqlDbType.Binary);
                SqlParameter funId = new SqlParameter("@funcId", SqlDbType.Int);

                

                image.Value = foto;
                funId.Value = usuarioid;

                command.Parameters.Add(image);
                command.Parameters.Add(funId);

                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }

        public void populaCidade(string id)
        {

            cbxCidade.ValueMember = "CID_INT_ID";
            cbxCidade.DisplayMember = "CID_STR_NOME";
            cbxCidade.DataSource = usuario.RetornaCidade(id);
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
            try
            {
                cbxSex.SelectedValue = '.';

                DateTime nasc = DateTime.Parse(txtNasc.Text);
                char sexo = char.Parse(cbxSex.Text);
                string estadoId = cbxEstado.SelectedValue.ToString();
                string cidadeId = cbxCidade.SelectedValue.ToString();

                usuario.logins = new Logins(txtLogin.Text, txtSenha.Text, txtSenha2.Text);
                usuario.usuario = new Usuario(txtName.Text, nasc, txtCpf.Text, txtCnh.Text, txtRg.Text, cbxCargo.Text, sexo, txtEmail.Text);
                usuario.telefone = new Telefone(int.Parse(txtDdd.Text), txtOpe.Text, int.Parse(txtCel.Text), int.Parse(txtTel.Text));
                usuario.endereco = new Endereco(int.Parse(estadoId),int.Parse(cidadeId),txtRua.Text,int.Parse(txtNum.Text),int.Parse(txtCep.Text),txtComp.Text,txtBairro.Text);
                



                usuario.cadastroLog();
                usuario.CadastraUsuario();
                salvarImg();
                MessageBox.Show("Cadastrado com sucesso !");

            }
            catch (DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
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
        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CodUF = cbxEstado.SelectedValue.ToString();
            populaCidade(CodUF);


        }

        private void cbxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CodCid = cbxCidade.SelectedValue.ToString();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string nomeImg = openFileDialog1.FileName;
                bmp = new Bitmap(nomeImg);
                pictureBox1.Image = bmp;
            }
        }
    }
}
