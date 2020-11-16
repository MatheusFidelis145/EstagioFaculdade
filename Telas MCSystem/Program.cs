using System;
using System.Windows.Forms;

namespace Telas_MCSystem
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
            Form formulario = new TelaLogin();
            Application.Run(formulario);
        }
    }
}
