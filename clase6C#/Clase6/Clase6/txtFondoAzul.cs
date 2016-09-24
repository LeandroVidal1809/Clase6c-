using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // para formularios
using System.Drawing; //para colores
namespace Clase6
{
   public class txtFondoAzul : TextBox
    {
         public txtFondoAzul()
           {
            base.BackColor= Color.Turquoise;
           }
           
       public Color ColorDeFondo
       {
 
           get { return BackColor; }
           set { BackColor = value; }
       }

       protected override void OnKeyPress(KeyPressEventArgs e)
       {
           if ((e.KeyChar < '0' || e.KeyChar > '9' )&& e.KeyChar != ((char)Keys.Back))
               e.Handled = true; //con handled no permito escirbir
       }
     }



}
