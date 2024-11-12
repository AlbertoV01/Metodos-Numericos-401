using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Métodos_Numéricos_401
{
    public static class ValidarTextboxs
    {
       public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (V.KeyChar.ToString().Equals("."))
            {
                V.Handled = false;
            }
            else if(V.KeyChar.ToString().Equals("-"))
            {
                V.Handled |= false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("Ingrese sólo números", "wow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static Boolean CamposVacios(TextBox textBox)

        {
            Boolean si = false;
            ErrorProvider error = new ErrorProvider();
            if (textBox.Text == "")
            {
                si = true;
            }
            else
            {
                error.Clear();
            }
          
            return si;
        }

    }
}
