using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telas_MCSystem.Model;
using Telas_MCSystem.Utils;

namespace Telas_MCSystem
{
    public partial class TelaCadastro : Form
    {
        private readonly List<Control> camposFuncionario = new List<Control>();
        private readonly List<Control> camposFornecedor = new List<Control>();
        private readonly List<Control> camposCliente = new List<Control>();
        private readonly List<Control> camposProduto = new List<Control>();

        Cliente c;
        Funcionario f;
        Produtos p;
        Fornecedor forn;

        int index;

        int id_end;
        int id_tel;
        int id_fun;
        int id_prod;



        public TelaCadastro()
        {
            InitializeComponent();

            PopularCamposCliente();
            PopularCamposFornecedor();
            PopularCamposFuncionario();
            PopularCamposProduto();

            CBCadastro.SelectedIndex = 0;
        }

        private void PopularCamposFuncionario()
        {
            camposFuncionario.Add(TBNomeCadastro);
            camposFuncionario.Add(TBRuaCadastro);
            camposFuncionario.Add(TBBairroCadastro);
            camposFuncionario.Add(TBNumeroCadastro);
            camposFuncionario.Add(TBCidadeCadastro);
            camposFuncionario.Add(TBCpfCadastro);
            camposFuncionario.Add(TBEmailCadastro);
            camposFuncionario.Add(TBSalarioCadastro);
            camposFuncionario.Add(TBTelefoneCadastro);
            camposFuncionario.Add(TBDDDCadastro);
            camposFuncionario.Add(TBLoginCadastro);
            camposFuncionario.Add(TBSenhaCadastro);
        }

        private void PopularCamposFornecedor()
        {
            camposFornecedor.Add(TBNomeCadastro);
            camposFornecedor.Add(TBRuaCadastro);
            camposFornecedor.Add(TBBairroCadastro);
            camposFornecedor.Add(TBNumeroCadastro);
            camposFornecedor.Add(TBCidadeCadastro);
            camposFornecedor.Add(TBEmailCadastro);
            camposFornecedor.Add(TBSalarioCadastro);
            camposFornecedor.Add(TBTelefoneCadastro);
            camposFornecedor.Add(TBDDDCadastro);
            camposFornecedor.Add(TBCnpjCadastro);
            camposFornecedor.Add(Sim);
            camposFornecedor.Add(Nao);
        }

        private void PopularCamposCliente()
        {
            camposCliente.Add(TBNomeCadastro);
            camposCliente.Add(TBRuaCadastro);
            camposCliente.Add(TBBairroCadastro);
            camposCliente.Add(TBNumeroCadastro);
            camposCliente.Add(TBCidadeCadastro);
            camposCliente.Add(TBCpfCadastro);
            camposCliente.Add(TBEmailCadastro);
            camposCliente.Add(TBSalarioCadastro);
            camposCliente.Add(TBTelefoneCadastro);
            camposCliente.Add(TBDDDCadastro);
        }
        private void PopularCamposProduto()
        {
            camposProduto.Add(TBNomeCadastro);
            camposProduto.Add(TBPrecoCusto);
            camposProduto.Add(TBPrecoVenda);
            camposProduto.Add(Ativo);
            camposProduto.Add(Inativo);
            camposProduto.Add(Sim);
            camposProduto.Add(Nao);
        }

        private void DesabilitarControles()
        {
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    DesabilitarTextBox(control);
                }

                if (control is RadioButton)
                {
                    DesabilitarRadioButton(control);
                }
            }

            static void DesabilitarTextBox(object control)
            {
                var tbox = (TextBox)control;
                tbox.Text = string.Empty;
                tbox.Enabled = false;
            }

            static void DesabilitarRadioButton(object control)
            {
                var rbutton = (RadioButton)control;
                rbutton.Enabled = false;
                rbutton.Checked = false;
            }
        }

        private void CBCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = ((ComboBox)sender).SelectedIndex;

            if (index < 0)
            {
                return;
            }

            // 0 = funcionario
            // 1 = cliente
            // 2 = fornecedor
            // 3 = produtos

            if (index == 0)
            {
                DesabilitarControles();

                foreach (var campo in camposFuncionario)
                {
                    campo.Enabled = true;

                    if (campo is TextBox)
                    {
                        campo.Text = string.Empty;
                    }
                }
            }

            if (index == 1)
            {
                DesabilitarControles();

                foreach (var campo in camposCliente)
                {
                    campo.Enabled = true;

                    if (campo is TextBox)
                    {
                        campo.Text = string.Empty;
                    }
                }
            }

            if (index == 2)
            {
                DesabilitarControles();

                foreach (var campo in camposFornecedor)
                {
                    campo.Enabled = true;

                    if (campo is TextBox)
                    {
                        campo.Text = string.Empty;
                    }
                }
            }


            if (index == 3)
            {
                DesabilitarControles();

                foreach (var campo in camposProduto)
                {
                    campo.Enabled = true;

                    if (campo is TextBox)
                    {
                        campo.Text = string.Empty;
                    }
                }
            }
        }

        private void LimparCampos()
        {
            foreach (var controle in Controls)
            {
                if (controle is TextBox box)
                {
                    box.Text = string.Empty;
                }

                if (controle is RadioButton button)
                {
                    button.Checked = false;
                }
            }
        }

        private void BLimpar_Click(object sender, EventArgs e) => LimparCampos();

        private void CBCadastro_KeyPress(object sender, KeyPressEventArgs e)
            => e.Handled = true;

        private void BCadastrar_Click(object sender, EventArgs e)
        {
          

            if (index == 1)
            {
                string nome = TBNomeCadastro.Text.Trim();
                string cpf = TBCpfCadastro.Text.Trim();
                string email = TBEmailCadastro.Text.Trim();
                string rua = TBRuaCadastro.Text.Trim();
                string bairro = TBBairroCadastro.Text.Trim();
                int numero = Convert.ToInt32(TBNumeroCadastro.Text);
                string cidade = TBCidadeCadastro.Text.Trim();
                decimal salario = Convert.ToDecimal(TBSalarioCadastro.Text.Trim());
                int DDD = Convert.ToInt32(TBDDDCadastro.Text);
                string telefone = TBTelefoneCadastro.Text.Trim();
                c = new Cliente();

                int id = c.Inserir(nome, cpf, salario, email);//inserir cliente

                id_end = c.InserirEndereco(rua, bairro, numero, cidade);//inserir endereço

                id_tel = c.InserirTelefone(DDD, telefone);//inserir telefone

                c.InserirEnderecoCliente(id, id_end);//inseri clienteEndereço

                c.InserirTelefoneCliente(id, id_tel);//inserir clienteTelefone

                MessageBox.Show("Cliente inserido com sucesso!!");
            }

            if (index == 0 )
            {
                string nome = TBNomeCadastro.Text.Trim();
                string cpf = TBCpfCadastro.Text.Trim();
                string email = TBEmailCadastro.Text.Trim();
                string rua = TBRuaCadastro.Text.Trim();
                string bairro = TBBairroCadastro.Text.Trim();
                int numero = Convert.ToInt32(TBNumeroCadastro.Text);
                string cidade = TBCidadeCadastro.Text.Trim();
                decimal salario = Convert.ToDecimal(TBSalarioCadastro.Text.Trim());
                int DDD = Convert.ToInt32(TBDDDCadastro.Text);
                string telefone = TBTelefoneCadastro.Text.Trim();
                string login = TBLoginCadastro.Text.Trim();
                string senha = TBSenhaCadastro.Text.Trim();

                f = new Funcionario();

                id_fun = f.Inserir(nome, cpf, salario, email, login, senha);
                id_end = f.InserirEndereco(rua, bairro, numero, cidade);
                id_tel = f.InserirTelefone(DDD, telefone);
                f.InserirEnderecoFuncionario(id_end, id_fun);
                f.InserirTelefoneFuncionario(id_tel, id_fun);

                MessageBox.Show("Funcionario inserido com sucesso!!");
            }
            if(index == 3 )
            {
                string nome = TBNomeCadastro.Text.Trim();
                decimal preco_custo = Convert.ToDecimal(TBPrecoCusto.Text);
                decimal preco_venda = Convert.ToDecimal(TBPrecoVenda.Text);
                if (Ativo.Checked == true)
                {
                    p = new Produtos();
                    id_prod = p.Inserir(nome, preco_custo, preco_venda, true);

                    MessageBox.Show("Produto inserido com sucesso!!");
                }
                else
                {
                    p = new Produtos();
                    id_prod = p.Inserir(nome, preco_custo, preco_venda, false);

                    MessageBox.Show("Produto inserido com sucesso!!");
                }
            }
            if (index == 2)
            {
                string nome = TBNomeCadastro.Text.Trim();
                string cnpj = TBCnpjCadastro.Text.Trim();
                string email = TBEmailCadastro.Text.Trim();
                string rua = TBRuaCadastro.Text.Trim();
                string bairro = TBBairroCadastro.Text.Trim();
                int numero = Convert.ToInt32(TBNumeroCadastro.Text);
                string cidade = TBCidadeCadastro.Text.Trim();
                int DDD = Convert.ToInt32(TBDDDCadastro.Text);
                string telefone = TBTelefoneCadastro.Text.Trim();

                if (Sim.Checked == true)
                {
                    forn = new Fornecedor();

                    forn.Inserir(nome, true, email, cnpj );//inserir cliente

                    id_end = forn.InserirEndereco(rua, bairro, numero, cidade);//inserir endereço

                    id_tel = forn.InserirTelefone(DDD, telefone);//inserir telefone

                    forn.InserirEnderecoFornecedor(id_end);//inseri clienteEndereço

                    forn.InserirTelefoneFornecedor(id_tel);//inserir clienteTelefone

                    MessageBox.Show("Fornecedor inserido com sucesso!!");
                }
                else
                {
                    forn = new Fornecedor();
                    id_prod = forn.Inserir(nome, false, email, cnpj);

                    MessageBox.Show("Fornecedor inserido com sucesso!!");
                }
            }


        }

        private void BVoltar_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new TelaBemVindo());
        }
    }
}