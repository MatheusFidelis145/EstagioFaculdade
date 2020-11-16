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
    public partial class TelaAlteracaoFornecedor : Form
    {
        Fornecedor forn;
        End end;
        Telefone t;
        readonly int id_fornecedor;
        readonly int id_end;
        readonly int id_tel, numeroO, dddO;
        readonly string nomeO, cnpjO, emailO, nome_ruaO, bairroO, cidadeO, telefoneO;

        private void TelaAlteracaoFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void BSalvarAltFor_Click(object sender, EventArgs e)
        {
            //--------------------Fornecedor
            string nome = TBAltFor.Text.Trim();
            string cnpj = TBCnpjAltFor.Text.Trim();
            string email = TBEmailAltFor.Text.Trim();



            if (nomeO != nome || cnpjO != cnpj || emailO != email) //alteração tabela cliente 
            {
                forn = new Fornecedor();
                forn.AlterarFornecedor(id_fornecedor, nome, true, email, cnpj);
                MessageBox.Show("Alterado!!");
            }

            //----------------Endereco
            string nome_rua = TBRuaAltFor.Text.Trim();
            string bairro = TBBairroAltFor.Text.Trim();
            int numero = Convert.ToInt32(TBNumeroAltFor.Text);
            string cidade = TBCidadeAltFor.Text.Trim();

            if (nome_ruaO != nome_rua || bairroO != bairro || numeroO != numero || cidadeO != cidade) //alteração tabela endereco 
            {
                end = new End();
                end.AlterarEnderecoFornecedor(id_tel, nome_rua, bairro, numero, cidade);
                MessageBox.Show("Alterado!!");


            }

            //----------------Telefone
            int DDD = Convert.ToInt32(TBDDDAltFor.Text);
            string telefone = TBTelefoneAltFor.Text.Trim();

            if (dddO != DDD || telefoneO != telefone)
            {
                t = new Telefone();
                t.AlterarTelefoneCliente(id_tel, DDD, telefone);
                MessageBox.Show("Alterado!!");
                FormUtils.MudarFormulario(this, new ConsultaCliente());

            }

            return;
        }





        public TelaAlteracaoFornecedor(int id_fornecedor, string nome, bool desconto,
            string email, string cnpj, int id_end,
            string nome_rua, string bairro, int numero_end,
            string cidade, int id_tel, int ddd, string telefone)
        {
            InitializeComponent();
            this.id_fornecedor = id_fornecedor;
            this.id_end = id_end;
            this.id_tel = id_tel;

            TBAltFor.Text = nome;
            nomeO = nome;

            TBRuaAltFor.Text = nome_rua;
            nome_ruaO = nome_rua;


            TBBairroAltFor.Text = bairro;
            bairroO = bairro;
            TBNumeroAltFor.Text = Convert.ToString(numero_end);
            numeroO = numero_end;
            TBCidadeAltFor.Text = cidade;
            cidadeO = cidade;
            TBCnpjAltFor.Text = cnpj;
            cnpjO = cnpj;
            TBEmailAltFor.Text = email;
            emailO = email;
            TBDDDAltFor.Text = Convert.ToString(ddd);
            dddO = ddd;
            TBTelefoneAltFor.Text = telefone;
            telefoneO = telefone;


        }
    }

}