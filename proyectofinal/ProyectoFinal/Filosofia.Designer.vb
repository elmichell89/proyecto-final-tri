<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filosofia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filosofia))
        Me.txtFilosofia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFilosofia
        '
        Me.txtFilosofia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFilosofia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilosofia.Location = New System.Drawing.Point(0, 0)
        Me.txtFilosofia.Multiline = True
        Me.txtFilosofia.Name = "txtFilosofia"
        Me.txtFilosofia.ReadOnly = True
        Me.txtFilosofia.Size = New System.Drawing.Size(484, 211)
        Me.txtFilosofia.TabIndex = 1
        '
        'Filosofia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 211)
        Me.Controls.Add(Me.txtFilosofia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Filosofia"
        Me.Text = "Filosofia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilosofia As TextBox
End Class
