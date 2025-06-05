Imports System.Data.SqlClient

Public Class IngresarAdmin
    Private connectionString As String = "Data Source=LUIS\SQLEXPRESS;Initial Catalog=Discos;Integrated Security=True"

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usuario As String = UsernameTextBox.Text
        Dim contraseña As String = PasswordTextBox.Text

        ' Realiza la autenticación
        If AutenticarAdmin(usuario, contraseña) Then
            MessageBox.Show("Inicio de sesión exitoso.", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Administrar.Show()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AutenticarAdmin(usuario As String, contraseña As String) As Boolean
        Dim resultado As Boolean = False

        Using conexion As New SqlConnection(connectionString)
            Dim consulta As String = "SELECT COUNT(1) FROM ADMINS WHERE Usuario = @usuario AND Contraseña = @contraseña"
            Dim comando As New SqlCommand(consulta, conexion)

            ' Parámetros para evitar inyección SQL
            comando.Parameters.AddWithValue("@usuario", usuario)
            comando.Parameters.AddWithValue("@contraseña", contraseña)

            Try
                conexion.Open()
                Dim count As Integer = Convert.ToInt32(comando.ExecuteScalar())
                resultado = (count > 0) ' Si hay un registro que coincide, retorna True
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
            End Try
        End Using

        Return resultado
    End Function

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Buscador.Show()
    End Sub

End Class
