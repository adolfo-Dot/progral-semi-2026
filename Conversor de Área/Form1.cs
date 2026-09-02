using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Área
{
    public partial class frmConversorArea : Form
    {
        // Clase interna para definir las unidades de medida y sus equivalencias
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

        // Carga las 7 opciones requeridas por el ejercicio
        private void CargarUnidades()
        {
            var listaUnidades = new List<UnidadArea>
            {
                new UnidadArea { Nombre = "a. Pie Cuadrado", FactorMetrosCuadrados = 0.092903 },
                new UnidadArea { Nombre = "b. Vara Cuadrada", FactorMetrosCuadrados = 0.698896 },
                new UnidadArea { Nombre = "c. Yarda Cuadrada", FactorMetrosCuadrados = 0.836127 },
                new UnidadArea { Nombre = "d. Metro Cuadrado", FactorMetrosCuadrados = 1.0 },
                new UnidadArea { Nombre = "e. Tareas", FactorMetrosCuadrados = 628.86 },
                new UnidadArea { Nombre = "f. Manzana", FactorMetrosCuadrados = 7000.0 },
                new UnidadArea { Nombre = "g. Hectárea", FactorMetrosCuadrados = 10000.0 }
            };

            
            cboOrigen.DataSource = new List<UnidadArea>(listaUnidades);
            cboOrigen.DisplayMember = "Nombre";

           
            cboDestino.DataSource = new List<UnidadArea>(listaUnidades);
            cboDestino.DisplayMember = "Nombre";

            
            cboOrigen.SelectedIndex = 0; 
            cboDestino.SelectedIndex = 3; 
        }


        private void btnConvertir_Click_1(object sender, EventArgs e)
        {

            // Validar que se haya ingresado un valor numérico
            if (!double.TryParse(txtCantidad.Text, out double cantidad) || cantidad < 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad numérica válida y mayor o igual a cero.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            // Obtener las unidades seleccionadas
            var unidadOrigen = (UnidadArea)cboOrigen.SelectedItem;
            var unidadDestino = (UnidadArea)cboDestino.SelectedItem;

            // Proceso de conversión:
            // 1. Convertir la cantidad a metros cuadrados (unidad base)
            // 2. Convertir de metros cuadrados a la unidad destino
            double metrosCuadrados = cantidad * unidadOrigen.FactorMetrosCuadrados;
            double resultado = metrosCuadrados / unidadDestino.FactorMetrosCuadrados;

            // Mostrar resultado en pantalla
            lblResultado.Text = $"{cantidad} {unidadOrigen.Nombre} = {resultado:N4} {unidadDestino.Nombre}";



        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {


            txtCantidad.Clear();
            if (cboOrigen.Items.Count > 0) cboOrigen.SelectedIndex = 0;
            if (cboDestino.Items.Count > 0) cboDestino.SelectedIndex = 3;
            lblResultado.Text = "Resultado: ---";
            txtCantidad.Focus();

        }
    }

}
