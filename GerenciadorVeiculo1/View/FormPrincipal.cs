using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.View.GerEmpresa;
using GerenciadorVeiculo1.View.GerMotorista;
using GerenciadorVeiculo1.View.GerVeiculo;
using GerenciadorVeiculo1.View.GerManutencao;
using GerenciadorVeiculo1.Dal.DaoManutencao;
using GerenciadorVeiculo1.View.GerEntradaSaida;

namespace GerenciadorVeiculo1.View
{
    public partial class FormPrincipal : Form
    {
        string op = "Todas";

        DaoManutencao daoManutencao = new DaoManutencao();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        private void iconRestaurar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bntUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 240)
            {
                MenuVertical.Width = 63;
            }
            else
            {
                MenuVertical.Width = 240;
            }
        }

        private void iconEcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {        
            this.WindowState = FormWindowState.Normal;
            iconNormal.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconNormal.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dgManut.DataSource = daoManutencao.DadosManutPrincipal();
        }

        private void iconMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconNormal_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            iconNormal.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconNormal.Visible = true;
            iconMaximizar.Visible = false;


        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {



        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x122,0xf012,0);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntUsuario_Click(object sender, EventArgs e)
        {
            fmrTelaUsuario fmrTelaUsuario = new fmrTelaUsuario();
            fmrTelaUsuario.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FmrEmpresa fmrEmpresa = new FmrEmpresa();
            fmrEmpresa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FmrMotorista fmrMotorista = new FmrMotorista();
            fmrMotorista.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FmrVeiculos fmrVeiculos = new FmrVeiculos();
            fmrVeiculos.Show();
        }

        private void dgManut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dgManut.Height == 377)
            {
                dgManut.Height = 0;
            }
            else
            {
               dgManut.Height = 377;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FmrManut fmrManut = new FmrManut();
            fmrManut.Show();
        }

        private void dgManut_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FmrConsultaSaida fmrConsultaSaida = new FmrConsultaSaida();
            fmrConsultaSaida.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FmrSaida fmrSaida = new FmrSaida();
            fmrSaida.Show();
        }
    }

}
