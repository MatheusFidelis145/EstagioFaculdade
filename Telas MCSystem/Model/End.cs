using System;
using System.Collections.Generic;
using System.Data;
using Telas_MCSystem.AcessoBanco.AcessoBancoDados;

namespace Telas_MCSystem.Model
{
    public class End
    {
        public int Id_Endereco { get; set; }
        public string Nome_rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }

        public List<End> ConsultarTodos()
        {

            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();


            DataTable dataTable =
                acessoDados.ExecutarConsulta(CommandType.StoredProcedure,
                "SelecionarEnderecoCliente");

            List<End> listaend = new List<End>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                End end = new End();
                end.Id_Endereco = Convert.ToInt32(dataRow["Id_Endereco"]);
                end.Nome_rua = Convert.ToString(dataRow["Nome_rua"]);
                end.Bairro = Convert.ToString(dataRow["Bairro"]);
                end.Numero = Convert.ToInt32(dataRow["Numero"]);
                end.Cidade = Convert.ToString(dataRow["Cidade"]);

                listaend.Add(end);
            }
            return listaend;
        }
        public int AlterarEnderecoCliente(int id, string nome_rua, string bairro, int numero, string cidade)//Alterar Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Endereco", id);
            acessoDados.AdicionarParametros("@Nome_Rua", nome_rua);
            acessoDados.AdicionarParametros("@Bairro", bairro);
            acessoDados.AdicionarParametros("@Numero", numero);
            acessoDados.AdicionarParametros("@Cidade", cidade);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarEnderecoCliente");
        }
        public int AlterarEnderecoFornecedor(int id, string nome_rua, string bairro, int numero, string cidade)//Alterar Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_Endereco", id);
            acessoDados.AdicionarParametros("@Nome_Rua", nome_rua);
            acessoDados.AdicionarParametros("@Bairro", bairro);
            acessoDados.AdicionarParametros("@Numero", numero);
            acessoDados.AdicionarParametros("@Cidade", cidade);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarEnderecoFornecedor");
        }

    }
}
