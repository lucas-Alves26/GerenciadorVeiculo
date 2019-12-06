using dllDao;
using GerenciadorVeiculo1.Dal.DaoManutencao;
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

namespace GerenciadorVeiculo1.View.GerManutencao
{
    public partial class FmrNovaManut : Form
    {
        Conexao conexao = new Conexao();
        DaoVeiculo daoVeiculo = new DaoVeiculo();
        DaoManutencao daoManutencao = new DaoManutencao();

        public FmrNovaManut()
        {
            InitializeComponent();
        }

        private void FmrNovaManut_Load(object sender, EventArgs e)
        {
            popularEmpresa();
        }

        public void popularEmpresa()
        {
            cbxEmpresa.ValueMember = "EMP_INT_ID";
            cbxEmpresa.DisplayMember = "EMP_STR_NOME";
            cbxEmpresa.DataSource = conexao.RetornaEmpresa();// carrega a coluna EST_STR_NOME dentro cbx
        }

        public void populaPlaca(string idEmp)
        {
            cbxPlaca.ValueMember = "VEI_INT_ID";
            cbxPlaca.DisplayMember = "VEI_STR_PLACA";
            cbxPlaca.DataSource = daoVeiculo.SelectVeiculoPelaEmpresa(idEmp);
        }

        private void cbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idEmp = cbxEmpresa.SelectedValue.ToString();
            populaPlaca(idEmp);

            txtModelo.Text = "";
            txtOdo.Text = "";
        }

        private void cbxPlaca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idVei = cbxPlaca.SelectedValue.ToString();
            SqlDataReader dr = daoVeiculo.SelectVeiculo(idVei);        
            txtModelo.Text = dr["VEI_STR_MODELO"].ToString();         
            txtOdo.Text = dr["VEI_DOUBLE_KM"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string idVei = cbxPlaca.SelectedValue.ToString();
                string hora = DateTime.Now.ToString("HH:mm:ss");
                daoManutencao.manutencao = new Manutencao(idVei, cbxServico.Text, cbxTipo.Text, txtObsManut.Text, DateAgenda.Text, hora);
                daoManutencao.RegistrarManutecao();
                lblAviso.Text = "Registrado com sucesso!";
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
        }

        public void Limpar()
        {
            cbxEmpresa.Text = "";
            cbxPlaca.Text = "";
            txtModelo.Text = "";
            txtObsManut.Text = "";
            txtOdo.Text = "";          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
