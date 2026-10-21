Imports System.Data
Imports System.Windows.Forms

Public Class login
    Private bd As Conexion_base_datos

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Se instancia únicamente en tiempo de ejecución
        bd = New Conexion_base_datos()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If bd Is Nothing Then bd = New Conexion_base_datos()

        Dim usr As String = txtUsuario.Text.Trim()
        Dim pass As String = txtClave.Text

        If String.IsNullOrWhiteSpace(usr) OrElse String.IsNullOrWhiteSpace(pass) Then
            MessageBox.Show("Ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim sql As String = $"SELECT * FROM usuarios_USSS080626 WHERE usuario = '{usr}' AND clave = '{pass}'"
        Dim dt As DataTable = bd.consultar(sql)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            MessageBox.Show("¡Bienvenido al sistema!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim frmUser As New frm_usuario()
            Me.Hide()
            frmUser.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos. Acceso denegado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClave.Clear()
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub
End Class