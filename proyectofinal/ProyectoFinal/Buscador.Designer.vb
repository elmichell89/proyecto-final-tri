<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Buscador
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buscador))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NosotrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilosofíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscosDataSet = New ProyectoFinal.DiscosDataSet()
        Me.INFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INFOTableAdapter = New ProyectoFinal.DiscosDataSetTableAdapters.INFOTableAdapter()
        Me.TableAdapterManager = New ProyectoFinal.DiscosDataSetTableAdapters.TableAdapterManager()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.dgvBuscador = New System.Windows.Forms.DataGridView()
        Me.CBParametros = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DiscosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarToolStripMenuItem, Me.NosotrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(865, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        '
        'NosotrosToolStripMenuItem
        '
        Me.NosotrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MisionToolStripMenuItem, Me.VisionToolStripMenuItem, Me.ValoresToolStripMenuItem, Me.FilosofíaToolStripMenuItem})
        Me.NosotrosToolStripMenuItem.Name = "NosotrosToolStripMenuItem"
        Me.NosotrosToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.NosotrosToolStripMenuItem.Text = "Nosotros"
        '
        'MisionToolStripMenuItem
        '
        Me.MisionToolStripMenuItem.Name = "MisionToolStripMenuItem"
        Me.MisionToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.MisionToolStripMenuItem.Text = "Mision"
        '
        'VisionToolStripMenuItem
        '
        Me.VisionToolStripMenuItem.Name = "VisionToolStripMenuItem"
        Me.VisionToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.VisionToolStripMenuItem.Text = "Vision"
        '
        'ValoresToolStripMenuItem
        '
        Me.ValoresToolStripMenuItem.Name = "ValoresToolStripMenuItem"
        Me.ValoresToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.ValoresToolStripMenuItem.Text = "Valores"
        '
        'FilosofíaToolStripMenuItem
        '
        Me.FilosofíaToolStripMenuItem.Name = "FilosofíaToolStripMenuItem"
        Me.FilosofíaToolStripMenuItem.Size = New System.Drawing.Size(148, 26)
        Me.FilosofíaToolStripMenuItem.Text = "Filosofía"
        '
        'DiscosDataSet
        '
        Me.DiscosDataSet.DataSetName = "DiscosDataSet"
        Me.DiscosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INFOBindingSource
        '
        Me.INFOBindingSource.DataMember = "INFO"
        Me.INFOBindingSource.DataSource = Me.DiscosDataSet
        '
        'INFOTableAdapter
        '
        Me.INFOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ADMINSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ENLACESTableAdapter = Nothing
        Me.TableAdapterManager.INFOTableAdapter = Me.INFOTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectoFinal.DiscosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(277, 68)
        Me.txtBuscador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(571, 22)
        Me.txtBuscador.TabIndex = 8
        '
        'dgvBuscador
        '
        Me.dgvBuscador.AllowUserToAddRows = False
        Me.dgvBuscador.AllowUserToDeleteRows = False
        Me.dgvBuscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscador.Location = New System.Drawing.Point(16, 101)
        Me.dgvBuscador.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvBuscador.Name = "dgvBuscador"
        Me.dgvBuscador.ReadOnly = True
        Me.dgvBuscador.RowHeadersWidth = 51
        Me.dgvBuscador.ShowEditingIcon = False
        Me.dgvBuscador.Size = New System.Drawing.Size(833, 213)
        Me.dgvBuscador.TabIndex = 9
        '
        'CBParametros
        '
        Me.CBParametros.FormattingEnabled = True
        Me.CBParametros.Location = New System.Drawing.Point(16, 66)
        Me.CBParametros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBParametros.Name = "CBParametros"
        Me.CBParametros.Size = New System.Drawing.Size(252, 24)
        Me.CBParametros.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(16, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Selecciona un parámetro de búsqueda"
        '
        'Buscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources.Fondo1
        Me.ClientSize = New System.Drawing.Size(865, 399)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBParametros)
        Me.Controls.Add(Me.dgvBuscador)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Buscador"
        Me.Text = "Buscador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DiscosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscosDataSet As DiscosDataSet
    Friend WithEvents INFOBindingSource As BindingSource
    Friend WithEvents INFOTableAdapter As DiscosDataSetTableAdapters.INFOTableAdapter
    Friend WithEvents TableAdapterManager As DiscosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents dgvBuscador As DataGridView
    Friend WithEvents CBParametros As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NosotrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilosofíaToolStripMenuItem As ToolStripMenuItem
End Class
