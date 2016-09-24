namespace ControlDeUsuario._03
{
    partial class frmPropiedades
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxElegirLetra1 = new MisControles.TextBoxElegirLetra();
            this.textBoxMayusculaMinuscula1 = new MisControles.TextBoxMayusculaMinuscula();
            this.SuspendLayout();
            // 
            // textBoxElegirLetra1
            // 
            this.textBoxElegirLetra1.Location = new System.Drawing.Point(45, 109);
            this.textBoxElegirLetra1.Name = "textBoxElegirLetra1";
            this.textBoxElegirLetra1.QueLetra = '*';
            this.textBoxElegirLetra1.Size = new System.Drawing.Size(190, 20);
            this.textBoxElegirLetra1.TabIndex = 0;
            // 
            // textBoxMayusculaMinuscula1
            // 
            this.textBoxMayusculaMinuscula1.Location = new System.Drawing.Point(145, 38);
            this.textBoxMayusculaMinuscula1.Name = "textBoxMayusculaMinuscula1";
            this.textBoxMayusculaMinuscula1.Size = new System.Drawing.Size(100, 20);
            this.textBoxMayusculaMinuscula1.TabIndex = 1;
            this.textBoxMayusculaMinuscula1.TipoDeTexto = MisControles.TipoTexto.Ninguno;
            // 
            // frmPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxMayusculaMinuscula1);
            this.Controls.Add(this.textBoxElegirLetra1);
            this.Name = "frmPropiedades";
            this.Text = "Propiedades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MisControles.TextBoxElegirLetra textBoxElegirLetra1;
        private MisControles.TextBoxMayusculaMinuscula textBoxMayusculaMinuscula1;
    }
}

