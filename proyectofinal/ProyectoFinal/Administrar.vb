Imports System.Data.SqlClient
Imports System.IO
Public Class Administrar
    Dim connectionString As String = "Data Source=LUIS\SQLEXPRESS;Initial Catalog=Discos;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Buscador.Show()
    End Sub

    Private Sub VerTabla_Click(sender As Object, e As EventArgs) Handles VerTabla.Click
        Try
            connection.Open()
            Dim query As String = "SELECT INFO.Codigo, INFO.Nombre, INFO.Artista, INFO.Genero, INFO.Año, INFO.No_Pistas, ENLACES.Spotify, ENLACES.AppleMusic FROM INFO LEFT JOIN ENLACES ON INFO.Codigo = ENLACES.Codigo"
            Dim adapter As New SqlDataAdapter(query, connection)

            Dim table As New DataTable()
            adapter.Fill(table)

            dgvCRUD.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        Try
            connection.Open()
            Dim query As String = "INSERT INTO INFO (Codigo, Nombre, Artista, Genero, Año, No_Pistas, Imagen) VALUES (@Codigo, @Nombre, @Artista, @Genero, @Año, @No_Pistas, @Imagen)"
            Dim command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
            command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            command.Parameters.AddWithValue("@Artista", txtArtista.Text)
            command.Parameters.AddWithValue("@Genero", txtGenero.Text)
            command.Parameters.AddWithValue("@Año", Integer.Parse(txtAño.Text))
            command.Parameters.AddWithValue("@No_Pistas", Integer.Parse(txtNoPistas.Text))

            ' Convertir la imagen a byte array y añadirla como parámetro
            Dim ms As New MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim imgBytes As Byte() = ms.ToArray()
            command.Parameters.AddWithValue("@Imagen", imgBytes)

            command.ExecuteNonQuery()
            MessageBox.Show("Registro creado correctamente en INFO.")

            ' Crear enlace en la tabla ENLACES
            Dim queryEnlace As String = "INSERT INTO ENLACES (Codigo, Spotify, AppleMusic) VALUES (@Codigo, @Spotify, @AppleMusic)"
            Dim commandEnlace As New SqlCommand(queryEnlace, connection)
            commandEnlace.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
            commandEnlace.Parameters.AddWithValue("@Spotify", txtSpotify.Text)
            commandEnlace.Parameters.AddWithValue("@AppleMusic", txtAppleMusic.Text)

            commandEnlace.ExecuteNonQuery()
            MessageBox.Show("Enlaces agregados correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Leer_Click(sender As Object, e As EventArgs) Handles Leer.Click
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM INFO INNER JOIN ENLACES ON INFO.Codigo = ENLACES.Codigo WHERE INFO.Codigo = @Codigo"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)

            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    txtNombre.Text = reader("Nombre").ToString()
                    txtArtista.Text = reader("Artista").ToString()
                    txtGenero.Text = reader("Genero").ToString()
                    txtAño.Text = reader("Año").ToString()
                    txtNoPistas.Text = reader("No_Pistas").ToString()

                    ' Cargar imagen desde el campo VARBINARY
                    Dim imgBytes As Byte() = CType(reader("Imagen"), Byte())
                    Dim ms As New MemoryStream(imgBytes)
                    PictureBox1.Image = Image.FromStream(ms)

                    ' Cargar enlaces
                    txtSpotify.Text = reader("Spotify").ToString()
                    txtAppleMusic.Text = reader("AppleMusic").ToString()
                End While
            Else
                MessageBox.Show("No se encontró un registro con ese código.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Try
            connection.Open()
            Dim query As String = "UPDATE INFO SET Nombre=@Nombre, Artista=@Artista, Genero=@Genero, Año=@Año, No_Pistas=@No_Pistas, Imagen=@Imagen WHERE Codigo=@Codigo"
            Dim command As New SqlCommand(query, connection)

            ' Añadir parámetros
            command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
            command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            command.Parameters.AddWithValue("@Artista", txtArtista.Text)
            command.Parameters.AddWithValue("@Genero", txtGenero.Text)
            command.Parameters.AddWithValue("@Año", Integer.Parse(txtAño.Text))
            command.Parameters.AddWithValue("@No_Pistas", Integer.Parse(txtNoPistas.Text))

            ' Convertir la imagen a byte array
            Dim ms As New MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            command.Parameters.AddWithValue("@Imagen", ms.ToArray())

            command.ExecuteNonQuery()
            MessageBox.Show("Registro actualizado correctamente en INFO.")

            ' Actualizar enlaces en la tabla ENLACES
            Dim queryEnlace As String = "UPDATE ENLACES SET Spotify=@Spotify, AppleMusic=@AppleMusic WHERE Codigo=@Codigo"
            Dim commandEnlace As New SqlCommand(queryEnlace, connection)
            commandEnlace.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
            commandEnlace.Parameters.AddWithValue("@Spotify", txtSpotify.Text)
            commandEnlace.Parameters.AddWithValue("@AppleMusic", txtAppleMusic.Text)

            commandEnlace.ExecuteNonQuery()
            MessageBox.Show("Enlaces actualizados correctamente.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Try
            connection.Open()

            Dim queryEnlace As String = "DELETE FROM ENLACES WHERE Codigo=@Codigo"
            Dim commandEnlace As New SqlCommand(queryEnlace, connection)
            commandEnlace.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
            commandEnlace.ExecuteNonQuery()

            Dim query As String = "DELETE FROM INFO WHERE Codigo=@Codigo"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
            command.ExecuteNonQuery()

            MessageBox.Show("Registro eliminado correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub SelecImagen_Click(sender As Object, e As EventArgs) Handles SelecImagen.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Cargar la imagen seleccionada en el PictureBox
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub
End Class