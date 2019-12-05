using dllDao;
using GerenciadorVeiculo1.Dal;
using GerenciadorVeiculo1.Dal.DaoEntradaSaida;
using GerenciadorVeiculo1.Dal.DaoMotorista;
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

namespace GerenciadorVeiculo1.View.GerEntradaSaida
{
    public partial class FmrSaida : Form
    {
        Conexao conexao = new Conexao();
        DaoMotorista daoMotorista = new DaoMotorista();
        DaoVeiculo daoVeiculo = new DaoVeiculo();
        DaoSaida daoSaida = new DaoSaida();
        LoginDaoComandos daoLog = new LoginDaoComandos();
        

        public FmrSaida()
        {
            InitializeComponent();
        }

        private void FmrSaida_Load(object sender, EventArgs e)
        {
            popularEmpresa();
            txtData.Text = DateTime.Now.ToShortDateString(); 

        }

        public void popularEmpresa()
        {
            cbxEmpresa.ValueMember = "EMP_INT_ID";
            cbxEmpresa.DisplayMember = "EMP_STR_NOME";
            cbxEmpresa.DataSource = conexao.RetornaEmpresa();// carrega a coluna EST_STR_NOME dentro cbx
        }

        public void populaMotorista(string idEmp)
        {
            cbxMotorista.ValueMember = "MOT_INT_ID";
            cbxMotorista.DisplayMember = "MOT_STR_NOME";
            cbxMotorista.DataSource = daoMotorista.SelectMotoristasPelaEmpresa(idEmp);         
        }

        public void populaPlaca(string idEmp)
        {
            cbxPlaca.ValueMember = "VEI_INT_ID";
            cbxPlaca.DisplayMember = "VEI_STR_PLACA";
            cbxPlaca.DataSource = daoVeiculo.SelectVeiculoPelaEmpresa(idEmp);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string idFun = "";
                string idMot = cbxMotorista.SelectedValue.ToString();
                string idVei = cbxPlaca.SelectedValue.ToString();
                string data = DateTime.Now.ToShortDateString();

                daoSaida.saida = new Saida(idMot, idVei, txtObs.Text, data, txtCnh.Text, txtMarca.Text);
                daoSaida.InserirSaida();
                lblAviso.Text = "Saída realizada!";
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

        private void cbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idEmp = cbxEmpresa.SelectedValue.ToString();
            populaMotorista(idEmp);
            populaPlaca(idEmp);

            txtMarca.Text = "";
            txtModelo.Text = "";
            txtOdo.Text = "";
            txtChassis.Text = "";
            txtCnh.Text = "";
            
        }

        private void cbxMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void cbxPlaca_SelectedValueChanged(object sender, EventArgs e)
        {
  
        }

        private void cbxPlaca_Click(object sender, EventArgs e)
        {
   
        }

        private void cbxPlaca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idVei = cbxPlaca.SelectedValue.ToString();
            SqlDataReader dr = daoVeiculo.SelectVeiculo(idVei);
            txtMarca.Text = dr["VEI_STR_MARCA"].ToString();
            txtModelo.Text = dr["VEI_STR_MODELO"].ToString();
            txtChassis.Text = dr["VEI_STR_CHASSI"].ToString();
            txtOdo.Text = dr["VEI_DOUBLE_KM"].ToString();
        }

        private void cbxEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //string idEmp = cbxEmpresa.SelectedValue.ToString();
            //populaMotorista(idEmp);
            //populaPlaca(idEmp);
        }

        private void cbxMotorista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idMot = cbxMotorista.SelectedValue.ToString();
            SqlDataReader dr = daoMotorista.SelectCnh(idMot);
            txtCnh.Text = dr["CNH_STR_REGISTRO"].ToString();
        }

        private void dateHora_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
