using GerenciadorVeiculo1.Dal.DaoMotorista;
using GerenciadorVeiculo1.Entitys;
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

namespace GerenciadorVeiculo1.View.GerMotorista
{
    public partial class FmrMotorista : Form
    {
        DaoMotorista dao = new DaoMotorista();

        //armazena id do motorista
        string motId;

        public FmrMotorista()
        {
            InitializeComponent();
            // ao abrir o frm ja abre com as informações de usuarios cadastrados
            dgMotorista.DataSource = dao.ConsultaMotorista();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dao.motorista = new Motorista(txtId.Text);
                dao.DeletMotorista();
                MessageBox.Show("Deletado com sucesso!");
            }
            catch(DomainExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FmrMotorista_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgMotorista.DataSource = dao.ConsultaMotorista();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FmrCadastroMot fmr = new FmrCadastroMot();
            fmr.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Coloque o ID do motorista para consultar");

            }
            else
            {
                
                motId = txtId.Text;//recebe o id colocado no txtboxId
                FmrEditarMot mot = new FmrEditarMot();
                mot.GetId(motId);
                mot.Show();
            }
        }
    }
}
