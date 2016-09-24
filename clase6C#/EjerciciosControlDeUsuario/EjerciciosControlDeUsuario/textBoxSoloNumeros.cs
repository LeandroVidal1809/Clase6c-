using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace EjerciciosControlDeUsuario
{
    class textBoxSoloNumeros : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;//cortamos el hilo
            }
        }

    }
}
