using System.Windows.Forms;

namespace Telas_MCSystem.Utils
{
    public class FormUtils
    {
        public static void MudarFormulario(Form atual, Form proximo)
        {
            atual.Hide();
            proximo.ShowDialog();
            atual.Close();
        }
    }
}
