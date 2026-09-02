using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_de_areas
{
    public partial class frmConversorArea : Form
    {
        private class UnidadArea
        {
            public string Nombre { get; set; }
            public double FactorMetrosCuadrados { get; set; }

            public override string ToString()
            {
                return Nombre;
            }
        }


        public frmConversorArea()
        {
            InitializeComponent();
            CargarUnidades();
        }

        private void CargarUnidades()
        { 
            var unidades = new List<UnidadArea>
            {
                new UnidadArea { Nombre = "Pie Cuadrado", FactorMetrosCuadrados = 0.092903 },
                new UnidadArea { Nombre = "Vara Cuadrada", FactorMetrosCuadrados = 0.698896 },
                new UnidadArea { Nombre = "Yarda Cuadrada", FactorMetrosCuadrados = 0.836127 },
                new UnidadArea { Nombre = "Metro Cuadrado", FactorMetrosCuadrados = 1.0 },
                new UnidadArea { Nombre = "Tareas", FactorMetrosCuadrados = 628.86 },
                new UnidadArea { Nombre = "Manzana", FactorMetrosCuadrados = 7000.0 },
                new UnidadArea { Nombre = "Hectárea", FactorMetrosCuadrados = 10000.0 }
            };

            cboOrigen.DataSource = new List<UnidadArea>(unidades);
            cboDestino.DataSource = new List<UnidadArea>(unidades);

            cboOrigen.SelectedIndex = 0;
            cboDestino.SelectedIndex = 3; // Metro cuadrado por defecto

            private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCantidad.Text, out double cantidad) || cantidad < 0)
            {
                MessageBox.Show("Ingrese una cantidad numérica válida.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var unidadOrigen = (UnidadArea)cboOrigen.SelectedItem;
            var unidadDestino = (UnidadArea)cboDestino.SelectedItem;

            // Proceso de conversión usando el metro cuadrado como pivote
            double metrosCuadrados = cantidad * unidadOrigen.FactorMetrosCuadrados;
            double resultado = metrosCuadrados / unidadDestino.FactorMetrosCuadrados;

            lblResultado.Text = $"{cantidad} {unidadOrigen.Nombre} = {resultado:N4} {unidadDestino.Nombre}";
        }
    }
}

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

