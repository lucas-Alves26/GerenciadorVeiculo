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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.View
{
    public partial class FmrDadosUs : Form
    {
        Conexao conexao = new Conexao();
        DaoUsuario daoUsuario = new DaoUsuario();

        string id;

        public void GetId(string id)
        {
            this.id = id;
        }
        public FmrDadosUs()
        {
            InitializeComponent();
        }

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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtName.Enabled = true;
            txtNasc.Enabled = true;
            txtCpf.Enabled = true;
            txtCnh.Enabled = true;
            txtRg.Enabled = true;
            cbxCargo.Enabled = true;
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
            char sexo = char.Parse(cbxSex.Text);
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
                    daoUsuario.usuario = new Usuario(txtName.Text, txtNasc.Text, txtCpf.Text, txtCnh.Text, txtRg.Text, cbxCargo.Text, sexo, txtEmail.Text);
                    daoUsuario.UpdateUsuario(id);
                }
            }
            catch (DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    

        private void DmrDadosUs_Load(object sender, EventArgs e)
        {
            popularEstadoUF();

            SqlDataReader dt;

            dt = daoUsuario.SelectUsuario(id);

            conexao.conectar();

            txtName.Text = dt["Nome"].ToString();
            txtNasc.Text = dt["Nasc"].ToString();
            txtCpf.Text = dt["CPF"].ToString();
            txtCnh.Text = dt["CNH"].ToString();
            txtRg.Text = dt["RG"].ToString();
            cbxCargo.Text = dt["CARGO"].ToString();
            cbxSex.Text = dt["SEXO"].ToString();
            txtEmail.Text = dt["EMAIL"].ToString();
            txtDdd.Text = dt["DDD"].ToString();
            txtTel.Text = dt["FIX"].ToString();
            txtCel.Text = dt["TEL"].ToString();
            txtOpe.Text = dt["OPE"].ToString();
            txtRua.Text = dt["RUA"].ToString();
            txtNum.Text = dt["NUMERO"].ToString();
            txtComp.Text = dt["COMPLEMENTO"].ToString();
            txtBairro.Text = dt["BAIRRO"].ToString();
            txtCep.Text = dt["CEP"].ToString();
            cbxEstado.Text = dt["ESTADO"].ToString();
            cbxCidade.Text = dt["CIDADE"].ToString();

            txtName.Enabled = false;
            txtNasc.Enabled = false;
            txtCpf.Enabled = false;
            txtCnh.Enabled = false;
            txtRg.Enabled = false;
            cbxCargo.Enabled = false;
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

        private void txtNasc_TextChanged(object sender, EventArgs e)
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

        private void cbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cbxCidade_KeyPress(object sender, KeyPressEventArgs e)
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
    }


}