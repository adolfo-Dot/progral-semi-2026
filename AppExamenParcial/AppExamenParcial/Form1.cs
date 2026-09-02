using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExamenParcial
{  
    public partial class frmImpuesto : Form
    {
        public frmImpuesto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
           
            if (!double.TryParse(txtMonto.Text, out double monto) || monto < 0)
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error de entrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double valorBase = 1000.01;
            double precioFijo = 3.0;
            double factorAdicional = 3.0;
            double totalPagar;


            if (monto <= valorBase)
            {
                totalPagar = precioFijo;
            }
            else
            {
                double diferencia = monto - valorBase;
                totalPagar = (diferencia / 1000.0) * factorAdicional + precioFijo;
            }

            lblResultado.Text = $"Monto a pagar: ${Math.Round(totalPagar, 2):F2}";






        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();

           
            lblResultado.Text = "Monto a pagar: $0.00";

           
            txtMonto.Focus();

        }

        private void lblResultado_click (object sender, EventArgs e)
        {
            lblResultado.Text = "Monto a pagar: $0.00";
        }
    }
}