using GerenciadorVeiculo1.Dal.DaoManutencao;
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
            //FmrCadastroManut fmrCadastroManut = new FmrCadastroManut();
            //fmrCadastroManut.Show();
        }
    }
}
