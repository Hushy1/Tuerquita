Imports System.Data.SqlClient

Public Class Form4
    Dim conexion As New Class1
    Dim comando As String
    Dim comando1 As String
    Dim comando2 As String
    Dim reader As SqlDataReader
    Dim conn As New Class1
    Dim Precio As Integer
    Dim Costo As Integer
    Dim Ganancia As Integer
    Dim Porcentaje As Integer


    Private Sub btnSalirG_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form7.Show()
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
    End Sub

    Sub Refresh2()
        conn.dataset = New DataSet

        Try
            conn.execute("Select * From Articulos Where CodBarras = " + TextBox6.Text + "")

            conn.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conn.cmd)
            conn.dataadapter.Fill(conn.dataset)

            DataGridView2.DataSource = conn.dataset.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        refresh()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Refresh2()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Ganancia = CInt(TextBox3.Text)
        Costo = CInt(TextBox9.Text)

        Porcentaje = (Ganancia * Costo) / 100

        Precio = Costo + Porcentaje

        comando = "INSERT INTO Articulos
                    Values (" + TextBox10.Text + ", '" + TextBox1.Text + "', " + TextBox9.Text + ", " + TextBox3.Text + ", " + Precio.ToString + ", '" + ComboBox1.Text + "')"
        conexion.execute(comando)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        comando = "DELETE FROM Articulos WHERE CodBarras = " + TextBox2.Text + ""
        conexion.execute(comando)
    End Sub
End Class