using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosControlDeUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDoble_Click(object sender, EventArgs e)
        {
            this.txtSistemas.tipodato = eTipoDato.doble;
            this.txtSistemas.Focus();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            this.txtSistemas.tipodato = eTipoDato.binario;
            this.txtSistemas.Focus();
        }

        private void btnentero_Click(object sender, EventArgs e)
        {
            this.txtSistemas.tipodato = eTipoDato.entero;
            this.txtSistemas.Focus();
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            this.txtSistemas.tipodato = eTipoDato.octal;
            this.txtSistemas.Focus();
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            this.txtSistemas.tipodato = eTipoDato.hexadecimal;
            this.txtSistemas.Focus();
        }
    }
}
