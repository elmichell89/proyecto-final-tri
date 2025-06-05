Imports System.Data.SqlClient
Public Class Buscador
    Private Sub AdministrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarToolStripMenuItem.Click
        Me.Hide()
        IngresarAdmin.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Codigo para agregar las opciones al ComboBox
        CBParametros.Items.Add("Nombre")
        CBParametros.Items.Add("Artista")
        CBParametros.Items.Add("Genero")
        CBParametros.Items.Add("Año")
        CBParametros.SelectedIndex = 0
    End Sub

    Private connectionString As String = "Data Source=LUIS\SQLEXPRESS;Initial Catalog=Discos;Integrated Security=True"

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        ' Guardar el texto del cuadro de búsqueda
        Dim textoBusqueda As String = txtBuscador.Text.Trim()

        ' Verificar que el ComboBox tenga un campo seleccionado
        Dim campoSeleccionado As String = CBParametros.SelectedItem.ToString()

        Dim query As String = "SELECT Codigo, Nombre, Artista, Genero, Año FROM INFO WHERE " & campoSeleccionado & " LIKE @textoBusqueda"

        ' Conectar a la base de datos y ejecutar la consulta
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Agregar el parámetro de búsqueda con comodines si no es "Año"
                If campoSeleccionado = "Año" Then
                    cmd.Parameters.AddWithValue("@textoBusqueda", textoBusqueda & "%") ' Búsqueda exacta para año
                Else
                    cmd.Parameters.AddWithValue("@textoBusqueda", "%" & textoBusqueda & "%") ' Búsqueda parcial para texto
                End If

                ' Se cargan los datos en un DataTable y se muestran en el DataGridView
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvBuscador.DataSource = table
                dgvBuscador.Columns(0).Visible = False
                dgvBuscador.Columns(1).Width = 200
                dgvBuscador.Columns(2).Width = 170
                dgvBuscador.Columns(3).Width = 150
                dgvBuscador.Columns(4).Width = 50
            End Using
        End Using
    End Sub

    'Para mandar los datos de la tabla al form Detalles
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuscador.CellDoubleClick
        ' Obtener el codigo de la fila seleccionada
        Dim filaSeleccionada As DataGridViewRow = dgvBuscador.Rows(e.RowIndex)
        Dim codigo As String = filaSeleccionada.Cells("Codigo").Value.ToString()

        ' Se manda el codigo a Detalles y se abre Detalles
        Dim Detalles As New Detalles(codigo)
        Detalles.ShowDialog()
    End Sub

    Private Sub MisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisionToolStripMenuItem.Click
        Mision.ShowDialog()
    End Sub

    Private Sub VisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisionToolStripMenuItem.Click
        Vision.ShowDialog()
    End Sub

    Private Sub ValoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValoresToolStripMenuItem.Click
        Valores.ShowDialog()
    End Sub

    Private Sub FilosofíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilosofíaToolStripMenuItem.Click
        Filosofia.ShowDialog()
    End Sub
End Class
