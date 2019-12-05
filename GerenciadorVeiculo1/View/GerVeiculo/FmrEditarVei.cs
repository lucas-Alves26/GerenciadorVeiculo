using dllDao;
using GerenciadorVeiculo1.Dal.DaoVeiculo;
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

namespace GerenciadorVeiculo1.View.GerVeiculo
{
    public partial class FmrEditarVei : Form
    {
        Conexao conexao = new Conexao();
        DaoVeiculo daoVeiculo = new DaoVeiculo();

        string id;
        public void GetId(string id)
        {
            this.id = id;
        }

        public FmrEditarVei()
        {
            InitializeComponent();
        }
        private void btnSalvarMot_Click(object sender, EventArgs e)
        {
            try
            {
                string empresaId = cbxEmpresa.SelectedValue.ToString();
                string ufId = cbxEstado.SelectedValue.ToString();

                daoVeiculo.veiculo = new Veiculo(id, cbxMarca.Text, cbxmodelo.Text, txtPlaca.Text, txtChassis.Text, txtrenavam.Text, txtCor.Text, txtCombus.Text, txtLugar.Text, txtKm.Text, txtAnoFab.Text, txtAnoModelo.Text,cbxStatusVei.Text,cbxTipoVei.Text);
                daoVeiculo.endereco = new Endereco(ufId);
                daoVeiculo.seguro = new Seguro(cbxSegura.Text, txtVigIni.Text, txtVigFin.Text, cbxTipo.Text);
                daoVeiculo.empresa = new Empresa(empresaId);
                daoVeiculo.UpdateVeiculo();
                lblAviso.Text = "Atualizado com Sucesso!";

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

        private void FmrEditarVei_Load(object sender, EventArgs e)
        {
            SqlDataReader dt = daoVeiculo.SelectVeiculo(id);

            popularEstadoUF();
            popularEmpresa();
            popularSeguro();
            popularMarca();

            cbxMarca.Text = dt["VEI_STR_MARCA"].ToString();
            cbxmodelo.Text = dt["VEI_STR_MODELO"].ToString();
            txtPlaca.Text = dt["VEI_STR_PLACA"].ToString();
            txtChassis.Text = dt["VEI_STR_CHASSI"].ToString();
            txtrenavam.Text = dt["VEI_STR_RENAVAM"].ToString();
            txtCor.Text = dt["VEI_STR_COR"].ToString();
            txtCombus.Text = dt["VEI_STR_COMBUSTIVEL"].ToString();
            txtLugar.Text = dt["VEI_STR_LUGARES"].ToString();
            txtKm.Text = dt["VEI_DOUBLE_KM"].ToString();
            txtAnoFab.Text =  dt["VEI_DATE_FAB"].ToString();
            txtAnoModelo.Text = dt["VEI_DATE_ANO_MODELO"].ToString();
            cbxTipoVei.Text =  dt["VEI_STR_TIPO"].ToString();
            cbxEmpresa.Text = dt["EMP_STR_NOME"].ToString();
            cbxEstado.Text = dt["EST_STR_NOME"].ToString();
            cbxSegura.Text = dt["SEG_STR_NOME"].ToString();
            cbxTipo.Text = dt["SEG_STR_TIPO"].ToString();
            txtVigIni.Text = dt["DATEINI"].ToString();
            txtVigFin.Text = dt["DATEFIN"].ToString();
            cbxStatusVei.Text = dt["VEI_STR_STATUS"].ToString();
            

            cbxMarca.Enabled = false;
            cbxmodelo.Enabled = false;
            txtPlaca.Enabled = false;
            txtChassis.Enabled = false;
            txtrenavam.Enabled = false;
            txtCor.Enabled = false;
            txtCombus.Enabled = false;
            txtLugar.Enabled = false;
            txtKm.Enabled = false;
            txtAnoFab.Enabled = false;
            txtAnoModelo.Enabled = false; 
            cbxTipoVei.Enabled = false;
            cbxEmpresa.Enabled = false;
            cbxEstado.Enabled = false;
            cbxSegura.Enabled = false;
            cbxTipo.Enabled = false;
            txtVigIni.Enabled = false;
            txtVigFin.Enabled = false;
            cbxStatusVei.Enabled = false;

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
        public void popularEmpresa()
        {
            cbxEmpresa.ValueMember = "EMP_INT_ID";
            cbxEmpresa.DisplayMember = "EMP_STR_NOME";
            cbxEmpresa.DataSource = conexao.RetornaEmpresa();// carrega a coluna EST_STR_NOME dentro cbx
        }
        public void popularSeguro()
        {
            cbxSegura.ValueMember = "SEG_STR_NOME";
            cbxSegura.DisplayMember = "SEG_STR_NOME";
            cbxSegura.DataSource = daoVeiculo.RetornaSeguros();// carrega a coluna EST_STR_NOME dentro cbx
        }
        public void popularMarca()
        {
            cbxMarca.ValueMember = "VEI_STR_MARCA";
            cbxMarca.DisplayMember = "VEI_STR_MARCA";
            cbxMarca.DataSource = daoVeiculo.RetornaMarca();// carrega a coluna EST_STR_NOME dentro cbx
        }
        public void popularModelo(string marca)
        {
            cbxmodelo.ValueMember = "VEI_STR_MODELO";
            cbxmodelo.DisplayMember = "VEI_STR_MODELO";
            cbxmodelo.DataSource = daoVeiculo.RetornaModelo(marca);// carrega o COLUNA CID_INT_NOME CONFORME O Id ESTADO
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cbxMarca.Enabled = true;
            cbxmodelo.Enabled = true;
            txtPlaca.Enabled = true;
            txtChassis.Enabled = true;
            txtrenavam.Enabled = true;
            txtCor.Enabled = true;
            txtCombus.Enabled = true;
            txtLugar.Enabled = true;
            txtKm.Enabled = true;
            txtAnoFab.Enabled = true;
            txtAnoModelo.Enabled = true;
            cbxTipoVei.Enabled = true;
            cbxEmpresa.Enabled = true;
            cbxEstado.Enabled = true;
            cbxSegura.Enabled = true;
            cbxTipo.Enabled = true;
            txtVigIni.Enabled = true;
            txtVigFin.Enabled = true;
            cbxStatusVei.Enabled = true;
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marca = cbxMarca.SelectedValue.ToString();
            popularModelo(marca);
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

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtChassis_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrenavam_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
