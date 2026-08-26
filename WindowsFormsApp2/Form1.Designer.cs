namespace WindowsFormsApp2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btndeducciones = new System.Windows.Forms.Button();
            this.btnaguapotable = new System.Windows.Forms.Button();
            this.btnmesesacum = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btndivisas = new System.Windows.Forms.Button();
            this.btnlonguitud = new System.Windows.Forms.Button();
            this.btntiempo = new System.Windows.Forms.Button();
            this.btnmasa = new System.Windows.Forms.Button();
            this.btnalmacenamiento = new System.Windows.Forms.Button();
            this.btnvolumen = new System.Windows.Forms.Button();
            this.btnarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(144, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(527, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "SISTEMAS DE CÁLCULOS Y CONVERSIONES";
            // 
            // btndeducciones
            // 
            this.btndeducciones.Location = new System.Drawing.Point(160, 105);
            this.btndeducciones.Name = "btndeducciones";
            this.btndeducciones.Size = new System.Drawing.Size(151, 40);
            this.btndeducciones.TabIndex = 1;
            this.btndeducciones.Text = "Deducciones";
            this.btndeducciones.UseVisualStyleBackColor = true;
            this.btndeducciones.Click += new System.EventHandler(this.btndeducciones_Click);
            // 
            // btnaguapotable
            // 
            this.btnaguapotable.Location = new System.Drawing.Point(397, 105);
            this.btnaguapotable.Name = "btnaguapotable";
            this.btnaguapotable.Size = new System.Drawing.Size(151, 40);
            this.btnaguapotable.TabIndex = 2;
            this.btnaguapotable.Text = "Agua potable";
            this.btnaguapotable.UseVisualStyleBackColor = true;
            this.btnaguapotable.Click += new System.EventHandler(this.btnaguapotable_Click);
            // 
            // btnmesesacum
            // 
            this.btnmesesacum.Location = new System.Drawing.Point(160, 171);
            this.btnmesesacum.Name = "btnmesesacum";
            this.btnmesesacum.Size = new System.Drawing.Size(151, 40);
            this.btnmesesacum.TabIndex = 3;
            this.btnmesesacum.Text = "Meses acumulados";
            this.btnmesesacum.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(144, 238);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(199, 29);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "CONVERSORES";
            // 
            // btndivisas
            // 
            this.btndivisas.Location = new System.Drawing.Point(160, 297);
            this.btndivisas.Name = "btndivisas";
            this.btndivisas.Size = new System.Drawing.Size(101, 40);
            this.btndivisas.TabIndex = 5;
            this.btndivisas.Text = "Divisas";
            this.btndivisas.UseVisualStyleBackColor = true;
            // 
            // btnlonguitud
            // 
            this.btnlonguitud.Location = new System.Drawing.Point(276, 297);
            this.btnlonguitud.Name = "btnlonguitud";
            this.btnlonguitud.Size = new System.Drawing.Size(101, 40);
            this.btnlonguitud.TabIndex = 6;
            this.btnlonguitud.Text = "Longuitud";
            this.btnlonguitud.UseVisualStyleBackColor = true;
            // 
            // btntiempo
            // 
            this.btntiempo.Location = new System.Drawing.Point(522, 297);
            this.btntiempo.Name = "btntiempo";
            this.btntiempo.Size = new System.Drawing.Size(101, 40);
            this.btntiempo.TabIndex = 7;
            this.btntiempo.Text = "Tiempo";
            this.btntiempo.UseVisualStyleBackColor = true;
            this.btntiempo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmasa
            // 
            this.btnmasa.Location = new System.Drawing.Point(397, 297);
            this.btnmasa.Name = "btnmasa";
            this.btnmasa.Size = new System.Drawing.Size(101, 40);
            this.btnmasa.TabIndex = 8;
            this.btnmasa.Text = "Masa";
            this.btnmasa.UseVisualStyleBackColor = true;
            // 
            // btnalmacenamiento
            // 
            this.btnalmacenamiento.Location = new System.Drawing.Point(160, 354);
            this.btnalmacenamiento.Name = "btnalmacenamiento";
            this.btnalmacenamiento.Size = new System.Drawing.Size(117, 40);
            this.btnalmacenamiento.TabIndex = 9;
            this.btnalmacenamiento.Text = "Almacenamiento";
            this.btnalmacenamiento.UseVisualStyleBackColor = true;
            // 
            // btnvolumen
            // 
            this.btnvolumen.Location = new System.Drawing.Point(300, 354);
            this.btnvolumen.Name = "btnvolumen";
            this.btnvolumen.Size = new System.Drawing.Size(117, 40);
            this.btnvolumen.TabIndex = 10;
            this.btnvolumen.Text = "Volumen";
            this.btnvolumen.UseVisualStyleBackColor = true;
            // 
            // btnarea
            // 
            this.btnarea.Location = new System.Drawing.Point(451, 354);
            this.btnarea.Name = "btnarea";
            this.btnarea.Size = new System.Drawing.Size(117, 40);
            this.btnarea.TabIndex = 11;
            this.btnarea.Text = "Área";
            this.btnarea.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnarea);
            this.Controls.Add(this.btnvolumen);
            this.Controls.Add(this.btnalmacenamiento);
            this.Controls.Add(this.btnmasa);
            this.Controls.Add(this.btntiempo);
            this.Controls.Add(this.btnlonguitud);
            this.Controls.Add(this.btndivisas);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnmesesacum);
            this.Controls.Add(this.btnaguapotable);
            this.Controls.Add(this.btndeducciones);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btndeducciones;
        private System.Windows.Forms.Button btnaguapotable;
        private System.Windows.Forms.Button btnmesesacum;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btndivisas;
        private System.Windows.Forms.Button btnlonguitud;
        private System.Windows.Forms.Button btntiempo;
        private System.Windows.Forms.Button btnmasa;
        private System.Windows.Forms.Button btnalmacenamiento;
        private System.Windows.Forms.Button btnvolumen;
        private System.Windows.Forms.Button btnarea;
    }
}

