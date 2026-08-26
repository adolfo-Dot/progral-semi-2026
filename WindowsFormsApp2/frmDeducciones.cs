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
    public partial class frmDeducciones : Form
    {
        public frmDeducciones()
        {
            InitializeComponent();
        }

        private void frmDeducciones_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular1_Click(object sender, EventArgs e)
        {
            decimal salario = 0;
            decimal seguro = 0;
            decimal impuesto = 0;
            decimal otros = 0;

            decimal.TryParse(txtSalario.Text, out salario);
            decimal.TryParse(txtSeguro.Text, out seguro);
            decimal.TryParse(txtimpuesto.Text, out impuesto);
            decimal.TryParse(txtotros.Text, out otros);

            decimal totalDeducciones = seguro + impuesto + otros;
            decimal salarioNeto = salario - totalDeducciones;

            MessageBox.Show(
                "Total de deducciones: $" + totalDeducciones.ToString("N2") +
                "\nSalario neto: $" + salarioNeto.ToString("N2"),
                "Resultado"
            );


        }

        private void btnlimpiar1_Click(object sender, EventArgs e)
        {
            txtSalario.Clear();
            txtSeguro.Clear();
            txtimpuesto.Clear();
            txtotros.Clear();

            txtSalario.Focus();

        }
    }
}
