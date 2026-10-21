using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PARCIAL_2
{
    public class Conexion_base_datos
    {
        public SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BaseDatos.mdf;Integrated Security=True");
        public DataSet ds = new DataSet();

        // Método crearDs para la tabla usuarios_USSS080626
        public void crearDs()
        {
            ds.Tables.Clear();
            SqlDataAdapter adapterUsuarios = new SqlDataAdapter("SELECT * FROM usuarios_USSS080626", conexion);
            adapterUsuarios.Fill(ds, "usuarios_USSS080626");
        }

        // Método procesar para INSERT, UPDATE, DELETE
        public int procesar(string sql)
        {
            SqlCommand comando = new SqlCommand(sql, conexion);
            int filasAfectadas = 0;
            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
            return filasAfectadas;
        }

        // Método de consulta
        public DataTable consultar(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexion);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // Método de mantenimiento requerido
        public int mantenimiento_usuarios_USSS080626(string sql)
        {
            return procesar(sql);
        }
    }
}