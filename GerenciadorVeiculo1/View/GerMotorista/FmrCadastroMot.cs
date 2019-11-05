using dllDao;
using GerenciadorVeiculo1.Dal.DaoMotorista;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.View.GerMotorista
{
    public partial class FmrCadastroMot : Form
    {


        Conexao conexao = new Conexao();
        Bitmap bmp;//trabalha com os pixos da img

        public FmrCadastroMot()
        {
            InitializeComponent();
        }
        private void FmrCadastroMot_Load(object sender, EventArgs e)
        {
            popularEstadoUF();
            popularEmpresa();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnSalvarUs_Click(object sender, EventArgs e)
        {
            try
            {
                    string sexo = cbxSex.Text;
                    string estadoId = cbxEstado.SelectedValue.ToString();
                    string cidadeId = cbxCidade.SelectedValue.ToString();
                    string empresaId = cbxEmpresa.SelectedValue.ToString();

                    DaoMotorista DaoMotorista = new DaoMotorista();
                    DaoMotorista.cnh = new Cnh(txtCnh.Text, txtValidade.Text, cbxCategoria.Text);
                    DaoMotorista.telefone = new Telefone(txtDdd.Text, txtOpe.Text, txtCel.Text, txtTel.Text);
                    DaoMotorista.endereco = new Endereco(int.Parse(estadoId), int.Parse(cidadeId), txtRua.Text, txtNum.Text, txtCep.Text, txtComp.Text, txtBairro.Text);
                    DaoMotorista.motorista = new Motorista(txtName.Text, txtNasc.Text, txtCpf.Text, txtRg.Text, sexo, txtEmail.Text);
                    DaoMotorista.empresa = new Empresa(empresaId);
                    salvarImg();
                    DaoMotorista.CadastraMotorista();
                    lblAviso.Text= "Cadastrado com Sucesso !";
                    Limpar();
                
            }
            catch (DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 

            }


            //lblAviso.Text = "";
        }
        //limpa os todos os campos
        private void Limpar()
        {
            txtName.Text = "";
            txtNasc.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            cbxSex.Text = null;
            cbxCategoria.Text = null;
            txtEmail.Text = "";
            txtCnh.Text = "";
            txtValidade.Text = "";
            txtDdd.Text = "";
            txtOpe.Text = "";
            txtTel.Text = "";
            txtCel.Text = "";
            txtRua.Text = "";
            txtNum.Text = "";
            txtCep.Text = "";
            txtComp.Text = "";
            txtBairro.Text = "";
            pictureBox1.Image = null;
            
        }
        //popula o combox ESTADO
        public void popularEstadoUF()
        {
            cbxEstado.ValueMember = "EST_INT_CODUF";
            cbxEstado.DisplayMember = "EST_STR_NOME";
            cbxEstado.DataSource = conexao.RetornaEstado();// carrega a coluna EST_STR_NOME dentro cbx
        }
        //popula o combox cidade
        public void populaCidade(string id)
        {
            cbxCidade.ValueMember = "CID_INT_ID";
            cbxCidade.DisplayMember = "CID_STR_NOME";
            cbxCidade.DataSource = conexao.RetornaCidade(id);// carrega o COLUNA CID_INT_NOME CONFORME O Id ESTADO
        }
        //salva Img no banco de dados
        public void salvarImg()
        {
            MemoryStream memory = new MemoryStream();//obj referente a guarda dados na memoria
            bmp.Save(memory, ImageFormat.Bmp);
            byte[] foto = memory.ToArray();

            string strConexao = conexao.StrConexao();

            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand command = new SqlCommand("INSERT INTO TBL_FOTO (FOTO) VALUES(@imagem)", con);
            SqlParameter image = new SqlParameter("@imagem", SqlDbType.Binary);

            image.Value = foto;

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
        //Retorna Empresa
        public void popularEmpresa()
        {
            cbxEmpresa.ValueMember = "EMP_INT_ID";
            cbxEmpresa.DisplayMember = "EMP_STR_NOME";
            cbxEmpresa.DataSource = conexao.RetornaEmpresa();// carrega a coluna EST_STR_NOME dentro cbx
        }
        private void btnAbrir_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Abrir e selecionar foto que está armazenado no cumputador
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nomeImg = openFileDialog1.FileName;

                bmp = new Bitmap(nomeImg);
                pictureBox1.Image = bmp;
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

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // esse if é para aceitar, setas e apagar
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

        private void txtValidade_KeyPress(object sender, KeyPressEventArgs e)
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
                switch (txtValidade.TextLength)
                {
                    case 0:
                        txtValidade.Text = "";
                        break;
                    case 2:
                        txtValidade.Text = txtValidade.Text + "/";
                        txtValidade.SelectionStart = 4;
                        break;

                    case 5:
                        txtValidade.Text = txtValidade.Text + "/";
                        txtValidade.SelectionStart = 6;
                        break;
                }
            }
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

        private void txtValidade_TextChanged(object sender, EventArgs e)
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

        private void txtName_Click(object sender, EventArgs e)
        {
            lblAviso.Text = "";
        }

        private void txtTele_Enter(object sender, EventArgs e)
        {

        }

        private void cbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparUs_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}