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

namespace GerenciadorVeiculo1.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FmrPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gerenciarSaidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSlider_Click(object sender, EventArgs e)
        {
            //Codigo para Alterar o menu lateral
            if(MenuVertical.Width == 250)
            {
                MenuVertical.Width = 67;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //iconRestaurar.Visible = false;
            //iconMaximiza.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //iconRestaurar.Visible = true;
            //iconMaximiza.Visible = false;
        }

        private void iconRestaura_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaura.Visible = false;
            iconMaximiza.Visible = true;

        }

        private void iconMaximiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaura.Visible = true;
            iconMaximiza.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconRestaurar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
