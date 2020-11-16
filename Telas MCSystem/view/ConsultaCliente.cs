using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telas_MCSystem.Model;
using Telas_MCSystem.Utils;

namespace Telas_MCSystem.view
{
    public partial class ConsultaCliente : Form
    {
        Cliente c;
        End end;
        Telefone tel;

        int id_cliente;
        int id_end;
        int id_tel;

        public ConsultaCliente()
        {
            InitializeComponent();

            DataGridViewColumn coluna = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            dataGridCliente.AutoGenerateColumns = false;
            dataGridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            coluna.CellTemplate = cell;
            coluna.Name = "Id_Cliente";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Cliente";
            coluna.Width = 50;

            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Nome";
            coluna.HeaderText = "Nome";
            coluna.DataPropertyName = "Nome";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "CPF";
            coluna.HeaderText = "CPF";
            coluna.DataPropertyName = "CPF";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "salario";
            coluna.HeaderText = "Salario";
            coluna.DataPropertyName = "salario";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "email";
            coluna.HeaderText = "E-mail";
            coluna.DataPropertyName = "email";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

            //------------------------------Endereco------------------------------------------------------



            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Id_Endereco";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Endereco";
            coluna.Width = 20;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Nome_rua";
            coluna.HeaderText = "Rua";
            coluna.DataPropertyName = "Nome_rua";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Bairro";
            coluna.HeaderText = "Bairro";
            coluna.DataPropertyName = "Bairro";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Numero";
            coluna.HeaderText = "Numero";
            coluna.DataPropertyName = "Numero";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Cidade";
            coluna.HeaderText = "Cidade";
            coluna.DataPropertyName = "Cidade";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);


            //------------------------------Telefone------------------------------------------------------

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Id_Telefone";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Telefone";
            coluna.Width = 20;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "DDD";
            coluna.HeaderText = "DDD";
            coluna.DataPropertyName = "DDD";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Numero";
            coluna.HeaderText = "Telefone";
            coluna.DataPropertyName = "Numero";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridCliente.Columns.Add(coluna);

        }

        public void AtualizarGrade(List<Cliente> lista)
        {
            dataGridCliente.DataSource = lista;
        }

        private void BTNPesquisar_Click(object sender, EventArgs e)
        {

            string texto = txtBuscar.Text;

            c = new Cliente();

            end = new End();

            tel = new Telefone();

            List<Cliente> lista;

            lista = c.ConsultarTodos();


            if (string.IsNullOrEmpty(texto.Trim()))
            {
         
                dataGridCliente.DataSource = lista;
            }
            return;

        }



        private void BAlterar_Click(object sender, EventArgs e)
        {



            int id_cliente = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[0].Value);
            string nome = dataGridCliente.CurrentRow.Cells[1].Value.ToString();
            string cpf = dataGridCliente.CurrentRow.Cells[2].Value.ToString();
            decimal salario = Convert.ToDecimal(dataGridCliente.CurrentRow.Cells[3].Value);
            string email = dataGridCliente.CurrentRow.Cells[4].Value.ToString();


            //------------------------------------------------------------------------

            int id_end = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[5].Value);
            string nome_rua = dataGridCliente.CurrentRow.Cells[6].Value.ToString();
            string bairro = dataGridCliente.CurrentRow.Cells[7].Value.ToString();
            int numero_end = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[8].Value);
            string cidade = dataGridCliente.CurrentRow.Cells[9].Value.ToString();


            //---------------------------------------------------------------------------
            dataGridCliente.AutoGenerateColumns = false;
            int id_tel = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[10].Value);
            int DDD = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[11].Value);
            string telefone = dataGridCliente.CurrentRow.Cells[12].Value.ToString();


            FormUtils.MudarFormulario(this, new TelaAlteracaoCliente(id_cliente, nome, cpf, salario, email, id_end, nome_rua, bairro, numero_end, cidade, id_tel, DDD, telefone));
        }

        private void btnVolCon_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new TelaBemVindo());
        }

        private void BExcluir_Click(object sender, EventArgs e)
        {
            c = new Cliente();

            id_cliente = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[0].Value);
            id_end = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[5].Value);
            id_tel = Convert.ToInt32(dataGridCliente.CurrentRow.Cells[10].Value);

            c.Excluir(id_cliente);

            MessageBox.Show("Excluido com sucesso!!");
            
            List<Cliente> lista;

            lista = c.ConsultarTodos();
            dataGridCliente.DataSource = lista;
        }
    }
}


