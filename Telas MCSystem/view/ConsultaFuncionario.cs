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
    public partial class ConsultaFuncionario : Form
    {
        Funcionario f;
        End end;
        Telefone tel;

        int id_Fun;
        int id_end;
        int id_tel;

        public ConsultaFuncionario()
        {
            InitializeComponent();

            DataGridViewColumn coluna = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            dataGridFuncionario.AutoGenerateColumns = false;
            dataGridFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            coluna.CellTemplate = cell;
            coluna.Name = "Id_Funcionario";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Funcionario";
            coluna.Width = 50;

            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Nome";
            coluna.HeaderText = "Nome";
            coluna.DataPropertyName = "Nome";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "CPF";
            coluna.HeaderText = "CPF";
            coluna.DataPropertyName = "CPF";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "salario";
            coluna.HeaderText = "Salario";
            coluna.DataPropertyName = "salario";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "email";
            coluna.HeaderText = "E-mail";
            coluna.DataPropertyName = "email";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

            //------------------------------Endereco------------------------------------------------------



            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Id_Endereco";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Endereco";
            coluna.Width = 20;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Nome_rua";
            coluna.HeaderText = "Rua";
            coluna.DataPropertyName = "Nome_rua";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Bairro";
            coluna.HeaderText = "Bairro";
            coluna.DataPropertyName = "Bairro";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Numero";
            coluna.HeaderText = "Numero";
            coluna.DataPropertyName = "Numero";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Cidade";
            coluna.HeaderText = "Cidade";
            coluna.DataPropertyName = "Cidade";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);


            //------------------------------Telefone------------------------------------------------------

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Id_Telefone";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Telefone";
            coluna.Width = 20;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "DDD";
            coluna.HeaderText = "DDD";
            coluna.DataPropertyName = "DDD";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Numero";
            coluna.HeaderText = "Telefone";
            coluna.DataPropertyName = "Numero";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFuncionario.Columns.Add(coluna);

        }

        public void AtualizarGrade(List<Funcionario> lista)
        {
            dataGridFuncionario.DataSource = lista;
        }

        private void BTNPesquisarFun_Click(object sender, EventArgs e)
        {

            string texto = TbConFun.Text;

            f = new Funcionario();

            end = new End();

            tel = new Telefone();

            List<Funcionario> lista;

            lista = f.ConsultarTodos();


            if (string.IsNullOrEmpty(texto.Trim()))
            {
                for (int i = 0; i < dataGridFuncionario.RowCount; i++)
                {
                    dataGridFuncionario.Rows[i].DataGridView.Columns.Clear();
                }

                dataGridFuncionario.DataSource = lista;
            }
            return;

        }



        private void BAlterar_Click(object sender, EventArgs e)
        {



            int id_cliente = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[0].Value);
            string nome = dataGridFuncionario.CurrentRow.Cells[1].Value.ToString();
            string cpf = dataGridFuncionario.CurrentRow.Cells[2].Value.ToString();
            decimal salario = Convert.ToDecimal(dataGridFuncionario.CurrentRow.Cells[3].Value);
            string email = dataGridFuncionario.CurrentRow.Cells[4].Value.ToString();


            //------------------------------------------------------------------------

            int id_end = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[5].Value);
            string nome_rua = dataGridFuncionario.CurrentRow.Cells[6].Value.ToString();
            string bairro = dataGridFuncionario.CurrentRow.Cells[7].Value.ToString();
            int numero_end = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[8].Value);
            string cidade = dataGridFuncionario.CurrentRow.Cells[9].Value.ToString();


            //---------------------------------------------------------------------------
            dataGridFuncionario.AutoGenerateColumns = false;
            int id_tel = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[10].Value);
            int DDD = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[11].Value);
            string telefone = dataGridFuncionario.CurrentRow.Cells[12].Value.ToString();


            FormUtils.MudarFormulario(this, new TelaAlteracaoFuncionario(id_Fun, nome, cpf, salario, email, id_end, nome_rua, bairro, numero_end, cidade, id_tel, DDD, telefone));
        }

        private void btnVolCon_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new TelaBemVindo());
        }

        private void BExcluirConFun_Click(object sender, EventArgs e)
        {
            f = new Funcionario();

            id_Fun = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[0].Value);
            id_end = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[5].Value);
            id_tel = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[10].Value);

            int aaa = f.Excluir(id_Fun);

            MessageBox.Show("Excluido com sucesso!!");
        }

        private void BPesquisarFun_Click(object sender, EventArgs e)
        {
            string texto = TbConFun.Text;

            f = new Funcionario();

            end = new End();

            tel = new Telefone();

            List<Funcionario> lista;

            lista = f.ConsultarTodos();


            if (string.IsNullOrEmpty(texto.Trim()))
            {
      
                dataGridFuncionario.DataSource = lista;
            }
            return;
        }

        private void BAlterarConFun_Click(object sender, EventArgs e)
        {
            {



                int id_funcionario = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[0].Value);
                string nome = dataGridFuncionario.CurrentRow.Cells[1].Value.ToString();
                string cpf = dataGridFuncionario.CurrentRow.Cells[2].Value.ToString();
                decimal salario = Convert.ToDecimal(dataGridFuncionario.CurrentRow.Cells[3].Value);
                string email = dataGridFuncionario.CurrentRow.Cells[4].Value.ToString();


                //------------------------------------------------------------------------

                int id_end = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[5].Value);
                string nome_rua = dataGridFuncionario.CurrentRow.Cells[6].Value.ToString();
                string bairro = dataGridFuncionario.CurrentRow.Cells[7].Value.ToString();
                int numero_end = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[8].Value);
                string cidade = dataGridFuncionario.CurrentRow.Cells[9].Value.ToString();


                //---------------------------------------------------------------------------
                dataGridFuncionario.AutoGenerateColumns = false;
                int id_tel = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[10].Value);
                int DDD = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[11].Value);
                string telefone = dataGridFuncionario.CurrentRow.Cells[12].Value.ToString();


                FormUtils.MudarFormulario(this, new TelaAlteracaoFuncionario(id_funcionario, nome, cpf, salario, email, id_end, nome_rua, bairro, numero_end, cidade, id_tel, DDD, telefone));
            }
        }

        private void BExcluirConFun_Click_1(object sender, EventArgs e)
        {
            f = new Funcionario();

            id_Fun = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[0].Value);
            id_end = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[5].Value);
            id_tel = Convert.ToInt32(dataGridFuncionario.CurrentRow.Cells[10].Value);

            int aaa = f.Excluir(id_Fun);

            MessageBox.Show("Excluido com sucesso!!");
        }

        private void btnVolConFun_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new TelaBemVindo());
        }
    }
}