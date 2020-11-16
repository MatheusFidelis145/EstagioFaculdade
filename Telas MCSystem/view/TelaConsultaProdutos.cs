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
    public partial class TelaConsultaProdutos : Form
    {
        Produtos p;

        int id_produto;
        public TelaConsultaProdutos()
        {
            InitializeComponent();
            DataGridViewColumn coluna = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            dataGridProdutos.AutoGenerateColumns = false;
            dataGridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            coluna.CellTemplate = cell;
            coluna.Name = "Id_Produto";
            coluna.HeaderText = "ID";
            coluna.DataPropertyName = "Id_Produto";
            coluna.Width = 50;

            dataGridProdutos.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Nome";
            coluna.HeaderText = "Nome";
            coluna.DataPropertyName = "Nome";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridProdutos.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Preco_custo";
            coluna.HeaderText = "Preco_custo";
            coluna.DataPropertyName = "Preco_custo";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridProdutos.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "Preco_venda";
            coluna.HeaderText = "Preco_venda";
            coluna.DataPropertyName = "Preco_venda";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridProdutos.Columns.Add(coluna);

            coluna = new DataGridViewColumn();
            coluna.CellTemplate = cell;
            coluna.Name = "situacao";
            coluna.HeaderText = "situacao";
            coluna.DataPropertyName = "situacao";
            coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridProdutos.Columns.Add(coluna);

        }
      
        private void BAlterarConProd_Click(object sender, EventArgs e)
        {
            int id_produto = Convert.ToInt32(dataGridProdutos.CurrentRow.Cells[0].Value);
            string nome = dataGridProdutos.CurrentRow.Cells[1].Value.ToString();
            decimal preco_custo = Convert.ToDecimal(dataGridProdutos.CurrentRow.Cells[2].Value);
            decimal preco_venda = Convert.ToDecimal(dataGridProdutos.CurrentRow.Cells[3].Value);
            bool situacao = Convert.ToBoolean(dataGridProdutos.CurrentRow.Cells[4].Value);

            FormUtils.MudarFormulario(this, new TelaAlteracaoProdutos(id_produto, nome, preco_custo, preco_venda, situacao));

        }

        private void BPesquisarProd_Click(object sender, EventArgs e)
        {
            string texto = TbConProd.Text;

            p = new Produtos();

           

            List<Produtos> lista;

            lista = p.ConsultarTodos();

          


            if (string.IsNullOrEmpty(texto.Trim()))
            {

                dataGridProdutos.DataSource = lista;
            }
            return;

        }

        private void btnVolConProd_Click(object sender, EventArgs e)
        {
            FormUtils.MudarFormulario(this, new TelaBemVindo());
        }

        private void BExcluirConProd_Click(object sender, EventArgs e)
        {

            p = new Produtos();

            id_produto = Convert.ToInt32(dataGridProdutos.CurrentRow.Cells[0].Value);
            
            p.Excluir(id_produto);

            MessageBox.Show("Excluido com sucesso!!");
        }

       
    }
    }

