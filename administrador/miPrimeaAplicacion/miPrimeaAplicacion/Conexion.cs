using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Libreria para usar comandos de BD
using System.Data.SqlClient; // Libreria para trabajar con SQL Server

namespace miPrimeaAplicacion {
    internal class Conexion {
        // Definir los miembros de la clase, atributos y metodos.
        public SqlConnection objConexion = new SqlConnection(); 
        public SqlCommand objComando = new SqlCommand(); 
        public SqlDataAdapter objAdaptador = new SqlDataAdapter(); 
        DataSet objDs = new DataSet(); 

        public Conexion() { // Constructor
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // Abrir la conexion a la BD
        }

        public DataSet obtenerDatos() {
            objDs.Clear(); // Limpiar el DataSet
            objComando.Connection = objConexion; 
            objAdaptador.SelectCommand = objComando; 
            
            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");
            
            objComando.CommandText = "SELECT * FROM materias";
            objAdaptador.Fill(objDs, "materias");
            
            return objDs;
        }

        // ---> ESTA ES LA FUNCIÓN QUE TE FALTABA PARA ALUMNOS <---
        public string administrarDatosAlumnos(String[] datos, String accion) {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono) VALUES ('"+ datos[1] +"', '"+ datos[2] +"', '"+ datos[3] +"', '"+ datos[4] +"')";
            }else if (accion == "modificar") {
                sql = "UPDATE alumnos SET codigo='"+ datos[1] + "', nombre='"+ datos[2] + "', direccion='"+ datos[3] + "', telefono='"+ datos[4] + "' WHERE idAlumno='"+ datos[0] +"'";
            }else if (accion == "eliminar") {
                sql = "DELETE FROM alumnos WHERE idAlumno='"+ datos[0] +"'";
            }
            return ejecutarSQL(sql);
        }

        // ---> ESTA ES LA FUNCIÓN QUE TE FALTABA PARA MATERIAS <---
        public string administrarDatosMaterias(String[] datos, String accion) {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO materias(codigo,nombre,uv) VALUES ('"+ datos[1] + "', '"+ datos[2] + "', '"+ datos[3] +"')";
            } else if (accion == "modificar") {
                sql = "UPDATE materias SET codigo='"+ datos[1] + "', nombre='"+ datos[2] + "', uv='"+ datos[3] + "' WHERE idMateria='"+ datos[0] +"'";
            } else if (accion == "eliminar") {
                sql = "DELETE FROM materias WHERE idMateria='"+ datos[0] +"'";
            }
            return ejecutarSQL(sql);
        }

        // ---> ESTA ES LA FUNCIÓN QUE EJECUTA LAS ACCIONES EN LA BASE DE DATOS <---
        public String ejecutarSQL(String sql) {
            try {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            } catch(Exception ex) {
                return ex.Message;
            }
        }
    }
}