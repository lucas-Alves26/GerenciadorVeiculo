using dllDao;
using GerenciadorVeiculo1.Dal.DaoManutencao;
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

namespace GerenciadorVeiculo1.View.GerManutencao
{
    public partial class FmrCadastroManut : Form
    {
        DaoVeiculo daoVeiculo = new DaoVeiculo();
        Conexao conexao = new Conexao();
        DaoManutencao daoManutencao = new DaoManutencao();

        public FmrCadastroManut()
        {
            InitializeComponent();
        }

        private void FmrCadastroManut_Load(object sender, EventArgs e)
        {
            popularEmpresa();

            txtOdo.ReadOnly = true;
            txtModelo.ReadOnly = true;
        }

        public void populaPlaca(string idEmp)
        {
            cbxPlaca.ValueMember = "VEI_INT_ID";
            cbxPlaca.DisplayMember = "VEI_STR_PLACA";
            cbxPlaca.DataSource = daoVeiculo.VeiculoPelaEmpresaSaida(idEmp);
        }

        public void popularEmpresa()
        {
            cbxEmpresa.ValueMember = "EMP_INT_ID";
            cbxEmpresa.DisplayMember = "EMP_STR_NOME";
            cbxEmpresa.DataSource = conexao.RetornaEmpresa();// carrega a coluna EST_STR_NOME dentro cbx
        }

        private void cbxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idEmp = cbxEmpresa.SelectedValue.ToString();
            populaPlaca(idEmp);
        }

        private void cbxPlaca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idVei = cbxPlaca.SelectedValue.ToString();
            SqlDataReader dr = daoVeiculo.SelectVeiculo(idVei);
            txtModelo.Text = dr["VEI_STR_MODELO"].ToString();         
            txtOdo.Text = dr["VEI_DOUBLE_KM"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idVei = cbxPlaca.SelectedValue.ToString();
            string horas = DateTime.Now.ToShortTimeString();
            daoManutencao.manutencao = new Manutencao(idVei, cbxServico.Text, cbxTipo.Text, txtObsManut.Text, DateAgenda.Text, horas);
            daoManutencao.RegistrarManutecao();
            MessageBox.Show("Manutenção registrada!");
        }
    }
}
