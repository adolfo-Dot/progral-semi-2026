using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Form1 : Form
    {
        private int idSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCategoriasPrueba();
            CargarCategoriasCombo();
            RefrescarGrilla();
        }

        // Insertar una categoría por defecto si no existe ninguna
        private void CargarCategoriasPrueba()
        {
            string queryCheck = "SELECT COUNT(*) FROM Categorias";
            DataTable dt = DatabaseManager.EjecutarConsulta(queryCheck);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) == 0)
            {
                string queryInsert = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@nombre, @desc)";
                SqlParameter[] p = {
                    new SqlParameter("@nombre", "General"),
                    new SqlParameter("@desc", "Categoría inicial por defecto")
                };
                DatabaseManager.EjecutarComando(queryInsert, p);
            }
        }

        private void CargarCategoriasCombo()
        {
            string query = "SELECT IdCategoria, Nombre FROM Categorias";
            DataTable dt = DatabaseManager.EjecutarConsulta(query);
            cmbCategoria.DataSource = dt;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void RefrescarGrilla()
        {
            string query = "SELECT p.IdProducto, p.Codigo, p.Nombre, p.Precio, p.Stock, c.Nombre AS Categoria, p.IdCategoria " +
                           "FROM Productos p INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria";
            dgvProductos.DataSource = DatabaseManager.EjecutarConsulta(query);
        }

        // --- 1. BÚSQUEDA INTERACTIVA (Evento TextChanged de txtBuscar) ---
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            string query = "SELECT p.IdProducto, p.Codigo, p.Nombre, p.Precio, p.Stock, c.Nombre AS Categoria, p.IdCategoria " +
                           "FROM Productos p INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria " +
                           "WHERE p.Nombre LIKE @filtro OR p.Codigo LIKE @filtro";

            SqlParameter[] parametros = {
                new SqlParameter("@filtro", "%" + filtro + "%")
            };

            dgvProductos.DataSource = DatabaseManager.EjecutarConsulta(query, parametros);
        }

        // --- 2. VALIDACIÓN DE DATOS ---
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El código y el nombre son campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio decimal válido mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un número entero válido para el stock.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            return true;
        }

        // --- 3. OPERACIÓN GUARDAR (INSERTAR / ACTUALIZAR) ---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (idSeleccionado == 0)
            {
                // INSERTAR
                string query = "INSERT INTO Productos (Codigo, Nombre, Precio, Stock, IdCategoria) " +
                               "VALUES (@codigo, @nombre, @precio, @stock, @idCategoria)";

                SqlParameter[] parametros = {
                    new SqlParameter("@codigo", txtCodigo.Text.Trim()),
                    new SqlParameter("@nombre", txtNombre.Text.Trim()),
                    new SqlParameter("@precio", decimal.Parse(txtPrecio.Text)),
                    new SqlParameter("@stock", int.Parse(txtStock.Text)),
                    new SqlParameter("@idCategoria", cmbCategoria.SelectedValue ?? 1)
                };

                DatabaseManager.EjecutarComando(query, parametros);
                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // ACTUALIZAR (PUT/UPDATE)
                string query = "UPDATE Productos SET Codigo = @codigo, Nombre = @nombre, Precio = @precio, " +
                               "Stock = @stock, IdCategoria = @idCategoria WHERE IdProducto = @id";

                SqlParameter[] parametros = {
                    new SqlParameter("@codigo", txtCodigo.Text.Trim()),
                    new SqlParameter("@nombre", txtNombre.Text.Trim()),
                    new SqlParameter("@precio", decimal.Parse(txtPrecio.Text)),
                    new SqlParameter("@stock", int.Parse(txtStock.Text)),
                    new SqlParameter("@idCategoria", cmbCategoria.SelectedValue ?? 1),
                    new SqlParameter("@id", idSeleccionado)
                };

                DatabaseManager.EjecutarComando(query, parametros);
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Limpiar();
            RefrescarGrilla();
        }

        // --- 4. SELECCIONAR REGISTRO DE LA GRILLA ---
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                if (fila.Cells["IdProducto"].Value != null && fila.Cells["IdProducto"].Value != DBNull.Value)
                {
                    idSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                    txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                    txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                    txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                    txtStock.Text = fila.Cells["Stock"].Value.ToString();
                    cmbCategoria.SelectedValue = fila.Cells["IdCategoria"].Value;
                }
            }
        }

        // --- 5. OPERACIÓN ELIMINAR (DELETE) ---
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                DialogResult resp = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    string query = "DELETE FROM Productos WHERE IdProducto = @id";
                    SqlParameter[] parametros = { new SqlParameter("@id", idSeleccionado) };

                    DatabaseManager.EjecutarComando(query, parametros);
                    MessageBox.Show("Producto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                    RefrescarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            idSeleccionado = 0;
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtBuscar.Clear();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}