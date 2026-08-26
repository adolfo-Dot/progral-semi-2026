using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class frmaguapotable
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
            this.btnlimpiar1 = new System.Windows.Forms.Button();
            this.btncalcular1 = new System.Windows.Forms.Button();
            this.txtLecturaanterior = new System.Windows.Forms.TextBox();
            this.txtLecturaactual = new System.Windows.Forms.TextBox();
            this.txtlecturacliente = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconsumoperiodo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlimpiar1
            // 
            this.btnlimpiar1.Location = new System.Drawing.Point(239, 286);
            this.btnlimpiar1.Name = "btnlimpiar1";
            this.btnlimpiar1.Size = new System.Drawing.Size(108, 47);
            this.btnlimpiar1.TabIndex = 22;
            this.btnlimpiar1.Text = "Limpiar";
            this.btnlimpiar1.UseVisualStyleBackColor = true;
            this.btnlimpiar1.Click += new System.EventHandler(this.btnlimpiar1_Click_1);
            // 
            // btncalcular1
            // 
            this.btncalcular1.Location = new System.Drawing.Point(53, 286);
            this.btncalcular1.Name = "btncalcular1";
            this.btncalcular1.Size = new System.Drawing.Size(108, 47);
            this.btncalcular1.TabIndex = 21;
            this.btncalcular1.Text = "Calcular";
            this.btncalcular1.UseVisualStyleBackColor = true;
            this.btncalcular1.Click += new System.EventHandler(this.btncalcular1_Click);
            // 
            // txtLecturaanterior
            // 
            this.txtLecturaanterior.Location = new System.Drawing.Point(267, 142);
            this.txtLecturaanterior.Name = "txtLecturaanterior";
            this.txtLecturaanterior.Size = new System.Drawing.Size(100, 22);
            this.txtLecturaanterior.TabIndex = 20;
            // 
            // txtLecturaactual
            // 
            this.txtLecturaactual.Location = new System.Drawing.Point(267, 194);
            this.txtLecturaactual.Name = "txtLecturaactual";
            this.txtLecturaactual.Size = new System.Drawing.Size(100, 22);
            this.txtLecturaactual.TabIndex = 19;
            this.txtLecturaactual.TextChanged += new System.EventHandler(this.txtLecturaactual_TextChanged);
            // 
            // txtlecturacliente
            // 
            this.txtlecturacliente.Location = new System.Drawing.Point(267, 243);
            this.txtlecturacliente.Name = "txtlecturacliente";
            this.txtlecturacliente.Size = new System.Drawing.Size(100, 22);
            this.txtlecturacliente.TabIndex = 18;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(48, 74);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(187, 29);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "Datos de lectura";
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(48, 21);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(672, 29);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "SISTEMA DE CÁLCULO DE CONSUMO DE AGUA POTABLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Lectura anterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lectura actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tipo de cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Consumo en el período";
            // 
            // txtconsumoperiodo
            // 
            this.txtconsumoperiodo.Location = new System.Drawing.Point(688, 142);
            this.txtconsumoperiodo.Name = "txtconsumoperiodo";
            this.txtconsumoperiodo.Size = new System.Drawing.Size(100, 22);
            this.txtconsumoperiodo.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 29);
            this.label11.TabIndex = 34;
            this.label11.Text = "Total a pagar ($)";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(633, 201);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 39;
            // 
            // frmaguapotable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtconsumoperiodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpiar1);
            this.Controls.Add(this.btncalcular1);
            this.Controls.Add(this.txtLecturaanterior);
            this.Controls.Add(this.txtLecturaactual);
            this.Controls.Add(this.txtlecturacliente);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Name = "frmaguapotable";
            this.Text = "frmaguapotable";
            this.Load += new System.EventHandler(this.frmaguapotable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

          private void btncalcular1_Click(object sender, EventArgs e)
        {

            // 1. Validar que las lecturas sean números válidos
            if (!double.TryParse(txtLecturaanterior.Text, out double anterior) ||
                !double.TryParse(txtLecturaactual.Text, out double actual))
            {
                MessageBox.Show("Ingrese valores numéricos válidos en las lecturas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Validar que la lectura actual no sea menor a la anterior
            if (actual < anterior)
            {
                MessageBox.Show("La lectura actual no puede ser menor a la anterior.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Cálculos
            double consumo = actual - anterior;
            double tarifaBase = 5.00; // Cargo fijo base
            double costoPorM3 = 0.50; // Tarifa por m3

            double totalPagar = tarifaBase + (consumo * costoPorM3);

            // 4. Mostrar resultados en pantalla
            txtconsumoperiodo.Text = consumo.ToString("N2");
            txtTotal.Text = totalPagar.ToString("C2");

            // 5. Imprimir resumen general (Requisito de la rúbrica)
            string resumen = $"=== RESUMEN DE AGUA POTABLE ===\n" +
                             $"Consumo Total: {consumo:N2} m³\n" +
                             $"Cargo Fijo: ${tarifaBase:N2}\n" +
                             $"Total a Pagar: {totalPagar:C2}";

            MessageBox.Show(resumen, "Resumen Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        #endregion

        private System.Windows.Forms.Button btnlimpiar1;
        private System.Windows.Forms.Button btncalcular1;
        private System.Windows.Forms.TextBox txtLecturaanterior;
        private System.Windows.Forms.TextBox txtLecturaactual;
        private System.Windows.Forms.TextBox txtlecturacliente;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconsumoperiodo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
    }
}