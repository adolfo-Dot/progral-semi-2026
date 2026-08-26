using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmaguapotable : Form
    {
        public frmaguapotable()
        {
            InitializeComponent();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void frmaguapotable_Load(object sender, EventArgs e)
        {

        }
            private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            if (!double.TryParse(txtLecturaanterior.Text, out double anterior) ||
                !double.TryParse(txtLecturaactual.Text, out double actual))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (actual < anterior)
            {
                MessageBox.Show("La lectura actual no puede ser menor a la lectura anterior.", "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double consumo = actual - anterior;
            double tarifaBase = 5.00; // Cargo fijo base
            double costoPorM3 = 0.50; // Tarifa por m3
            double totalPagar = 0;

            if (consumo <= 15)
            {
                totalPagar = tarifaBase + (consumo * costoPorM3);
            }
            else if (consumo <= 30)
            {
                totalPagar = tarifaBase + (15 * costoPorM3) + ((consumo - 15) * 0.75);
            }
            else
            {
                totalPagar = tarifaBase + (15 * costoPorM3) + (15 * 0.75) + ((consumo - 30) * 1.10);
            }

            txtconsumoperiodo.Text = consumo.ToString("N2");
            txtTotal.Text = totalPagar.ToString("C2");
        }



        private void txtLecturaactual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiar1_Click_1(object sender, EventArgs e)
        {
            txtLecturaanterior.Clear();
            txtLecturaactual.Clear();
            txtconsumoperiodo.Clear();
            txtTotal.Clear();
            txtLecturaanterior.Focus();
        }
    }
    }

