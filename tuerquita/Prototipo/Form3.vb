Imports System.Data.SqlClient

Public Class Form3
    Dim conexion As New Class1
    Dim conn As New Class1
    Dim comando As String
    Dim PrecioF As String

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        refresh()
    End Sub
    Sub refresh()
        conn.dataset = New DataSet

        Try
            conn.execute("Select * From Articulos")

            conn.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conn.cmd)
            conn.dataadapter.Fill(conn.dataset)

            DataGridView1.DataSource = conn.dataset.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try

        ComboBox1.Items.Clear()

        Dim reader As SqlDataReader

        comando = "Select Nombre_Proveedor from Proveedores"

        reader = conexion.executeReader(comando)

        Do While reader.Read()
            ComboBox1.Items.Add(reader.GetString(0))
        Loop

        reader.Close()

        ComboBox2.Items.Clear()

        comando = "Select * From Rubro"

        reader = conexion.executeReader(comando)

        Do While reader.Read()
            ComboBox2.Items.Add(reader.GetString(0))
        Loop

        reader.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comando = "Insert Into Articulos
                        Values ('" + idusuario.Text + "', '" + nombreart.Text + "', '" + precioart.Text + "', '" + ComboBox1.Text + "', '" + ComboBox2.Text + "')"
        conexion.read(comando)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        comando = "Select * From Articulos Where Cod_Articulo = " + TextBox3.Text + ""
        conexion.read(comando)
    End Sub
End Class