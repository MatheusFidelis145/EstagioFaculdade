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
    public partial class ConsultaFornecedor : Form
    {
        Fornecedor forn;
        End end;
        Telefone tel;

        int id_Fun;
        int id_end;
        int id_tel;

        public ConsultaFornecedor()
        {
            InitializeComponent();
            DataGridViewColumn coluna = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            dataGridFornecedor.AutoGenerateColumns = false;
            dataGridFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            coluna.CellTemplate = cell;
            coluna.Name = "Id_Fornecedor";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Fornecedor";
            coluna.Width = 50;

            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Nome";
            coluna.HeaderText = "Nome";
            coluna.DataPropertyName = "Nome";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Desconto";
            coluna.HeaderText = "Desconto";
            coluna.DataPropertyName = "Desconto";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Email";
            coluna.HeaderText = "Email";
            coluna.DataPropertyName = "Email";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "CNPJ";
            coluna.HeaderText = "CNPJ";
            coluna.DataPropertyName = "CNPJ";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

            //------------------------------Endereco------------------------------------------------------



            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Id_Endereco";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Endereco";
            coluna.Width = 20;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Nome_rua";
            coluna.HeaderText = "Rua";
            coluna.DataPropertyName = "Nome_rua";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Bairro";
            coluna.HeaderText = "Bairro";
            coluna.DataPropertyName = "Bairro";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Numero";
            coluna.HeaderText = "Numero";
            coluna.DataPropertyName = "Numero";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Cidade";
            coluna.HeaderText = "Cidade";
            coluna.DataPropertyName = "Cidade";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);


            //------------------------------Telefone------------------------------------------------------

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Id_Telefone";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Telefone";
            coluna.Width = 20;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "DDD";
            coluna.HeaderText = "DDD";
            coluna.DataPropertyName = "DDD";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Numero";
            coluna.HeaderText = "Telefone";
            coluna.DataPropertyName = "Numero";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFornecedor.Columns.Add(coluna);

        }
        public void AtualizarGrade(List<Funcionario> lista)
        {
            dataGridFornecedor.DataSource = lista;
        }

        private void BPesquisarFor_Click(object sender, EventArgs e)
        {
            string texto = TbConFor.Text;

            forn = new Fornecedor();

            end = new End();

            tel = new Telefone();

            List<Fornecedor> lista;

            lista = forn.ConsultarTodos();


            if (string.IsNullOrEmpty(texto.Trim()))
            {

                dataGridFornecedor.DataSource = lista;
            }
            return;
        }

        private void BAlterarConFor_Click(object sender, EventArgs e)
        {
            int id_fornecedor = Convert.ToInt32(dataGridFornecedor.CurrentRow.Cells[0].Value);
            string nome = dataGridFornecedor.CurrentRow.Cells[1].Value.ToString();
            bool desconto = Convert.ToBoolean(dataGridFornecedor.CurrentRow.Cells[2].Value);
            string email = dataGridFornecedor.CurrentRow.Cells[3].Value.ToString();
            string CNPJ = dataGridFornecedor.CurrentRow.Cells[4].Value.ToString();
            


            //------------------------------------------------------------------------

            int id_end = Convert.ToInt32(dataGridFornecedor.CurrentRow.Cells[5].Value);
            string nome_rua = dataGridFornecedor.CurrentRow.Cells[6].Value.ToString();
            string bairro = dataGridFornecedor.CurrentRow.Cells[7].Value.ToString();
            int numero_end = Convert.ToInt32(dataGridFornecedor.CurrentRow.Cells[8].Value);
            string cidade = dataGridFornecedor.CurrentRow.Cells[9].Value.ToString();


            //---------------------------------------------------------------------------
            dataGridFornecedor.AutoGenerateColumns = false;
            int id_tel = Convert.ToInt32(dataGridFornecedor.CurrentRow.Cells[10].Value);
            int DDD = Convert.ToInt32(dataGridFornecedor.CurrentRow.Cells[11].Value);
            string telefone = dataGridFornecedor.CurrentRow.Cells[12].Value.ToString();


            FormUtils.MudarFormulario(this, new TelaAlteracaoFornecedor(id_fornecedor, nome,  desconto, email, CNPJ,  id_end,nome_rua,  bairro,  numero_end, cidade,  id_tel, DDD,  telefone));
        }
    }
    }


