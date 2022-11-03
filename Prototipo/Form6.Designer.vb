<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CL6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CL2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CL7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(157, 472)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 39
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(107, 506)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "Eliminar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(87, 323)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 30)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Añadir usuario"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ink Free", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 18)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Eliminar Empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ink Free", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CL6, Me.Cargo, Me.CL2, Me.CL7})
        Me.DataGridView1.Location = New System.Drawing.Point(376, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(531, 295)
        Me.DataGridView1.TabIndex = 49
        '
        'CL6
        '
        Me.CL6.HeaderText = "Nombre del usuario"
        Me.CL6.MinimumWidth = 6
        Me.CL6.Name = "CL6"
        Me.CL6.Width = 125
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        '
        'CL2
        '
        Me.CL2.HeaderText = "Nombre"
        Me.CL2.MinimumWidth = 6
        Me.CL2.Name = "CL2"
        Me.CL2.Width = 125
        '
        'CL7
        '
        Me.CL7.HeaderText = "Contraseña del usuario"
        Me.CL7.MinimumWidth = 6
        Me.CL7.Name = "CL7"
        Me.CL7.Width = 125
        '
        'btnMenu
        '
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenu.Image = Global.Prototipo.My.Resources.Resources._1491254395_returnbackredoarrow_82934
        Me.btnMenu.Location = New System.Drawing.Point(3, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(61, 47)
        Me.btnMenu.TabIndex = 52
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ink Free", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 18)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Nombre de Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ink Free", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Contraseña"
        '
        'BtnSalir
        '
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.Image = Global.Prototipo.My.Resources.Resources._4115235_exit_logout_sign_out_114030__1_
        Me.BtnSalir.Location = New System.Drawing.Point(869, 0)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 47)
        Me.BtnSalir.TabIndex = 57
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ink Free", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Cargo"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Gerente"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Empleado", "Gerente"})
        Me.ComboBox1.Location = New System.Drawing.Point(162, 292)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 58
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(162, 201)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(100, 20)
        Me.usuario.TabIndex = 38
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(162, 264)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(100, 20)
        Me.contraseña.TabIndex = 41
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(162, 232)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 56
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.btnMenu)
        Me.Panel2.Location = New System.Drawing.Point(-7, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(949, 47)
        Me.Panel2.TabIndex = 60
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(919, 626)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "Empleados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnMenu As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents usuario As TextBox
    Friend WithEvents contraseña As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents CL6 As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents CL2 As DataGridViewTextBoxColumn
    Friend WithEvents CL7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
End Class
