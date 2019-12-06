using GerenciadorVeiculo1.Dal.DaoManutencao;
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

namespace GerenciadorVeiculo1.View.GerManutencao
{
    public partial class FmrManut : Form
    {
        string op = "Todas";
        string idSelect = "";

        DaoManutencao daoManutencao = new DaoManutencao();

        public FmrManut()
        {
            InitializeComponent();
        }

        private void FmrManut_Load(object sender, EventArgs e)
        {
            dgManutencao.DataSource = daoManutencao.SelectManutencao(op);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrNovaManut fmrNovaManut = new FmrNovaManut();
            fmrNovaManut.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgManutencao.DataSource = daoManutencao.SelectManutencao(op);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (idSelect == "")
            {
                MessageBox.Show("Selecione o ID para consultar");
            }
            else
            {
                try
                {
                    FmrManutConsut fmrManutConsut = new FmrManutConsut();
                    fmrManutConsut.GetId(idSelect);
                    fmrManutConsut.Show();
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
        }

        private void dgManutencao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ao clicar na informação da coluna desejada vai pegar informação e
            //passar ao txtId
            var valor = dgManutencao[e.ColumnIndex, e.RowIndex].Value.ToString();
            idSelect = valor;
        }
    }
}
