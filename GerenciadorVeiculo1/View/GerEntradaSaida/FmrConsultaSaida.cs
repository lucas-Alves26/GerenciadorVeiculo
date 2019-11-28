using dllDao;
using GerenciadorVeiculo1.Dal.DaoEntradaSaida;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.View.GerEntradaSaida
{
    public partial class FmrConsultaSaida : Form
    {
        string op = "Todas";

        Conexao conexao = new Conexao();
        DaoSaida daoSaida = new DaoSaida();
       
        public FmrConsultaSaida()
        {
            InitializeComponent();
        }

        private void FmrConsultaSaida_Load(object sender, EventArgs e)
        {

            dgSaida.DataSource = daoSaida.SelectSaidaDeVeiculos(op);
        }

        private void dgSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            op = cbxConsulta.Text;

            if(op == "")
            {
                op = "Todas";
            }

            dgSaida.DataSource = daoSaida.SelectSaidaDeVeiculos(op);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FmrDadosSaida fmrDadosSaida = new FmrDadosSaida();
            fmrDadosSaida.Setid(txtId.Text);
            fmrDadosSaida.Show();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FmrEntrada fmrEntrada = new FmrEntrada();
            fmrEntrada.Setid(txtId.Text);
            fmrEntrada.Show();
        }
    }
}
