using dllDao;
using GerenciadorVeiculo1.Dal.DaoEntradaSaida;
using GerenciadorVeiculo1.Dal.DaoManutencao;
using GerenciadorVeiculo1.Dal.DaoMotorista;
using GerenciadorVeiculo1.Dal.DaoVeiculo;
using GerenciadorVeiculo1.Entitys;
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

namespace GerenciadorVeiculo1.View.GerEntradaSaida
{
    public partial class FmrEntrada : Form
    {
        string id;
        public void Setid(string id)
        {
            this.id = id;
        }

        string dataHora = DateTime.Now.ToString();
        string hora = DateTime.Now.ToString("HH:mm:ss");

        Conexao conexao = new Conexao();
        DaoSaida daoSaida = new DaoSaida();
        DaoEntrada daoEntrada = new DaoEntrada();
        DaoManutencao daoManutencao = new DaoManutencao();

        public FmrEntrada()
        {
            InitializeComponent();
        }

        private void FmrEntrada_Load(object sender, EventArgs e)
        {





            ,,,,03txtDataEntrada.Text =  DateTime.Now.ToShortDateString();//mostra data atual no txtbox
            txtHoras.Text = DateTime.Now.ToShortTimeString(); /*DateTime.Now.ToString("HH:mm:ss");*///mostra a hora atual no ttxBox

           

            //preenche todos os dados da saída do veículo
            SqlDataReader dt = daoSaida.ConsultarSaida(id);
            txtEmp.Text = dt["EMP_STR_NOME"].ToString();
            txtMot.Text = dt["MOT_STR_NOME"].ToString();
            txtCnh.Text = dt["CNH_STR_REGISTRO"].ToString();
            txtPlaca.Text = dt["VEI_STR_PLACA"].ToString();
            txtMarca.Text = dt["VEI_STR_MARCA"].ToString();
            txtModelo.Text = dt["VEI_STR_MODELO"].ToString();
            txtChassis.Text = dt["VEI_STR_CHASSI"].ToString();
            txtOdo.Text = dt["VEI_DOUBLE_KM"].ToString();
            txtDataSaida.Text = dt["DATA"].ToString();
            txtObs.Text = dt["SAI_STR_DESC"].ToString();
            string idSaida = dt["SAI_INT_ID"].ToString();
            string idVei = dt["VEI_INT_ID"].ToString();

            txtEmp.ReadOnly = true;
            txtMot.ReadOnly = true;
            txtCnh.ReadOnly = true;
            txtPlaca.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtChassis.ReadOnly = true;
            txtOdo.ReadOnly = true;
            txtDataSaida.ReadOnly = true;
            txtObs.ReadOnly = true;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblAviso_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //serve para pegar o id do veiculo que está dando entrada
            SqlDataReader dt = daoSaida.ConsultarSaida(id);
            string idVei = dt["VEI_INT_ID"].ToString();


            daoEntrada.entrada = new Entrada(id, dataHora, txtOdoEntrada.Text,hora);
            daoEntrada.efetuarEntrada();

            if (cbxServico.Text != "" && cbxTipo.Text != "")
            {
                daoManutencao.manutencao = new Manutencao(idVei, cbxServico.Text, cbxTipo.Text, txtObs.Text, DateAgenda.Text,hora);
                daoManutencao.RegistrarManutecao();

            }
            MessageBox.Show("Veiculo deu entrada com sucesso!");
        }

        private void txtDataEntrada_KeyPress(object sender, KeyPressEventArgs e)
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
                switch (txtDataEntrada.TextLength)
                {
                    case 0:
                        txtDataEntrada.Text = "";
                        break;
                    case 2:
                        txtDataEntrada.Text = txtDataEntrada.Text + "/";
                        txtDataEntrada.SelectionStart = 4;
                        break;

                    case 5:
                        txtDataEntrada.Text = txtDataEntrada.Text + "/";
                        txtDataEntrada.SelectionStart = 6;
                        break;
                }
            }
        }

        private void txtOdoEntrada_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
