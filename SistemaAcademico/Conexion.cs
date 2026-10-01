using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAcademico
{
    public class Conexion
    {
        // Objetos para manejar la conexión, comandos y adaptador de datos
        public SqlConnection objConexion = new SqlConnection();
        public SqlCommand objComando = new SqlCommand();
        public SqlDataAdapter objAdaptador = new SqlDataAdapter();
        private DataSet objDs = new DataSet();

        public Conexion()
        {
            // Cadena de conexión hacia LocalDB
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open();
        }

        // Método para cargar las tablas principales al DataSet
        public DataSet obtenerDatos()
        {
            objDs.Clear();
            objComando.Connection = objConexion;
            objAdaptador.SelectCommand = objComando;

            // Cargar tabla alumnos
            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");

            // Cargar tabla materias
            objComando.CommandText = "SELECT * FROM materias";
            objAdaptador.Fill(objDs, "materias");

            return objDs;
        }

        // Método CRUD para Alumnos
        public string administrarDatosAlumnos(string[] datos, string accion)
        {
            string sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo, nombre, direccion, telefono, email) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "', email='" + datos[5] + "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }

        // Método genérico para ejecutar sentencias SQL de acción
        public string ejecutarSQL(string sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}