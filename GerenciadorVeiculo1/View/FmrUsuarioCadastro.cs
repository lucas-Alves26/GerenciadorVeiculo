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

            popularEstadoUF();


        }
        //popula a combox Estado
        public void popularEstadoUF()
        {
            cbxEstado.ValueMember = "EST_INT_CODUF";
            cbxEstado.DisplayMember = "EST_STR_NOME";
            cbxEstado.DataSource = conexao.RetornaEstado();// carrega a coluna EST_STR_NOME dentro cbx
        }
        //popula a combox cidade
        public void populaCidade(string id)
        {

            cbxCidade.ValueMember = "CID_INT_ID";
            cbxCidade.DisplayMember = "CID_STR_NOME";
            cbxCidade.DataSource = conexao.RetornaCidade(id);// carrega o COLUNA CID_INT_NOME CONFORME O Id ESTADO
        }

        //salva a img na TBL_FOTO
        public void salvarImg()
        {
            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);
            byte[] foto = memory.ToArray();

            //string query = "SELECT MAX(FUN_INT_ID) FROM TBL_FUNCIONARIO";
            //int usuarioid = int.Parse(conexao.SelecioneId(query));
            string strConexao = conexao.StrConexao();

            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand command = new SqlCommand("INSERT INTO TBL_FOTO (FOTO) VALUES(@imagem)", con);
            SqlParameter image = new SqlParameter("@imagem", SqlDbType.Binary);
            //SqlParameter funId = new SqlParameter("@funcId", SqlDbType.Int);

            image.Value = foto;
            //funId.Value = usuarioid;

            command.Parameters.Add(image);
            //command.Parameters.Add(funId);

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
                if (cbxSex.Text == "")
                {
                    MessageBox.Show("Selecione o sexo! ");
                }
                else if (cbxCargo.Text == "")
                {
                    MessageBox.Show("Selecione o Cargo! ");
                }

                else
                {
                    //DateTime nasc = DateTime.Parse(txtNasc.Text);
                    char sexo = char.Parse(cbxSex.Text);
                    string estadoId = cbxEstado.SelectedValue.ToString();
                    string cidadeId = cbxCidade.SelectedValue.ToString();

                    usuario.logins = new Logins(txtLogin.Text, txtSenha.Text, txtSenha2.Text);
                    usuario.usuario = new Usuario(txtName.Text, txtNasc.Text, txtCpf.Text,txtRg.Text, cbxCargo.Text, sexo, txtEmail.Text);
                    usuario.telefone = new Telefone(txtDdd.Text, txtOpe.Text, txtCel.Text, txtTel.Text);
                    usuario.endereco = new Endereco(int.Parse(estadoId), int.Parse(cidadeId), txtRua.Text, txtNum.Text, txtCep.Text, txtComp.Text, txtBairro.Text);

                    salvarImg();
                    usuario.CadastraUsuario();
                    
                    MessageBox.Show("Cadastrado com sucesso!");

                    Limpar();
                }
            }
            catch (DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void Limpar()
        {

            txtName.Text = "";
            txtNasc.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            cbxCargo.Text = "";
            cbxSex.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtSenha2.Text = "";
            txtDdd.Text = "";
            txtOpe.Text = "";
            txtTel.Text = "";
            txtCel.Text = "";
            txtRua.Text = "";
            txtNum.Text = "";
            txtCep.Text = "";
            txtComp.Text = "";
            txtBairro.Text = "";
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }


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
            //Seleciona o Id do estado
            string CodUF = cbxEstado.SelectedValue.ToString();
            populaCidade(CodUF);


        }

        private void cbxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seleciona o id da cidade
            string CodCid = cbxCidade.SelectedValue.ToString();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Abrir e selecionar foto que está armazenado no cumputador
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string nomeImg = openFileDialog1.FileName;

                    bmp = new Bitmap(nomeImg);
                    pictureBox1.Image = bmp;
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero! ");
            }
        }

        private void txtDdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {

            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }
        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
       
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {         
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>.,:;°";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita caracteres especiais!");
            }

            //se for diferente de letras e espaço aparece a menssagem
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita letras e espaços!");
            }

        }

        private void txtRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>:;°";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita caracteres especiais!");
            }

            //se for diferente de letras e espaço aparece a menssagem
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita letras e espaços!");
            }
        }

        private void txtComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais(obs caracteres modificados)
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>;";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita caracteres especiais!");
            }

        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>:;°";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita caracteres especiais!");
            }

            //se for diferente de letras e espaço aparece a menssagem
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita letras e espaços!");
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtOpe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>:;.,°";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita caracteres especiais!");
            }

            //se for diferente de letras e espaço aparece a menssagem
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita letras e espaços!");
            }
        }

        private void txtCnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;
            //se for diferente de numeros aparece a menssagem
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero!");
            }
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais(obs caracteres modificados)
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>;:., ";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita caracteres especiais!");
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse if é para aceitar, setas e apagar
            if (e.KeyChar == 8)
                return;

            //esse if não aceitar, os seguintes caracteres especiais(obs caracteres modificados)
            string caracteresPermitidos = "!@#$¨&*()_-+ºª[]{}?/|\"'¬§<>;:., ";

            if ((caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita caracteres especiais!");
            }
        }

        private void cbxSex_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cbxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtNasc_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtTel_KeyUp(object sender, KeyEventArgs e)
        {         
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnLimparUs_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
