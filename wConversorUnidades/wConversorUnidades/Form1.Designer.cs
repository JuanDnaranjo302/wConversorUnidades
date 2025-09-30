namespace wConversorUnidades
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboConversion = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(137, 90);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 0;
            // 
            // cboConversion
            // 
            this.cboConversion.FormattingEnabled = true;
            this.cboConversion.Location = new System.Drawing.Point(325, 105);
            this.cboConversion.Name = "cboConversion";
            this.cboConversion.Size = new System.Drawing.Size(121, 21);
            this.cboConversion.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(198, 240);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(271, 197);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(509, 160);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(120, 95);
            this.lstHistorial.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cboConversion);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cboConversion;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox lstHistorial;
    }
}

