using dllDao;
using GerenciadorVeiculo1.Entitys;
using System;
using GerenciadorVeiculo1.Dal.DaoEmpresa;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GerenciadorVeiculo1.Exceptions;

namespace GerenciadorVeiculo1.View.GerEmpresa
{
    public partial class FmrEditarEmp : Form
    {
        Conexao conexao = new Conexao();
        DaoEmpresa daoEmpresa = new DaoEmpresa();


        string id;
        public void GetId(string id)
        {
            this.id = id;
        }

        public FmrEditarEmp()
        {
            InitializeComponent();
        }

        private void FmrEditarEmp_Load(object sender, EventArgs e)
        {
            popularEstadoUF();

            SqlDataReader dt = daoEmpresa.SelectEmpresa(id);

            txtName.Text = dt["EMP_STR_NOME"].ToString();
            txtCnpj.Text = dt["EMP_STR_CNPJ"].ToString();
            txtEmail.Text = dt["EMP_STR_EMAIL"].ToString();
            txtDesc.Text = dt["EMP_STR_DESC"].ToString();
            cbxStatus.Text = dt["EMP_STR_STATUS"].ToString();
            txtCelular.Text = dt["TEL_INT_CELULAR"].ToString();
            txtOpe.Text = dt["TEL_STR_OPERADORA"].ToString();
            txtFixo.Text = dt["TEL_INT_FIXO"].ToString();
            txtDdd.Text = dt["TEL_INT_DDD"].ToString();
            txtRua.Text = dt["END_STR_RUA"].ToString();
            txtNum.Text = dt["END_INT_NUMERO"].ToString();
            txtComp.Text = dt["END_STR_COMPLEMENTO"].ToString();
            txtBairro.Text = dt["END_STR_BAIRRO"].ToString();
            txtCep.Text = dt["END_INT_CEP"].ToString();
            cbxEstado.Text = dt["EST_STR_NOME"].ToString();
            cbxCidade.Text = dt["CID_STR_NOME"].ToString();

            txtName.Enabled = false;
            txtCnpj.Enabled = false;
            txtEmail.Enabled = false;
            txtDesc.Enabled = false;
            cbxStatus.Enabled = false;
            txtCelular.Enabled = false;
            txtOpe.Enabled = false;
            txtFixo.Enabled = false;
            txtDdd.Enabled = false;
            txtRua.Enabled = false;
            txtNum.Enabled = false;
            txtComp.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            cbxEstado.Enabled = false;
            cbxCidade.Enabled = false;

            dt.Close();
            conexao.desconectar();
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

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFixo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRua_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtCnpj.Enabled = true;
            txtEmail.Enabled = true;
            txtDesc.Enabled = true;
            cbxStatus.Enabled = true;
            txtCelular.Enabled = true;
            txtOpe.Enabled = true;
            txtFixo.Enabled = true;
            txtDdd.Enabled = true;
            txtRua.Enabled = true;
            txtNum.Enabled = true;
            txtComp.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            cbxEstado.Enabled = true;
            cbxCidade.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string estadoId = cbxEstado.SelectedValue.ToString();
                string cidadeId = cbxCidade.SelectedValue.ToString();

                daoEmpresa.empresa = new Empresa(id, txtName.Text, txtCnpj.Text, txtEmail.Text, txtDesc.Text, cbxStatus.Text);
                daoEmpresa.telefone = new Telefone(txtDdd.Text, txtOpe.Text, txtCelular.Text, txtFixo.Text);
                daoEmpresa.endereco = new Endereco(int.Parse(estadoId), int.Parse(cidadeId), txtRua.Text, txtNum.Text, txtCep.Text, txtComp.Text, txtBairro.Text);
                daoEmpresa.UpdateEmpresa();
                lblAviso.Text = "Atualizado com sucesso!";
            }
            catch(DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
