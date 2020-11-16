using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telas_MCSystem.Model;
using Telas_MCSystem.Utils;

namespace Telas_MCSystem.view
{
    public partial class TelaAlteracaoProdutos : Form
    { 

    Produtos p;
    readonly int id_produto;
    readonly string nomeO;
    readonly decimal Preco_custoO, Preco_vendaO;
        
        public TelaAlteracaoProdutos(int id_produto, string nome, decimal Preco_custo, decimal Preco_venda, bool situacao )
        {
            InitializeComponent();
            this.id_produto = id_produto;

            TBNomeAltPro.Text = nome;
            nomeO = nome;

            TBPrecoCustoAltPro.Text = Convert.ToString(Preco_custo);
            Preco_custoO = Preco_custo;

            TBPrecoVendaAltPro.Text = Convert.ToString(Preco_venda);
            Preco_vendaO = Preco_venda;

            if (situacao == true)
            {
                AtivoAltPro.Checked = true;
            }
            else
            {
                InativoAltPro.Checked = true;
            }
            
    }

        private void BSalvarAltPro_Click(object sender, EventArgs e)
        {
            string nome = TBNomeAltPro.Text.Trim();
            decimal Preco_custo = Convert.ToDecimal(TBPrecoCustoAltPro.Text);
            decimal Preco_venda = Convert.ToDecimal(TBPrecoVendaAltPro.Text);
            bool ativo = Convert.ToBoolean(AtivoAltPro.Checked);
           

            if (nomeO != nome || Preco_custoO != Preco_custo || Preco_vendaO != Preco_venda) //alteração tabela cliente 
            {
                if (ativo == true) 
                { 
                p = new Produtos();
                p.AlterarProduto(id_produto, nome, Preco_custo, Preco_venda, true);
                MessageBox.Show("Alterado!!");
              }
                else{
                    p = new Produtos();
                    p.AlterarProduto(id_produto, nome, Preco_custo, Preco_venda, false);
                    MessageBox.Show("Alterado!!");
                }
            }
            
        }

        private void BCancelarAltPro_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new TelaConsultaProdutos());
        }
    }
}
