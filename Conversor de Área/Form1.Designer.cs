namespace Conversor_de_Área
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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(82, 167);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(100, 39);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click_1);
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(281, 166);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(121, 24);
            this.cboDestino.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(278, 221);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(87, 16);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado: ---";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(82, 123);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(281, 121);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(121, 24);
            this.cboOrigen.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(82, 221);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 39);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conversor de Área";
            // 
            // frmConversorArea
            // 
            this.ClientSize = new System.Drawing.Size(505, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.btnConvertir);
            this.Name = "frmConversorArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
    }
}

