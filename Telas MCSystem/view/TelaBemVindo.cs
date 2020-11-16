using System;
using System.Windows.Forms;
using Telas_MCSystem.Utils;
using Telas_MCSystem.view;

namespace Telas_MCSystem
{
    public partial class TelaBemVindo : Form
    {
        public TelaBemVindo()
        {
            InitializeComponent();
        }

        private void BtnCaCli_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new TelaCadastro());
        }

        private void BtnConCli_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new ConsultaCliente());


        }

        private void BtnConFun_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new ConsultaFuncionario());
        }

        private void ConsultarProduto_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new TelaConsultaProdutos());
        }
    }
}
