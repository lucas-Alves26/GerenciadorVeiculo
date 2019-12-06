using dllDao;
using GerenciadorVeiculo1.Dal.DaoEntradaSaida;
using GerenciadorVeiculo1.Dal.DaoMotorista;
using GerenciadorVeiculo1.Dal.DaoVeiculo;
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
    public partial class FmrDadosSaida : Form
    {
        string id;
        public void Setid(string id)
        {
            this.id = id;
        }


        Conexao conexao = new Conexao();
        DaoSaida daoSaida = new DaoSaida();
        DaoVeiculo daoVeiculo = new DaoVeiculo();
        DaoMotorista daoMotorista = new DaoMotorista();
 

        public FmrDadosSaida()
        {
            InitializeComponent();
        }

        private void FmrDadosSaida_Load(object sender, EventArgs e)
        {
            popularEmpresa();

            SqlDataReader dt = daoSaida.ConsultarSaida(id);
            cbxEmpresa.Text = dt["EMP_STR_NOME"].ToString();
            cbxMotorista.Text = dt["MOT_STR_NOME"].ToString();
            txtCnh.Text = dt["CNH_STR_REGISTRO"].ToString();
            cbxPlacaa.Text = dt["VEI_STR_PLACA"].ToString();
            txtMarca.Text = dt["VEI_STR_MARCA"].ToString();
            txtModelo.Text = dt["VEI_STR_MODELO"].ToString();
            txtChassis.Text = dt["VEI_STR_CHASSI"].ToString();
            txtOdo.Text = dt["VEI_DOUBLE_KM"].ToString();
            txtData.Text = dt["DATA"].ToString();
            txtObs.Text = dt["SAI_STR_DESC"].ToString();

            //txtEmp.ReadOnly = true;
            //txtMot.ReadOnly = true;
            //txtCnh.ReadOnly = true;
            //txtPlaca.ReadOnly = true;


            cbxEmpresa.Enabled = false;
            cbxMotorista.Enabled = false;
            txtCnh.ReadOnly = true;
            cbxPlacaa.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtChassis.Enabled = false;
            txtOdo.Enabled = false;
            txtData.Enabled = false;
            txtObs.Enabled = false;
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
            cbxMotorista.DataSource = daoMotorista.MotoristasViagemDisponivel(idEmp,id);
        }

        public void populaPlaca(string idEmp)
        {
            cbxPlacaa.ValueMember = "VEI_INT_ID";
            cbxPlacaa.DisplayMember = "VEI_STR_PLACA";
            cbxPlacaa.DataSource = daoVeiculo.VeiculoPelaEmpresaSaida(idEmp,id);
        }

        private void cbxMotorista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idMot = cbxMotorista.SelectedValue.ToString();
            SqlDataReader dr = daoMotorista.SelectCnh(idMot);
            txtCnh.Text = dr["CNH_STR_REGISTRO"].ToString();
        }

        private void cbxPlaca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idVei = cbxPlacaa.SelectedValue.ToString();
            SqlDataReader dr = daoVeiculo.SelectVeiculo(idVei);
            txtMarca.Text = dr["VEI_STR_MARCA"].ToString();
            txtModelo.Text = dr["VEI_STR_MODELO"].ToString();
            txtChassis.Text = dr["VEI_STR_CHASSI"].ToString();
            txtOdo.Text = dr["VEI_DOUBLE_KM"].ToString();
        }

        private void cbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idEmp = cbxEmpresa.SelectedValue.ToString();
            populaMotorista(idEmp);
            populaPlaca(idEmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            cbxMotorista.Enabled = true;       
            cbxPlaca.Enabled = true;
            txtData.Enabled = true;
            txtObs.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

