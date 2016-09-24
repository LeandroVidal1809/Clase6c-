namespace EjerciciosControlDeUsuario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnHexa = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnDoble = new System.Windows.Forms.Button();
            this.btnentero = new System.Windows.Forms.Button();
            this.txtSistemas = new EjerciciosControlDeUsuario.texboxSistemasDecimales();
            this.txtSoloNumero = new EjerciciosControlDeUsuario.textBoxSoloNumeros();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solo Numeros";
            // 
            // btnHexa
            // 
            this.btnHexa.Location = new System.Drawing.Point(190, 122);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(75, 23);
            this.btnHexa.TabIndex = 4;
            this.btnHexa.Text = "Hexa";
            this.btnHexa.UseVisualStyleBackColor = true;
            this.btnHexa.Click += new System.EventHandler(this.btnHexa_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.Location = new System.Drawing.Point(109, 122);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(75, 23);
            this.btnOctal.TabIndex = 5;
            this.btnOctal.Text = "Octal";
            this.btnOctal.UseVisualStyleBackColor = true;
            this.btnOctal.Click += new System.EventHandler(this.btnOctal_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(28, 122);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 6;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnDoble
            // 
            this.btnDoble.Location = new System.Drawing.Point(67, 93);
            this.btnDoble.Name = "btnDoble";
            this.btnDoble.Size = new System.Drawing.Size(75, 23);
            this.btnDoble.TabIndex = 7;
            this.btnDoble.Text = "Doble";
            this.btnDoble.UseVisualStyleBackColor = true;
            this.btnDoble.Click += new System.EventHandler(this.btnDoble_Click);
            // 
            // btnentero
            // 
            this.btnentero.Location = new System.Drawing.Point(148, 93);
            this.btnentero.Name = "btnentero";
            this.btnentero.Size = new System.Drawing.Size(75, 23);
            this.btnentero.TabIndex = 8;
            this.btnentero.Text = "Entero";
            this.btnentero.UseVisualStyleBackColor = true;
            this.btnentero.Click += new System.EventHandler(this.btnentero_Click);
            // 
            // txtSistemas
            // 
            this.txtSistemas.Location = new System.Drawing.Point(84, 201);
            this.txtSistemas.Name = "txtSistemas";
            this.txtSistemas.Size = new System.Drawing.Size(100, 20);
            this.txtSistemas.TabIndex = 2;
            this.txtSistemas.tipodato = EjerciciosControlDeUsuario.eTipoDato.entero;
            // 
            // txtSoloNumero
            // 
            this.txtSoloNumero.Location = new System.Drawing.Point(109, 49);
            this.txtSoloNumero.Name = "txtSoloNumero";
            this.txtSoloNumero.Size = new System.Drawing.Size(100, 20);
            this.txtSoloNumero.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnentero);
            this.Controls.Add(this.btnDoble);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnHexa);
            this.Controls.Add(this.txtSistemas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoloNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private textBoxSoloNumeros txtSoloNumero;
        private System.Windows.Forms.Label label1;
        private texboxSistemasDecimales txtSistemas;
        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnDoble;
        private System.Windows.Forms.Button btnentero;
    }
}

