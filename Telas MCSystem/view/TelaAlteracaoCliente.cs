using System;
using System.Windows.Forms;
using Telas_MCSystem.Model;
using Telas_MCSystem.Utils;

namespace Telas_MCSystem.view
{
    public partial class TelaAlteracaoCliente : Form
    {

        Cliente c;
        End end;
        Telefone t;
        readonly int id_cliente;
        readonly int id_end;
        readonly int id_tel;
        readonly string nomeO, cpfO, emailO, nome_ruaO, bairroO, cidadeO, telefoneO;

        private void TelaAlteracaoCliente_Load(object sender, EventArgs e)
        {

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new ConsultaCliente());
        }

        readonly decimal salarioO;
        readonly int numeroO, dddO;

        private void BSalvarAltCli_Click(object sender, EventArgs e)
        {
            //--------------------Cliente
            string nome = TBAltCli.Text.Trim();
            string cpf = TBCpfAltCli.Text.Trim();
            decimal salario = Convert.ToDecimal(TBSalarioAltCli.Text);
            string email = TBEmailAltCli.Text.Trim();



            if (nomeO != nome || cpfO != cpf || salarioO != salario || emailO != email) //alteração tabela cliente 
            {
                c = new Cliente();
                c.AlterarCliente(id_cliente, nome, cpf, salario, email);
                MessageBox.Show("Alterado!!");
            }

            //----------------Endereco
            string nome_rua = TBRuaAltCli.Text.Trim();
            string bairro = TBBairroAltCli.Text.Trim();
            int numero = Convert.ToInt32(TBNumeroAltCli.Text);
            string cidade = TBCidadeAltCli.Text.Trim();

            if (nome_ruaO != nome_rua || bairroO != bairro || numeroO != numero || cidadeO != cidade) //alteração tabela endereco 
            {
                end = new End();
                end.AlterarEnderecoFornecedor(id_tel, nome_rua, bairro, numero, cidade);
                MessageBox.Show("Alterado!!");


            }

            //----------------Telefone
            int DDD = Convert.ToInt32(TBDDDAltCli.Text);
            string telefone = TBTelefoneAltCli.Text.Trim();

            if (dddO != DDD || telefoneO != telefone)
            {
                t = new Telefone();
                t.AlterarTelefoneCliente(id_tel, DDD, telefone);
                MessageBox.Show("Alterado!!");
                FormUtils.MudarFormulario(this, new ConsultaCliente());

            }

            return;
        }

        public TelaAlteracaoCliente(int id_cliente, string nome, string cpf,
            decimal salario, string email, int id_end,
            string nome_rua, string bairro, int numero_end,
            string cidade, int id_tel, int DDD, string telefone)
        {
            InitializeComponent();

            this.id_cliente = id_cliente;
            this.id_end = id_end;
            this.id_tel = id_tel;

            TBAltCli.Text = nome;
            nomeO = nome;

            TBCpfAltCli.Text = cpf;
            cpfO = cpf;

            TBSalarioAltCli.Text = Convert.ToString(salario);
            salarioO = salario;
            TBEmailAltCli.Text = email;
            emailO = email;
            TBRuaAltCli.Text = nome_rua;
            nome_ruaO = nome_rua;
            TBBairroAltCli.Text = bairro;
            bairroO = bairro;
            TBNumeroAltCli.Text = Convert.ToString(numero_end);
            numeroO = numero_end;
            TBCidadeAltCli.Text = cidade;
            cidadeO = cidade;
            TBDDDAltCli.Text = Convert.ToString(DDD);
            dddO = DDD;
            TBTelefoneAltCli.Text = telefone;
            telefoneO = telefone;
        }
    }
}
