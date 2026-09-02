namespace conversor_de_areas
{
    partial class frmConversorArea
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
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(276, 64);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 22);
            this.txtcantidad.TabIndex = 0;
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(255, 197);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(121, 24);
            this.cboOrigen.TabIndex = 1;
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(234, 249);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(121, 24);
            this.cboDestino.TabIndex = 2;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(155, 94);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "button1";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(311, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "label1";
            // 
            // frmConversorArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.txtcantidad);
            this.Name = "frmConversorArea";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
    }
}

