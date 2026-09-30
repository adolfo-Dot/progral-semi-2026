using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexion objCOnexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();
        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objCOnexion.obtenerDatos();
            objDt = objDs.Tables["alumnos"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idAlumno"] };
            grdAlumnos.DataSource = objDt.DefaultView;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                txtCodigoAlumno.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();
                lblRegistrosAlumnos.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void estadoControles(Boolean estado)
        {
            grbDatos.Enabled = estado;
            grbNavegacion.Enabled = !estado;
            btnEliminarAlumno.Enabled = !estado;
        }

        private void limpiarControles()
        {
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Agregar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarALumno.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar nuevo registro
                String[] alumnos = {
                     "", txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text,
                    txtTelefonoAlumno.Text
                };
                String respuesta = objCOnexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarAlumno.Text = "Agregar";
                    btnModificarALumno.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarALumno_Click(object sender, EventArgs e)
        {
            if (btnModificarALumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarALumno.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";
            }
            else if (btnModificarALumno.Text == "Cancelar")
            {//Cancelar la edición
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarALumno.Text = "Modificar";
            }
            else
            {//Guardar cambios de la modificación
                string idActual = objDt.Rows[posicion]["idAlumno"].ToString();
                String[] alumnos = {
                    idActual, txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text, txtTelefonoAlumno.Text
                };
                String respuesta = objCOnexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al modificar alumno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarAlumno.Text = "Agregar";
                    btnModificarALumno.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreAlumno.Text,
                 "Eliminando alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Obtenemos el ID real del registro actual seleccionado
                string idActual = objDt.Rows[posicion]["idAlumno"].ToString();
                String respuesta = objCOnexion.administrarDatosAlumnos(
                    new String[] { idActual, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarAlumnos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
                grdAlumnos.DataSource = objDv;
                seleccionarAlumno();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void seleccionarAlumno()
        {
            try
            {
                if (grdAlumnos.CurrentRow == null)
                {
                    return;
                }
                string id = grdAlumnos.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                // Evitamos mostrar mensajes molestos al hacer clics rápidos
            }
        }

        private void grdAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlumno();
        }
    }
}