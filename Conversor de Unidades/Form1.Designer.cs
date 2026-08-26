namespace ConversorUnidades
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
            this.lblOpciones = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRespuestas = new System.Windows.Forms.Label();
            this.cdbOpciones = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cdbDe = new System.Windows.Forms.ComboBox();
            this.cdbA = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(102, 29);
            this.lblOpciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(97, 23);
            this.lblOpciones.TabIndex = 0;
            this.lblOpciones.Text = "Opciones:";
            this.lblOpciones.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(73, 88);
            this.lblDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(39, 23);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De:";
            this.lblDe.Click += new System.EventHandler(this.lblDe_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(287, 88);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(28, 23);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(73, 176);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(95, 23);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblRespuestas
            // 
            this.lblRespuestas.AutoSize = true;
            this.lblRespuestas.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestas.Location = new System.Drawing.Point(83, 249);
            this.lblRespuestas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRespuestas.Name = "lblRespuestas";
            this.lblRespuestas.Size = new System.Drawing.Size(117, 23);
            this.lblRespuestas.TabIndex = 4;
            this.lblRespuestas.Text = "Respuesta: ?";
            // 
            // cdbOpciones
            // 
            this.cdbOpciones.FormattingEnabled = true;
            this.cdbOpciones.Items.AddRange(new object[] {
            "Monedas",
            "Masa",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.cdbOpciones.Location = new System.Drawing.Point(213, 33);
            this.cdbOpciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cdbOpciones.Name = "cdbOpciones";
            this.cdbOpciones.Size = new System.Drawing.Size(157, 21);
            this.cdbOpciones.TabIndex = 5;
            // 
            // cdbDe
            // 
            this.cdbDe.FormattingEnabled = true;
            this.cdbDe.Location = new System.Drawing.Point(126, 88);
            this.cdbDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cdbDe.Name = "cdbDe";
            this.cdbDe.Size = new System.Drawing.Size(92, 21);
            this.cdbDe.TabIndex = 6;
            // 
            // cdbA
            // 
            this.cdbA.FormattingEnabled = true;
            this.cdbA.Location = new System.Drawing.Point(334, 92);
            this.cdbA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cdbA.Name = "cdbA";
            this.cdbA.Size = new System.Drawing.Size(92, 21);
            this.cdbA.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(361, 142);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 60);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(164, 182);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(76, 20);
            this.txt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cdbA);
            this.Controls.Add(this.cdbDe);
            this.Controls.Add(this.cdbOpciones);
            this.Controls.Add(this.lblRespuestas);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblOpciones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRespuestas;
        private System.Windows.Forms.ComboBox cdbOpciones;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cdbDe;
        private System.Windows.Forms.ComboBox cdbA;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button1;
    }
}

