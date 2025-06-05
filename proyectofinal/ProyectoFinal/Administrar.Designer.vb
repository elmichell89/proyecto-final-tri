<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrar))
        Me.dgvCRUD = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtNoPistas = New System.Windows.Forms.TextBox()
        Me.txtArtista = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSpotify = New System.Windows.Forms.TextBox()
        Me.txtAppleMusic = New System.Windows.Forms.TextBox()
        Me.Crear = New System.Windows.Forms.Button()
        Me.VerTabla = New System.Windows.Forms.Button()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Leer = New System.Windows.Forms.Button()
        Me.SelecImagen = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvCRUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCRUD
        '
        Me.dgvCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCRUD.Location = New System.Drawing.Point(17, 36)
        Me.dgvCRUD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvCRUD.Name = "dgvCRUD"
        Me.dgvCRUD.RowHeadersWidth = 51
        Me.dgvCRUD.Size = New System.Drawing.Size(1033, 177)
        Me.dgvCRUD.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INFO"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(15, 266)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(132, 22)
        Me.txtCodigo.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(173, 266)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(132, 22)
        Me.txtNombre.TabIndex = 3
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(15, 327)
        Me.txtGenero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(132, 22)
        Me.txtGenero.TabIndex = 4
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(173, 327)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(132, 22)
        Me.txtAño.TabIndex = 5
        '
        'txtNoPistas
        '
        Me.txtNoPistas.Location = New System.Drawing.Point(336, 327)
        Me.txtNoPistas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoPistas.Name = "txtNoPistas"
        Me.txtNoPistas.Size = New System.Drawing.Size(132, 22)
        Me.txtNoPistas.TabIndex = 6
        '
        'txtArtista
        '
        Me.txtArtista.Location = New System.Drawing.Point(336, 266)
        Me.txtArtista.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtArtista.Name = "txtArtista"
        Me.txtArtista.Size = New System.Drawing.Size(132, 22)
        Me.txtArtista.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(15, 390)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(601, 234)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ENLACES"
        '
        'txtSpotify
        '
        Me.txtSpotify.Location = New System.Drawing.Point(605, 266)
        Me.txtSpotify.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSpotify.Name = "txtSpotify"
        Me.txtSpotify.Size = New System.Drawing.Size(132, 22)
        Me.txtSpotify.TabIndex = 10
        '
        'txtAppleMusic
        '
        Me.txtAppleMusic.Location = New System.Drawing.Point(605, 327)
        Me.txtAppleMusic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAppleMusic.Name = "txtAppleMusic"
        Me.txtAppleMusic.Size = New System.Drawing.Size(132, 22)
        Me.txtAppleMusic.TabIndex = 11
        '
        'Crear
        '
        Me.Crear.Location = New System.Drawing.Point(195, 485)
        Me.Crear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(100, 28)
        Me.Crear.TabIndex = 12
        Me.Crear.Text = "Crear"
        Me.Crear.UseVisualStyleBackColor = True
        '
        'VerTabla
        '
        Me.VerTabla.Location = New System.Drawing.Point(951, 295)
        Me.VerTabla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VerTabla.Name = "VerTabla"
        Me.VerTabla.Size = New System.Drawing.Size(100, 28)
        Me.VerTabla.TabIndex = 13
        Me.VerTabla.Text = "Ver Tabla"
        Me.VerTabla.UseVisualStyleBackColor = True
        '
        'Actualizar
        '
        Me.Actualizar.Location = New System.Drawing.Point(473, 485)
        Me.Actualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(100, 28)
        Me.Actualizar.TabIndex = 14
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(605, 485)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(100, 28)
        Me.Eliminar.TabIndex = 15
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Regresar
        '
        Me.Regresar.Location = New System.Drawing.Point(951, 511)
        Me.Regresar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(100, 28)
        Me.Regresar.TabIndex = 16
        Me.Regresar.Text = "Regresar"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Leer
        '
        Me.Leer.Location = New System.Drawing.Point(336, 485)
        Me.Leer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Leer.Name = "Leer"
        Me.Leer.Size = New System.Drawing.Size(100, 28)
        Me.Leer.TabIndex = 17
        Me.Leer.Text = "Leer"
        Me.Leer.UseVisualStyleBackColor = True
        '
        'SelecImagen
        '
        Me.SelecImagen.Location = New System.Drawing.Point(195, 390)
        Me.SelecImagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SelecImagen.Name = "SelecImagen"
        Me.SelecImagen.Size = New System.Drawing.Size(100, 53)
        Me.SelecImagen.TabIndex = 18
        Me.SelecImagen.Text = "Seleccionar Imagen"
        Me.SelecImagen.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(95, 294)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(248, 294)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(421, 295)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Artista"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(92, 356)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Genero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(272, 356)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Año"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(349, 356)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Numero de Pistas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(687, 295)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Spotify"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(652, 356)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Apple Music"
        '
        'Administrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources.Fondo3
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SelecImagen)
        Me.Controls.Add(Me.Leer)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.VerTabla)
        Me.Controls.Add(Me.Crear)
        Me.Controls.Add(Me.txtAppleMusic)
        Me.Controls.Add(Me.txtSpotify)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtArtista)
        Me.Controls.Add(Me.txtNoPistas)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCRUD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Administrar"
        Me.Text = "Administrar"
        CType(Me.dgvCRUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCRUD As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtNoPistas As TextBox
    Friend WithEvents txtArtista As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSpotify As TextBox
    Friend WithEvents txtAppleMusic As TextBox
    Friend WithEvents Crear As Button
    Friend WithEvents VerTabla As Button
    Friend WithEvents Actualizar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Regresar As Button
    Friend WithEvents Leer As Button
    Friend WithEvents SelecImagen As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
