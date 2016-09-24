using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosControlDeUsuario
{
    public enum eTipoDato{entero,doble,binario,octal,hexadecimal,ninguno}
    public class texboxSistemasDecimales:TextBox
    {
        public eTipoDato tipodato{get; set;}
            
        public texboxSistemasDecimales ()
        {
            this.tipodato=eTipoDato.ninguno;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch(this.tipodato)
                {
                case eTipoDato.binario:
                        {
                            if(e.KeyChar!='0' && e.KeyChar!='1' && e.KeyChar!=(char)Keys.Back)
                                e.Handled=true;
                            break;
                        }
                case eTipoDato.octal:
                        {
                            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
                                e.Handled = true;
                            break;
                        }
                case eTipoDato.hexadecimal:
                        {
                            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back || e.KeyChar >= 'A' && e.KeyChar <= 'F')
                            {}
                            else
                                e.Handled = true;
                            break;
                        }
                case eTipoDato.entero:
                        {
                            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back )
                            {}
                            else
                            e.Handled = true;
                            break;
                        }
                case eTipoDato.doble:
                        {
                            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back || e.KeyChar == ',')
                            { }
                            else
                                e.Handled = true;
                            break;
                        }

                
                }
        }
    }
}
