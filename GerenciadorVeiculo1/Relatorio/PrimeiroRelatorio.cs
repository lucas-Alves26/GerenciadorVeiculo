using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorVeiculo1.Relatorio
{
    public partial class PrimeiroRelatorio : Form
    {
        public PrimeiroRelatorio()
        {
            InitializeComponent();
        }

        private void PrimeiroRelatorio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
