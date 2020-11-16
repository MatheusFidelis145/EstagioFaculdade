using System;
using System.Collections.Generic;
using System.Data;
using Telas_MCSystem.AcessoBanco.AcessoBancoDados;

namespace Telas_MCSystem.Model
{

    public class Cliente
    {

        public int Id_Cliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
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



        public int Excluir(int id )//inserir Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Cliente", id);
          

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ExcluirCliente");
        }

        public int Inserir(string nome, string cpf, decimal salario, string email)//inserir Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Nome", nome);
            acessoDados.AdicionarParametros("@cpf", cpf);
            acessoDados.AdicionarParametros("@salario", salario);
            acessoDados.AdicionarParametros("@email", email);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroCliente");
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


        public int InserirEnderecoCliente(int id_endereco, int Cliente_Endereco)//Inserir ClienteEndereco
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Endereco", id_endereco);
            acessoDados.AdicionarParametros("@Cliente_Endereco", Cliente_Endereco);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroClienteEndereco");
        }

        public int InserirTelefoneCliente(int id_telefone ,int Cliente_Telefone)//Inserir ClienteTelefone
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Telefone", id_telefone);
            acessoDados.AdicionarParametros("@Cliente_Telefone", Cliente_Telefone);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroClienteTelefone");
        }

        public List<Cliente> ConsultarTodos()
        {

            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            DataTable dataTable =
                acessoDados.ExecutarConsulta(CommandType.StoredProcedure,
                "SelecionarClienteTodos");

            List<Cliente> listacliente = new List<Cliente>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.Id_Cliente = Convert.ToInt32(dataRow["Id_Cliente"]);
                cliente.Nome = Convert.ToString(dataRow["Nome"]);
                cliente.CPF = Convert.ToString(dataRow["CPF"]);
                cliente.salario = Convert.ToDecimal(dataRow["salario"]);
                cliente.email = Convert.ToString(dataRow["email"]);
                cliente.Id_Endereco = Convert.ToInt32(dataRow["Id_Endereco"]);
                cliente.Nome_rua = Convert.ToString(dataRow["Nome_rua"]);
                cliente.Bairro = Convert.ToString(dataRow["Bairro"]);
                cliente.Numero = Convert.ToInt32(dataRow["Numero"]);
                cliente.Cidade = Convert.ToString(dataRow["Cidade"]);
                cliente.Id_Telefone = Convert.ToInt32(dataRow["Id_Telefone"]);
                cliente.DDD = Convert.ToInt32(dataRow["DDD"]);
                cliente.Telefone = Convert.ToString(dataRow["Numero"]);


                listacliente.Add(cliente);
            }
            return listacliente;
        }


        public int AlterarCliente(int id, string nome, string cpf, decimal salario, string email)//Alterar Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_CLiente", id);
            acessoDados.AdicionarParametros("@Nome", nome);
            acessoDados.AdicionarParametros("@cpf", cpf);
            acessoDados.AdicionarParametros("@salario", salario);
            acessoDados.AdicionarParametros("@email", email);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarCliente");
        }


    }
}
