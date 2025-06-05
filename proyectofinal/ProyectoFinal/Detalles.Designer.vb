<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalles))
        Me.GeneroAlbum = New System.Windows.Forms.Label()
        Me.NoPistasAlbum = New System.Windows.Forms.Label()
        Me.AñoAlbum = New System.Windows.Forms.Label()
        Me.ArtistaAlbum = New System.Windows.Forms.Label()
        Me.NombreAlbum = New System.Windows.Forms.Label()
        Me.ImagenAlbum = New System.Windows.Forms.PictureBox()
        Me.Spotify = New System.Windows.Forms.Button()
        Me.AppleMusic = New System.Windows.Forms.Button()
        Me.NoDePistas = New System.Windows.Forms.Label()
        CType(Me.ImagenAlbum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneroAlbum
        '
        Me.GeneroAlbum.AutoSize = True
        Me.GeneroAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GeneroAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GeneroAlbum.Location = New System.Drawing.Point(232, 114)
        Me.GeneroAlbum.Name = "GeneroAlbum"
        Me.GeneroAlbum.Size = New System.Drawing.Size(63, 20)
        Me.GeneroAlbum.TabIndex = 12
        Me.GeneroAlbum.Text = "Género"
        '
        'NoPistasAlbum
        '
        Me.NoPistasAlbum.AutoSize = True
        Me.NoPistasAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NoPistasAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NoPistasAlbum.Location = New System.Drawing.Point(318, 147)
        Me.NoPistasAlbum.Name = "NoPistasAlbum"
        Me.NoPistasAlbum.Size = New System.Drawing.Size(76, 20)
        Me.NoPistasAlbum.TabIndex = 11
        Me.NoPistasAlbum.Text = "No Pistas"
        '
        'AñoAlbum
        '
        Me.AñoAlbum.AutoSize = True
        Me.AñoAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AñoAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AñoAlbum.Location = New System.Drawing.Point(232, 84)
        Me.AñoAlbum.Name = "AñoAlbum"
        Me.AñoAlbum.Size = New System.Drawing.Size(38, 20)
        Me.AñoAlbum.TabIndex = 10
        Me.AñoAlbum.Text = "Año"
        '
        'ArtistaAlbum
        '
        Me.ArtistaAlbum.AutoSize = True
        Me.ArtistaAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic)
        Me.ArtistaAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ArtistaAlbum.Location = New System.Drawing.Point(231, 49)
        Me.ArtistaAlbum.Name = "ArtistaAlbum"
        Me.ArtistaAlbum.Size = New System.Drawing.Size(74, 26)
        Me.ArtistaAlbum.TabIndex = 9
        Me.ArtistaAlbum.Text = "Artista"
        '
        'NombreAlbum
        '
        Me.NombreAlbum.AutoSize = True
        Me.NombreAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NombreAlbum.Location = New System.Drawing.Point(229, 12)
        Me.NombreAlbum.Name = "NombreAlbum"
        Me.NombreAlbum.Size = New System.Drawing.Size(138, 37)
        Me.NombreAlbum.TabIndex = 8
        Me.NombreAlbum.Text = "Nombre"
        '
        'ImagenAlbum
        '
        Me.ImagenAlbum.Location = New System.Drawing.Point(12, 12)
        Me.ImagenAlbum.Name = "ImagenAlbum"
        Me.ImagenAlbum.Size = New System.Drawing.Size(200, 200)
        Me.ImagenAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenAlbum.TabIndex = 7
        Me.ImagenAlbum.TabStop = False
        '
        'Spotify
        '
        Me.Spotify.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources.Spotify
        Me.Spotify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Spotify.Location = New System.Drawing.Point(552, 185)
        Me.Spotify.Name = "Spotify"
        Me.Spotify.Size = New System.Drawing.Size(50, 50)
        Me.Spotify.TabIndex = 13
        Me.Spotify.UseVisualStyleBackColor = True
        '
        'AppleMusic
        '
        Me.AppleMusic.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources.AppleMusic
        Me.AppleMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AppleMusic.Location = New System.Drawing.Point(643, 185)
        Me.AppleMusic.Name = "AppleMusic"
        Me.AppleMusic.Size = New System.Drawing.Size(50, 50)
        Me.AppleMusic.TabIndex = 14
        Me.AppleMusic.UseVisualStyleBackColor = True
        '
        'NoDePistas
        '
        Me.NoDePistas.AutoSize = True
        Me.NoDePistas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NoDePistas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NoDePistas.Location = New System.Drawing.Point(232, 147)
        Me.NoDePistas.Name = "NoDePistas"
        Me.NoDePistas.Size = New System.Drawing.Size(80, 20)
        Me.NoDePistas.TabIndex = 15
        Me.NoDePistas.Text = "No Pistas:"
        '
        'Detalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources.Fondo2
        Me.ClientSize = New System.Drawing.Size(734, 275)
        Me.Controls.Add(Me.NoDePistas)
        Me.Controls.Add(Me.AppleMusic)
        Me.Controls.Add(Me.Spotify)
        Me.Controls.Add(Me.GeneroAlbum)
        Me.Controls.Add(Me.NoPistasAlbum)
        Me.Controls.Add(Me.AñoAlbum)
        Me.Controls.Add(Me.ArtistaAlbum)
        Me.Controls.Add(Me.NombreAlbum)
        Me.Controls.Add(Me.ImagenAlbum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Detalles"
        Me.Text = "Detalles"
        CType(Me.ImagenAlbum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GeneroAlbum As Label
    Friend WithEvents NoPistasAlbum As Label
    Friend WithEvents AñoAlbum As Label
    Friend WithEvents ArtistaAlbum As Label
    Friend WithEvents NombreAlbum As Label
    Friend WithEvents ImagenAlbum As PictureBox
    Friend WithEvents Spotify As Button
    Friend WithEvents AppleMusic As Button
    Friend WithEvents NoDePistas As Label
End Class
