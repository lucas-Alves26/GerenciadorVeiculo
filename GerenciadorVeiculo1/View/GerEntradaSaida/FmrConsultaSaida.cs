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
        string idSelect = "";

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
            // ao clicar na informação da coluna desejada vai pegar informação e
            //passar ao txtId
            var valor = dgSaida[e.ColumnIndex, e.RowIndex].Value.ToString();
            idSelect = valor;

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
            if (idSelect == "")
            {
                MessageBox.Show("click no ID primeiro!");
            }
            else
            {
                FmrDadosSaida fmrDadosSaida = new FmrDadosSaida();
                fmrDadosSaida.Setid(idSelect);
                fmrDadosSaida.ShowDialog();

                
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            if (idSelect == "")
            {
                MessageBox.Show("click no ID primeiro!");
            }
            else
            {
                FmrEntrada fmrEntrada = new FmrEntrada();
                fmrEntrada.Setid(idSelect);
                fmrEntrada.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrSaida fmrSaida = new FmrSaida();
            fmrSaida.ShowDialog();
        }
    }
}
