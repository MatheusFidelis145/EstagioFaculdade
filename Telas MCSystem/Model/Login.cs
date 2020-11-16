using System;
using System.Data;
using Telas_MCSystem.AcessoBanco.AcessoBancoDados;

namespace Telas_MCSystem.Model
{
    public class Login
    {
        public string login { get; set; }
        public string Senha { get; set; }

        readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int LoginPorNivel(string l, string s)
        {
            acessoDados.LimparParametros(); // Por ser Global, o ideal é limpar todos os parâmetros antes.
            acessoDados.AdicionarParametros("@uname", l);
            acessoDados.AdicionarParametros("@pass", s);
            return Convert.ToInt32(acessoDados.ExecutarConsultaScalar(CommandType.Text, "select dbo.usp_Login_Nivel(@uname,@pass)"));
        }
    }
}
