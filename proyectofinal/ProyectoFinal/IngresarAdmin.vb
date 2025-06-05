Imports System.Data.SqlClient

Public Class IngresarAdmin
    Private connectionString As String = "Data Source=LUIS\SQLEXPRESS;Initial Catalog=Discos;Integrated Security=True"

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usuario As String = UsernameTextBox.Text
        Dim contrase�a As String = PasswordTextBox.Text

        ' Realiza la autenticaci�n
        If AutenticarAdmin(usuario, contrase�a) Then
            MessageBox.Show("Inicio de sesi�n exitoso.", "Autenticaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Administrar.Show()
        Else
            MessageBox.Show("Usuario o contrase�a incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AutenticarAdmin(usuario As String, contrase�a As String) As Boolean
        Dim resultado As Boolean = False

        Using conexion As New SqlConnection(connectionString)
            Dim consulta As String = "SELECT COUNT(1) FROM ADMINS WHERE Usuario = @usuario AND Contrase�a = @contrase�a"
            Dim comando As New SqlCommand(consulta, conexion)

            ' Par�metros para evitar inyecci�n SQL
            comando.Parameters.AddWithValue("@usuario", usuario)
            comando.Parameters.AddWithValue("@contrase�a", contrase�a)

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
