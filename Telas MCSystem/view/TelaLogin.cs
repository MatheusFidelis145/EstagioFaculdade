using System;
using System.Windows.Forms;
using Telas_MCSystem.Model;
using Telas_MCSystem.Utils;

namespace Telas_MCSystem
{
    public partial class TelaLogin : Form
    {
        Login l;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string login = TXTLogin.Text;
            string senha = TXTSenha.Text;
            l = new Login();
            int nivel = l.LoginPorNivel(login, senha);
            if (nivel == 1)//Usuario normal
            {
                FormUtils.MudarFormulario(this, new TelaBemVindo());

            }
            else if (nivel == 2)// Administrador
            {

            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!");
            }




        }
    }
}
