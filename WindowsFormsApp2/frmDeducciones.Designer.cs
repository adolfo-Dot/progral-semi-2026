namespace WindowsFormsApp2
{
    partial class frmDeducciones
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtotros = new System.Windows.Forms.TextBox();
            this.txtimpuesto = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.btncalcular1 = new System.Windows.Forms.Button();
            this.btnlimpiar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(297, 41);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(154, 29);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Deducciones";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(218, 285);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(72, 29);
            this.lbl7.TabIndex = 2;
            this.lbl7.Text = "Otros";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(218, 236);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(124, 29);
            this.lbl6.TabIndex = 3;
            this.lbl6.Text = "Impuestos";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(218, 184);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(92, 29);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Seguro";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(218, 120);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(89, 29);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(423, 127);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 22);
            this.txtSalario.TabIndex = 6;
            // 
            // txtotros
            // 
            this.txtotros.Location = new System.Drawing.Point(423, 292);
            this.txtotros.Name = "txtotros";
            this.txtotros.Size = new System.Drawing.Size(100, 22);
            this.txtotros.TabIndex = 7;
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Location = new System.Drawing.Point(423, 243);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.Size = new System.Drawing.Size(100, 22);
            this.txtimpuesto.TabIndex = 8;
            this.txtimpuesto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(423, 191);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(100, 22);
            this.txtSeguro.TabIndex = 9;
            // 
            // btncalcular1
            // 
            this.btncalcular1.Location = new System.Drawing.Point(302, 372);
            this.btncalcular1.Name = "btncalcular1";
            this.btncalcular1.Size = new System.Drawing.Size(108, 47);
            this.btncalcular1.TabIndex = 10;
            this.btncalcular1.Text = "Calcular";
            this.btncalcular1.UseVisualStyleBackColor = true;
            this.btncalcular1.Click += new System.EventHandler(this.btncalcular1_Click);
            // 
            // btnlimpiar1
            // 
            this.btnlimpiar1.Location = new System.Drawing.Point(480, 372);
            this.btnlimpiar1.Name = "btnlimpiar1";
            this.btnlimpiar1.Size = new System.Drawing.Size(108, 47);
            this.btnlimpiar1.TabIndex = 11;
            this.btnlimpiar1.Text = "Limpiar";
            this.btnlimpiar1.UseVisualStyleBackColor = true;
            this.btnlimpiar1.Click += new System.EventHandler(this.btnlimpiar1_Click);
            // 
            // frmDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiar1);
            this.Controls.Add(this.btncalcular1);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtimpuesto);
            this.Controls.Add(this.txtotros);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl3);
            this.Name = "frmDeducciones";
            this.Load += new System.EventHandler(this.frmDeducciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtotros;
        private System.Windows.Forms.TextBox txtimpuesto;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Button btncalcular1;
        private System.Windows.Forms.Button btnlimpiar1;
    }
}