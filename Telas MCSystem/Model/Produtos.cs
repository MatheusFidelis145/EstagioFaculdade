using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telas_MCSystem.AcessoBanco.AcessoBancoDados;

namespace Telas_MCSystem.Model
{
    class Produtos
    {
        public int Id_Produto { get; set; }
        public string Nome { get; set; }

        public decimal Preco_custo { get; set; }

        public decimal Preco_venda { get; set; }

        public bool situacao { get; set; }

        public int Excluir(int id)//excluir produto
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Produto", id);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ExcluirProduto");
        }

        public int Inserir(string nome, decimal Preco_custo, decimal Preco_venda, bool situacao)//inserir Produto
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Nome", nome);
            acessoDados.AdicionarParametros("@Preco_custo", Preco_custo);
            acessoDados.AdicionarParametros("@Preco_venda", Preco_venda);
            acessoDados.AdicionarParametros("@situacao", situacao);

            
            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastrarProdutos");
        }

        public List<Produtos> ConsultarTodos()
        {

            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            DataTable dataTable =
                acessoDados.ExecutarConsulta(CommandType.StoredProcedure,
                "SelecionarProdutos");

            List<Produtos> listaproduto = new List<Produtos>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Produtos produtos = new Produtos();

                produtos.Id_Produto = Convert.ToInt32(dataRow["Id_Produto"]);
                produtos.Nome = Convert.ToString(dataRow["Nome"]);
                produtos.Preco_custo = Convert.ToDecimal(dataRow["Preco_custo"]);
                produtos.Preco_venda = Convert.ToDecimal(dataRow["Preco_venda"]);
                produtos.situacao = Convert.ToBoolean(dataRow["situacao"]);


                listaproduto.Add(produtos);
            }
            return listaproduto;
        }

        public int AlterarProduto(int id, string nome, decimal Preco_custo, decimal Preco_venda, bool situacao)//Alterar Produto
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Produto", id);
            acessoDados.AdicionarParametros("@Nome", nome);
            acessoDados.AdicionarParametros("@Preco_custo", Preco_custo);
            acessoDados.AdicionarParametros("@Preco_venda", Preco_venda);
            acessoDados.AdicionarParametros("@situacao", situacao);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarProduto");
        }




    }
}
