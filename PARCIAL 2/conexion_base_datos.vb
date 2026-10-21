Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_base_datos
    ' Cadena de conexión hacia la base de datos BaseDatos.mdf del proyecto
    Public conexion As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BaseDatos.mdf;Integrated Security=True")
    Public ds As New DataSet()

    ' Método crearDs: Carga el DataSet para la tabla usuarios_USSS080626 (2 Pts)
    Public Sub crearDs()
        ds.Tables.Clear()
        Dim adapterUsuarios As New SqlDataAdapter("SELECT * FROM usuarios_USSS080626", conexion)
        adapterUsuarios.Fill(ds, "usuarios_USSS080626")
    End Sub

    ' Método genérico procesar para ejecutar comandos INSERT, UPDATE, DELETE
    Public Function procesar(ByVal sql As String) As Integer
        Dim comando As New SqlCommand(sql, conexion)
        Dim filasAfectadas As Integer = 0
        Try
            conexion.Open()
            filasAfectadas = comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
        Return filasAfectadas
    End Function

    ' Método consultar para obtener datos en DataTable (usado en el login)
    Public Function consultar(ByVal sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim adapter As New SqlDataAdapter(sql, conexion)
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error al consultar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Método de mantenimiento específico solicitado en el examen (2 Pts)
    Public Function mantenimiento_usuarios_USSS080626(ByVal sql As String) As Integer
        Return procesar(sql)
    End Function
End Class