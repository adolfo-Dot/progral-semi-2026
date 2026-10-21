using PARCIAL_2;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PARCIAL_2
{
    public partial class frm_usuario : Form
    {
        private Conexion_base_datos bd = new Conexion_base_datos();
        private int posicion = 0;

        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            bd.crearDs();
            if (bd.ds.Tables["usuarios_USSS080626"] != null && bd.ds.Tables["usuarios_USSS080626"].Rows.Count > 0)
            {
                MostrarRegistro(posicion);
            }
            else
            {
                Limpiar();
            }
        }

        private void MostrarRegistro(int index)
        {
            DataTable dt = bd.ds.Tables["usuarios_USSS080626"];
            if (dt != null && dt.Rows.Count > 0 && index >= 0 && index < dt.Rows.Count)
            {
                DataRow row = dt.Rows[index];
                txtIdUsuario.Text = row["idUsuario"].ToString();
                txtUsuario.Text = row["usuario"].ToString();
                txtClave.Text = row["clave"].ToString();
                txtConfirmarClave.Text = row["clave"].ToString();
                txtNombre.Text = row["nombre"].ToString();
                txtDireccion.Text = row["direccion"].ToString();
                txtTelefono.Text = row["telefono"].ToString();
            }
        }

        private bool ValidarFormulario()
        {
            string usr = txtUsuario.Text.Trim();
            string pass = txtClave.Text;
            string confirmPass = txtConfirmarClave.Text;

            if (usr.Length < 6 || usr.Length > 16)
            {
                MessageBox.Show("El usuario debe tener entre 6 y 16 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarClave.Focus();
                return false;
            }

            bool tieneLetra = pass.Any(char.IsLetter);
            bool tieneNumero = pass.Any(char.IsDigit);

            if (!tieneLetra || !tieneNumero)
            {
                MessageBox.Show("La contraseña debe incluir al menos una letra y un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

            string sql = $"INSERT INTO usuarios_USSS080626 (usuario, clave, nombre, direccion, telefono) " +
                         $"VALUES ('{txtUsuario.Text.Trim()}', '{txtClave.Text}', '{txtNombre.Text.Trim()}', '{txtDireccion.Text.Trim()}', '{txtTelefono.Text.Trim()}')";

            if (bd.mantenimiento_usuarios_USSS080626(sql) > 0)
            {
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // 1. Validar que exista un ID cargado
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show("Cargue un usuario primero para poder modificarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ejecutar validaciones de contraseña, usuario y nombre
            if (!ValidarFormulario()) return;

            // 3. Convertir el ID a entero para evitar fallos de formato en SQL
            if (!int.TryParse(txtIdUsuario.Text, out int idUsuario))
            {
                MessageBox.Show("El ID de usuario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Construir la consulta UPDATE limpia
            string sql = $"UPDATE usuarios_USSS080626 SET " +
                         $"usuario = '{txtUsuario.Text.Trim()}', " +
                         $"clave = '{txtClave.Text}', " +
                         $"nombre = '{txtNombre.Text.Trim()}', " +
                         $"direccion = '{txtDireccion.Text.Trim()}', " +
                         $"telefono = '{txtTelefono.Text.Trim()}' " +
                         $"WHERE idUsuario = {idUsuario}";

            // 5. Ejecutar comando en la base de datos
            int filasAfectadas = bd.mantenimiento_usuarios_USSS080626(sql);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("¡Usuario actualizado con éxito en la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6. Recargar el DataSet obligando a leer desde SQL Server
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro en la base de datos con ese ID.", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text)) return;

            if (MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM usuarios_USSS080626 WHERE idUsuario = {txtIdUsuario.Text}";
                if (bd.mantenimiento_usuarios_USSS080626(sql) > 0)
                {
                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    posicion = 0;
                    CargarDatos();
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarRegistro(posicion);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (bd.ds.Tables["usuarios_USSS080626"] != null && posicion < bd.ds.Tables["usuarios_USSS080626"].Rows.Count - 1)
            {
                posicion++;
                MostrarRegistro(posicion);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtIdUsuario.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            txtConfirmarClave.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtUsuario.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}