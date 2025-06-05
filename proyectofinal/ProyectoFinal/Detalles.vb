Imports System.Data.SqlClient
Public Class Detalles
    Private codigo As String

    ' Constructor que recibe el código
    Public Sub New(codigoSeleccionado As String)
        InitializeComponent()
        codigo = codigoSeleccionado
        LoadDetails()
    End Sub

    Private Sub LoadDetails()
        Dim connectionString As String = "Data Source=LUIS\SQLEXPRESS;Initial Catalog=Discos;Integrated Security=True"

        Using conn As New SqlConnection(connectionString)
            ' Obtener los datos de la tabla INFO
            Dim query As String = "SELECT Nombre, Artista, Genero, Año, No_Pistas, Imagen FROM INFO WHERE Codigo = @codigo"
            Dim cmdInfo As New SqlCommand(query, conn)
            cmdInfo.Parameters.AddWithValue("@codigo", codigo)

            ' Obtener los enlaces de la tabla ENLACES
            Dim queryEnlaces As String = "SELECT Spotify, AppleMusic FROM ENLACES WHERE Codigo = @codigo"
            Dim cmdEnlaces As New SqlCommand(queryEnlaces, conn)
            cmdEnlaces.Parameters.AddWithValue("@codigo", codigo)

            conn.Open()

            ' Cargar datos de INFO
            Using reader As SqlDataReader = cmdInfo.ExecuteReader()
                If reader.Read() Then
                    NombreAlbum.Text = reader("Nombre").ToString()
                    ArtistaAlbum.Text = reader("Artista").ToString()
                    GeneroAlbum.Text = reader("Genero").ToString()
                    AñoAlbum.Text = reader("Año").ToString()
                    NoPistasAlbum.Text = reader("No_Pistas").ToString()

                    ' Mostrar la imagen
                    Dim imageData As Byte() = TryCast(reader("Imagen"), Byte())
                    If imageData IsNot Nothing Then
                        Using ms As New IO.MemoryStream(imageData)
                            ImagenAlbum.Image = Image.FromStream(ms)
                        End Using
                    End If
                End If
            End Using

            ' Cargar enlaces de Spotify y Apple Music
            Using reader As SqlDataReader = cmdEnlaces.ExecuteReader()
                If reader.Read() Then
                    ' Asigna las URLs a los botones
                    Spotify.Tag = reader("Spotify").ToString()
                    AppleMusic.Tag = reader("AppleMusic").ToString()
                End If
            End Using
        End Using
    End Sub

    ' Abrir enlace de Spotify y de Apple Music
    Private Sub Spotify_Click(sender As Object, e As EventArgs) Handles Spotify.Click
        Dim spotifyUrl As String = Spotify.Tag.ToString()
        Process.Start(spotifyUrl)
    End Sub

    Private Sub AppleMusic_Click(sender As Object, e As EventArgs) Handles AppleMusic.Click
        Dim appleMusicUrl As String = AppleMusic.Tag.ToString()
        Process.Start(appleMusicUrl)
    End Sub
End Class