using dllDao;
using GerenciadorVeiculo1.Dal;
using GerenciadorVeiculo1.Dal.DaoMotorista;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.View.GerMotorista
{
    public partial class FmrEditarMot : Form
    {
        Conexao conexao = new Conexao();
        DaoMotorista daoMot = new DaoMotorista();

        string id;
        public void GetId(string id)
        {
            this.id = id;
        }
        public void popularEstadoUF()
        {
            cbxEstado.ValueMember = "EST_INT_CODUF";
            cbxEstado.DisplayMember = "EST_STR_NOME";
            cbxEstado.DataSource = conexao.RetornaEstado();// carrega a coluna EST_STR_NOME dentro cbx
        }
        public void populaCidade(string id)
        {

            cbxCidade.ValueMember = "CID_INT_ID";
            cbxCidade.DisplayMember = "CID_STR_NOME";
            cbxCidade.DataSource = conexao.RetornaCidade(id);// carrega o COLUNA CID_INT_NOME CONFORME O Id ESTADO
        }
        public void popularEmpresa()
        {
            cbxEmp.ValueMember = "EMP_INT_ID";
            cbxEmp.DisplayMember = "EMP_STR_NOME";
            cbxEmp.DataSource = conexao.RetornaEmpresa();// carrega a coluna EST_STR_NOME dentro cbx
        }

        public void SelectImg()
        {
            string query = "SELECT * FROM TBL_FOTO WHERE FOT_INT_ID = " + id;
            SqlConnection con = new SqlConnection(conexao.StrConexao());
            SqlCommand command = new SqlCommand(query, con);
            try
            {
                con.Open();
                byte[] imagem = (byte[])command.ExecuteScalar();
                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(imagem, 0, imagem.Length);
                fs.Flush();
                fs.Close();
                pcBox.Image = Image.FromFile(strNomeArquivo);

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

        public FmrEditarMot()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FmrEditarMot_Load(object sender, EventArgs e)
        {
            popularEstadoUF();
            popularEmpresa();

            SqlDataReader dt;

            dt = daoMot.SelectMotorista(id);

            txtName.Text = dt["MOT_STR_NOME"].ToString();
            txtNasc.Text = dt["NASC"].ToString();
            txtCpf.Text = dt["MOT_STR_CPF"].ToString();
            txtRg.Text = dt["MOT_STR_RG"].ToString();
            cbxSex.Text = dt["MOT_STR_SEXO"].ToString();
            txtEmail.Text = dt["MOT_STR_EMAIL"].ToString();
            txtCnh.Text = dt["CNH_STR_REGISTRO"].ToString();
            txtValidade.Text = dt["VALIDADE"].ToString();
            cbxCategoria.Text = dt["CNH_STR_CATEGORIA"].ToString();
            cbxEmp.Text = dt["EMPRESA"].ToString();
            txtCel.Text = dt["TEL_INT_CELULAR"].ToString();
            txtOpe.Text = dt["TEL_STR_OPERADORA"].ToString();
            txtTel.Text = dt["TEL_INT_FIXO"].ToString();
            txtDdd.Text = dt["TEL_INT_DDD"].ToString();
            txtRua.Text = dt["END_STR_RUA"].ToString();
            txtNum.Text = dt["END_INT_NUMERO"].ToString();
            txtComp.Text = dt["END_STR_COMPLEMENTO"].ToString();
            txtBairro.Text = dt["END_STR_BAIRRO"].ToString();
            txtCep.Text = dt["END_INT_CEP"].ToString();
            cbxEstado.Text = dt["EST_STR_NOME"].ToString();
            cbxCidade.Text = dt["CID_STR_NOME"].ToString();


            //SelectImg();

            txtName.Enabled = false;
            txtNasc.Enabled = false;
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            txtCnh.Enabled = false;
            cbxEmp.Enabled = false;
            cbxCategoria.Enabled = false;
            txtValidade.Enabled = false;
            cbxSex.Enabled = false;
            txtEmail.Enabled = false;
            txtDdd.Enabled = false;
            txtTel.Enabled = false;
            txtCel.Enabled = false;
            txtOpe.Enabled = false;
            txtRua.Enabled = false;
            txtNum.Enabled = false;
            txtComp.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            cbxEstado.Enabled = false;
            cbxCidade.Enabled = false;
            btnAbrir.Enabled = false;

            dt.Close();

            conexao.desconectar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtNasc.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            cbxEmp.Enabled = true;
            cbxCategoria.Enabled = true;
            txtCnh.Enabled = true;
            txtValidade.Enabled = true;
            cbxSex.Enabled = true;
            txtEmail.Enabled = true;
            txtDdd.Enabled = true;
            txtTel.Enabled = true;
            txtCel.Enabled = true;
            txtOpe.Enabled = true;
            txtRua.Enabled = true;
            txtNum.Enabled = true;
            txtComp.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            cbxEstado.Enabled = true;
            cbxCidade.Enabled = true;
            btnAbrir.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
 
                    string sexo = cbxSex.Text;
                    string estadoId = cbxEstado.SelectedValue.ToString();
                    string cidadeId = cbxCidade.SelectedValue.ToString();
                    string empresaId = cbxEmp.SelectedValue.ToString();

                    DaoMotorista daoMotorista = new DaoMotorista();
                    daoMotorista.cnh = new Cnh(txtCnh.Text, txtValidade.Text, cbxCategoria.Text);
                    daoMotorista.telefone = new Telefone(txtDdd.Text, txtOpe.Text, txtCel.Text, txtTel.Text);
                    daoMotorista.endereco = new Endereco(int.Parse(estadoId), int.Parse(cidadeId), txtRua.Text, txtNum.Text, txtCep.Text, txtComp.Text, txtBairro.Text);
                    daoMotorista.motorista = new Motorista(id,txtName.Text, txtNasc.Text, txtCpf.Text, txtRg.Text, sexo, txtEmail.Text);
      
                    daoMotorista.empresa = new Empresa(empresaId);
                    //salvarImg();
                    daoMotorista.UpdateMotorista();
                    lblAviso.Text = "Atualizado com Sucesso !";

                
            }
            catch (DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn, true);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
