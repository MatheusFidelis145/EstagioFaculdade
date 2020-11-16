using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telas_MCSystem.AcessoBanco.AcessoBancoDados;

namespace Telas_MCSystem.Model
{
    class Fornecedor
    {
        public int id_Fornecedor { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public decimal salario { get; set; }
        public string email { get; set; }
        public int Id_Endereco { get; set; }
        public string Nome_rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public int Id_Telefone { get; set; }
        public int DDD { get; set; }
        public string Telefone { get; set; }

        public int Excluir(int id)//inserir Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Fornecedor", id);


            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ExcluirCliente");
        }
        public int Inserir(string nome, bool desconto, string email, string CNPJ)//inserir Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Nome", nome);
            acessoDados.AdicionarParametros("@Desconto", desconto);
            acessoDados.AdicionarParametros("@email", email);
            acessoDados.AdicionarParametros("@CNPJ", CNPJ);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroFornecedor");
        }
        public int InserirTelefone(int DDD, string Numero)//Inserir Telefone
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@DDD", DDD);
            acessoDados.AdicionarParametros("@Numero", Numero);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroTelefone");
        }
        public int InserirEndereco(string rua, string bairro, int numero, string cidade) //Inserir Endereço
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Nome_rua", rua);
            acessoDados.AdicionarParametros("@Bairro", bairro);
            acessoDados.AdicionarParametros("@Numero", numero);
            acessoDados.AdicionarParametros("@Cidade", cidade);


            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroEndereco");
        }
        public int InserirEnderecoFornecedor(int Fornecedor_Endereco)//Inserir ClienteEndereco
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Fornecedor_Endereco", Fornecedor_Endereco);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroFornecedorEndereco");
        }
        public int InserirTelefoneFornecedor(int Id_Fornecdor)//Inserir ClienteTelefone
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Fornecedor_Telefone", Id_Fornecdor);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroClienteTelefone");
        }
        public List<Fornecedor> ConsultarTodos()
        {

            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            DataTable dataTable =
                acessoDados.ExecutarConsulta(CommandType.StoredProcedure,
                "SelecionarFornecedorTodos");

            List<Fornecedor> listafornecedor = new List<Fornecedor>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.id_Fornecedor = Convert.ToInt32(dataRow["Id_Cliente"]);
                fornecedor.Nome = Convert.ToString(dataRow["Nome"]);
                fornecedor.CNPJ = Convert.ToString(dataRow["CPF"]);
                fornecedor.salario = Convert.ToDecimal(dataRow["salario"]);
                fornecedor.email = Convert.ToString(dataRow["email"]);
                fornecedor.Id_Endereco = Convert.ToInt32(dataRow["Id_Endereco"]);
                fornecedor.Nome_rua = Convert.ToString(dataRow["Nome_rua"]);
                fornecedor.Bairro = Convert.ToString(dataRow["Bairro"]);
                fornecedor.Numero = Convert.ToInt32(dataRow["Numero"]);
                fornecedor.Cidade = Convert.ToString(dataRow["Cidade"]);
                fornecedor.Id_Telefone = Convert.ToInt32(dataRow["Id_Telefone"]);
                fornecedor.DDD = Convert.ToInt32(dataRow["DDD"]);
                fornecedor.Telefone = Convert.ToString(dataRow["Numero"]);


                listafornecedor.Add(fornecedor);
            }
            return listafornecedor;
        }
        public int AlterarFornecedor(int id, string nome, bool desconto, string email, string CNPJ)//Alterar Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_fornecedor", id);
            acessoDados.AdicionarParametros("@Nome", nome);
            acessoDados.AdicionarParametros("@Desconto", desconto);
            acessoDados.AdicionarParametros("@email", email);
            acessoDados.AdicionarParametros("@CNPJ", CNPJ);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarFornecedor");
        }
    }
}