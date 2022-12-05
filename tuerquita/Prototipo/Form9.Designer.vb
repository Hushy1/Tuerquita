<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Categoria = New System.Windows.Forms.ComboBox()
        Me.ids = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.MaskedTextBox()
        Me.idcliente = New System.Windows.Forms.ComboBox()
        Me.codbarras = New System.Windows.Forms.ComboBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.metodo_pago = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Impuestos = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Location = New System.Drawing.Point(-146, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 50)
        Me.Panel1.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = Global.Prototipo.My.Resources.Resources._1491254395_returnbackredoarrow_82934
        Me.Button2.Location = New System.Drawing.Point(146, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 46)
        Me.Button2.TabIndex = 40
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.Prototipo.My.Resources.Resources._4115235_exit_logout_sign_out_114030__1_
        Me.Button1.Location = New System.Drawing.Point(920, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 46)
        Me.Button1.TabIndex = 40
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenu.Image = Global.Prototipo.My.Resources.Resources._1491254395_returnbackredoarrow_82934
        Me.btnMenu.Location = New System.Drawing.Point(3, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(60, 36)
        Me.btnMenu.TabIndex = 10
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(419, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(407, 108)
        Me.DataGridView1.TabIndex = 40
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(555, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 45)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Actualizar tabla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Numero de Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "CodBarras Articulo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Metodo de Pago"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(67, 362)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(161, 45)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Registrar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Categoria
        '
        Me.Categoria.FormattingEnabled = True
        Me.Categoria.Items.AddRange(New Object() {"A", "B", "C"})
        Me.Categoria.Location = New System.Drawing.Point(127, 135)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(121, 21)
        Me.Categoria.TabIndex = 51
        '
        'ids
        '
        Me.ids.Location = New System.Drawing.Point(128, 82)
        Me.ids.Name = "ids"
        Me.ids.Size = New System.Drawing.Size(100, 20)
        Me.ids.TabIndex = 52
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(127, 109)
        Me.Fecha.Mask = "00/00/0000"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(67, 20)
        Me.Fecha.TabIndex = 53
        Me.Fecha.ValidatingType = GetType(Date)
        '
        'idcliente
        '
        Me.idcliente.FormattingEnabled = True
        Me.idcliente.Location = New System.Drawing.Point(127, 165)
        Me.idcliente.Name = "idcliente"
        Me.idcliente.Size = New System.Drawing.Size(121, 21)
        Me.idcliente.TabIndex = 54
        '
        'codbarras
        '
        Me.codbarras.FormattingEnabled = True
        Me.codbarras.Location = New System.Drawing.Point(127, 192)
        Me.codbarras.Name = "codbarras"
        Me.codbarras.Size = New System.Drawing.Size(121, 21)
        Me.codbarras.TabIndex = 55
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(128, 224)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(120, 20)
        Me.cantidad.TabIndex = 56
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(128, 251)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(120, 20)
        Me.total.TabIndex = 57
        '
        'metodo_pago
        '
        Me.metodo_pago.FormattingEnabled = True
        Me.metodo_pago.Location = New System.Drawing.Point(127, 297)
        Me.metodo_pago.Name = "metodo_pago"
        Me.metodo_pago.Size = New System.Drawing.Size(121, 21)
        Me.metodo_pago.TabIndex = 58
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(419, 260)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(407, 105)
        Me.DataGridView2.TabIndex = 59
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(555, 381)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(161, 45)
        Me.Button5.TabIndex = 60
        Me.Button5.Text = "Actualizar tabla"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Impuestos"
        '
        'Impuestos
        '
        Me.Impuestos.Location = New System.Drawing.Point(127, 274)
        Me.Impuestos.Name = "Impuestos"
        Me.Impuestos.Size = New System.Drawing.Size(120, 20)
        Me.Impuestos.TabIndex = 62
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(838, 475)
        Me.Controls.Add(Me.Impuestos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.metodo_pago)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.codbarras)
        Me.Controls.Add(Me.idcliente)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.ids)
        Me.Controls.Add(Me.Categoria)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Categoria As ComboBox
    Friend WithEvents ids As TextBox
    Friend WithEvents Fecha As MaskedTextBox
    Friend WithEvents idcliente As ComboBox
    Friend WithEvents codbarras As ComboBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents metodo_pago As ComboBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Impuestos As TextBox
End Class
