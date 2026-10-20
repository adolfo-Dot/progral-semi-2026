using System;
using System.Data;
using System.Data.SqlClient;

namespace proyecto_final
{
    public static class DatabaseManager
    {
        // Reemplaza esta cadena si la tuya es diferente
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BaseDatos.mdf;Integrated Security=True;Connect Timeout=30;";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }

        // Método genérico para ejecutar consultas (SELECT)
        public static DataTable EjecutarConsulta(string query, SqlParameter[] parametros = null)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parametros != null) cmd.Parameters.AddRange(parametros);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Método genérico para ejecutar comandos (INSERT, UPDATE, DELETE)
        public static int EjecutarComando(string query, SqlParameter[] parametros)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parametros != null) cmd.Parameters.AddRange(parametros);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}