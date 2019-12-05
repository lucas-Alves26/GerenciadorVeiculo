using dllDao;
using GerenciadorVeiculo1.Dal.DaoVeiculo;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.View.GerVeiculo
{
    public partial class FmrCadastroVei : Form
    {
        DaoVeiculo dao = new DaoVeiculo();
        Conexao conexao = new Conexao();

        public FmrCadastroVei()
        {
            InitializeComponent();
        }
        public void popularEmpresa()
        {
            cbxEmpresa.ValueMember = "EMP_INT_ID";
            cbxEmpresa.DisplayMember = "EMP_STR_NOME";
            cbxEmpresa.DataSource = conexao.RetornaEmpresa();// carrega a coluna EST_STR_NOME dentro cbx
        }
        public void popularEstadoUF()
        {
            cbxEstado.ValueMember = "EST_INT_CODUF";
            cbxEstado.DisplayMember = "EST_STR_NOME";
            cbxEstado.DataSource = conexao.RetornaEstado();// carrega a coluna EST_STR_NOME dentro cbx
        }
        public void popularSeguro()
        {
            cbxSegura.ValueMember = "SEG_STR_NOME";
            cbxSegura.DisplayMember = "SEG_STR_NOME";
            cbxSegura.DataSource = dao.RetornaSeguros();// carrega a coluna EST_STR_NOME dentro cbx
        }
        public void popularMarca()
        {
            cbxMarca.ValueMember = "VEI_STR_MARCA";
            cbxMarca.DisplayMember = "VEI_STR_MARCA";
            cbxMarca.DataSource = dao.RetornaMarca();// carrega a coluna EST_STR_NOME dentro cbx
        }

        public void popularModelo(string marca)
        {
            cbxmodelo.ValueMember = "VEI_STR_MODELO";
            cbxmodelo.DisplayMember = "VEI_STR_MODELO";
            cbxmodelo.DataSource = dao.RetornaModelo(marca);// carrega o COLUNA CID_INT_NOME CONFORME O Id ESTADO
        }
        private void FmrCadastroVei_Load(object sender, EventArgs e)
        {
            popularMarca();
            popularEmpresa();
            popularEstadoUF();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvarMot_Click(object sender, EventArgs e)
        {
            try
            {
                string empresaId = cbxEmpresa.SelectedValue.ToString();
                string ufId = cbxEstado.SelectedValue.ToString();

                dao.veiculo = new Veiculo(cbxMarca.Text, cbxmodelo.Text, txtPlaca.Text, txtChassis.Text, txtrenavam.Text, txtCor.Text, txtCombus.Text, txtLugar.Text, txtKm.Text, txtAnoFab.Text, txtAnoModelo.Text, cbxTipoVei.Text);
                dao.endereco = new Endereco(ufId);
                dao.seguro = new Seguro(cbxSegura.Text,txtVigIni.Text,txtVigFin.Text,cbxTipo.Text);
                dao.empresa = new Empresa(empresaId);
                dao.CadastraVeiculo();
                lblAviso.Text = "Cadastrado com Sucesso !";

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
            
        }
        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleciona o Id do estado
            string CodUF = cbxEstado.SelectedValue.ToString();
        }

        private void txtVigIni_KeyPress(object sender, KeyPressEventArgs e)
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
                switch (txtVigIni.TextLength)
                {
                    case 0:
                        txtVigIni.Text = "";
                        break;
                    case 2:
                        txtVigIni.Text = txtVigIni.Text + "/";
                        txtVigIni.SelectionStart = 4;
                        break;

                    case 5:
                        txtVigIni.Text = txtVigIni.Text + "/";
                        txtVigIni.SelectionStart = 6;
                        break;
                }
            }
        }

        private void txtVigFin_KeyPress(object sender, KeyPressEventArgs e)
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
                switch (txtVigFin.TextLength)
                {
                    case 0:
                        txtVigFin.Text = "";
                        break;
                    case 2:
                        txtVigFin.Text = txtVigFin.Text + "/";
                        txtVigFin.SelectionStart = 4;
                        break;

                    case 5:
                        txtVigFin.Text = txtVigFin.Text + "/";
                        txtVigFin.SelectionStart = 6;
                        break;
                }
            }
        }
        private void cbxSegura_Click(object sender, EventArgs e)
        {
            popularSeguro();
        }

        private void cbxMarca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxmodelo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCombus_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLugar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAnoFab_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAnoModelo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtChassis_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrenavam_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxSegura_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxTipo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxMarca_Click(object sender, EventArgs e)
        {
            lblAviso.Text = "";
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marca = cbxMarca.SelectedValue.ToString();
            popularModelo(marca);
        }

        private void btnLimparUs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Limpar()
        {
            cbxMarca.Text = "";
            cbxmodelo.Text = "";
            txtPlaca.Text = "";
            txtChassis.Text = "";
            txtrenavam.Text = "";
            txtCor.Text = "";
            txtCombus.Text = "";
            txtLugar.Text = "";
            txtKm.Text = "";
            txtAnoFab.Text = "";
            txtAnoModelo.Text = "";
            cbxTipoVei.Text = "";
            cbxEmpresa.Text = "";
            cbxEstado.Text = "";
            cbxSegura.Text = "";
            cbxTipo.Text = "";
            txtVigIni.Text = "";
            txtVigFin.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtLugar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
