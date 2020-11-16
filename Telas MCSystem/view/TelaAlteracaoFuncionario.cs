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
    public partial class TelaAlteracaoFuncionario : Form
    {
        Funcionario f;
        readonly int id_funcionario;
        readonly int id_end;
        readonly int id_tel, numeroO, dddO;
        readonly string nomeO, cpfO, emailO, nome_ruaO, bairroO, cidadeO, telefoneO;

   

        readonly decimal salarioO;
        public TelaAlteracaoFuncionario(int id_funcionario, string nome, string cpf,
            decimal salario, string email, int id_end,
            string nome_rua, string bairro, int numero_end,
            string cidade, int id_tel, int ddd, string telefone)
        {
            InitializeComponent();
            this.id_funcionario = id_funcionario;
            this.id_end = id_end;
            this.id_tel = id_tel;

            TBAltFun.Text = nome;
            nomeO = nome;

            TBCpfAltFun.Text = cpf;
            cpfO = cpf;

            TBSalarioAltFun.Text = salario.ToString();
            salarioO = salario;
            TBEmailAltFun.Text = email;
            emailO = email;
            TBRuaAltFun.Text = nome_rua;
            nome_ruaO = nome_rua;
            TBBairroAltFun.Text = bairro;
            bairroO = bairro;
            TBNumeroAltFun.Text = Convert.ToString(numero_end);
            numeroO = numero_end;
            TBCidadeAltFun.Text = cidade;
            cidadeO = cidade;
            TBDDDAltFun.Text = Convert.ToString(ddd);
            dddO = ddd;
            TBTelefoneAltFun.Text = telefone;
            telefoneO = telefone;
        }

        private void BSalvarAltFun_Click(object sender, EventArgs e)
        {
            string nome = TBCpfAltFun.Text.Trim();
            string cpf = TBCpfAltFun.Text.Trim();
            decimal salario = Convert.ToDecimal(TBSalarioAltFun.Text);
            string email = TBEmailAltFun.Text.Trim();
            string nome_rua = TBRuaAltFun.Text.Trim();
            string bairro = TBBairroAltFun.Text.Trim();
            int numero = Convert.ToInt32(TBNumeroAltFun.Text);
            string cidade = TBCidadeAltFun.Text.Trim();
            int ddd = Convert.ToInt32(TBDDDAltFun.Text);
            string telefone = TBTelefoneAltFun.Text.Trim();



            if (nomeO != nome || cpfO != cpf || salarioO != salario || emailO != email || nome_ruaO!= nome_rua
                || bairroO != bairro || numeroO != numero || cidadeO != cidade || dddO != ddd || telefoneO != telefone)
                {
                f = new Funcionario();
                f.AlterarFuncionario(id_funcionario, nome,  cpf,  salario,  email,id_end, nome_rua,
              bairro,  numero,  cidade,id_tel, ddd,  telefone);
                MessageBox.Show("Alterado!!");
            }

            return;
        }

    }
    }

    

