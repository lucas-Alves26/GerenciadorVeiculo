using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorVeiculo1.View;
using GerenciadorVeiculo1.View.GerEmpresa;
using GerenciadorVeiculo1.View.GerEntradaSaida;
using GerenciadorVeiculo1.View.GerVeiculo;

namespace GerenciadorVeiculo1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
            /*FmrSaida*/
            //tlaLogin
            //FormPrincipal
        }
    }
}
