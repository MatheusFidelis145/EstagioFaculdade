using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telas_MCSystem.AcessoBanco.AcessoBancoDados;

namespace Telas_MCSystem.Model
{
    public class Funcionario
    {
        public int id_funcionario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public decimal salario { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int Id_Endereco { get; set; }
        public string Nome_rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public int Id_Telefone { get; set; }
        public int DDD { get; set; }
        public string Telefone { get; set; }


        public int Inserir(string nome, string cpf, decimal salario, string email, string login, string senha)
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Nivel", 2);
            acessoDados.AdicionarParametros("@Nome", nome);
            acessoDados.AdicionarParametros("@Cpf", cpf);
            acessoDados.AdicionarParametros("@salario", salario);
            acessoDados.AdicionarParametros("@email", email);
            acessoDados.AdicionarParametros("@user_login", login);
            acessoDados.AdicionarParametros("@user_senha", senha);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroFuncionario");
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
        public int InserirEnderecoFuncionario(int id_endereco, int id_funcionario)//Inserir FuncionarioEndereco
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@id_endereco", id_endereco);
            acessoDados.AdicionarParametros("@id_funcionario", id_funcionario);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroFuncionarioEndereco");
        }

        public int InserirTelefoneFuncionario(int id_telefone, int id_funcionario)//Inserir Funcionario Telefone
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Telefone", id_telefone);
            acessoDados.AdicionarParametros("@Id_Funcionario", id_funcionario);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "CadastroFuncionarioTelefone");
        }

        public int Excluir(int id)
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id", id);
           

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ExcluirFuncionario");
        }

        public List<Funcionario> ConsultarTodos()
        {

            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            DataTable dataTable =
                acessoDados.ExecutarConsulta(CommandType.StoredProcedure,
                "SelecionarFuncionarioTodos");

            List<Funcionario> listafuncionario = new List<Funcionario>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.id_funcionario = Convert.ToInt32(dataRow["Id_Funcionario"]);
                funcionario.nome = Convert.ToString(dataRow["Nome"]);
                funcionario.cpf = Convert.ToString(dataRow["CPF"]);
                funcionario.salario = Convert.ToDecimal(dataRow["salario"]);
                funcionario.email = Convert.ToString(dataRow["email"]);
                funcionario.Id_Endereco = Convert.ToInt32(dataRow["Id_Endereco"]);
                funcionario.Nome_rua = Convert.ToString(dataRow["Nome_rua"]);
                funcionario.Bairro = Convert.ToString(dataRow["Bairro"]);
                funcionario.Numero = Convert.ToInt32(dataRow["Numero"]);
                funcionario.Cidade = Convert.ToString(dataRow["Cidade"]);
                funcionario.Id_Telefone = Convert.ToInt32(dataRow["Id_Telefone"]);
                funcionario.DDD = Convert.ToInt32(dataRow["DDD"]);
                funcionario.Telefone = Convert.ToString(dataRow["Numero"]);


                listafuncionario.Add(funcionario);
            }
            return listafuncionario;
        }

        public int AlterarFuncionario(int id, string nome, string cpf, decimal salario, string email, int id_endereco, string nome_rua, 
             string bairro, int numero, string cidade, int id_telefone, int ddd, string telefone )//Alterar Funcionario
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Funcionario", id);
            acessoDados.AdicionarParametros("@Nome", nome);
            acessoDados.AdicionarParametros("@cpf", cpf);
            acessoDados.AdicionarParametros("@salario", salario);
            acessoDados.AdicionarParametros("@email", email);
            acessoDados.AdicionarParametros("@Id_Endereco", id_endereco);
            acessoDados.AdicionarParametros("@Nome_rua", nome_rua);
            acessoDados.AdicionarParametros("@Bairro", bairro);
            acessoDados.AdicionarParametros("@Numero", numero);
            acessoDados.AdicionarParametros("@Cidade", cidade);
            acessoDados.AdicionarParametros("@email", email);
            acessoDados.AdicionarParametros("@Id_telefone", id_telefone);
            acessoDados.AdicionarParametros("@DDD", ddd);
            acessoDados.AdicionarParametros("@Telefone", telefone);


            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarFuncionario");
        }


    }
}


   
