using System;
using System.Collections.Generic;
using System.Data;
using Telas_MCSystem.AcessoBanco.AcessoBancoDados;

namespace Telas_MCSystem.Model
{
    class Telefone
    {
        public int Id_Telefone { get; set; }
        public int DDD { get; set; }
        public string Numero { get; set; }

        public List<Telefone> ConsultarTodos()
        {

            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            DataTable dataTable =
                acessoDados.ExecutarConsulta(CommandType.StoredProcedure,
                "SelecionarTelefoneCliente");

            List<Telefone> listatel = new List<Telefone>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Telefone tel = new Telefone();
                tel.Id_Telefone = Convert.ToInt32(dataRow["Id_Telefone"]);
                tel.DDD = Convert.ToInt32(dataRow["DDD"]);
                tel.Numero = Convert.ToString(dataRow["Numero"]);

                listatel.Add(tel);
            }
            return listatel;
        }

        public int AlterarTelefoneCliente(int Id_telefone, int DDD, string numero)//Alterar Telefone Cliente
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Id_telefone", Id_telefone);
            acessoDados.AdicionarParametros("@DDD", DDD);
            acessoDados.AdicionarParametros("@Numero", numero);


            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "AlterarTelefoneCliente");
        }
    }
}
