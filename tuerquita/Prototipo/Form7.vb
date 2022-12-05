Imports System.Data.SqlClient

Public Class Form7
    Dim conexion As New Class1
    Dim conn As New Class1
    Dim comando As String


    Sub refresh()
        conn.dataset = New DataSet

        Try
            conn.execute("Select * From Clientes")

            conn.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conn.cmd)
            conn.dataadapter.Fill(conn.dataset)

            DataGridView1.DataSource = conn.dataset.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button4.Click
        refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        comando = "INSERT INTO Clientes
                   VALUES(" + TextBox1.Text + ", '" + TextBox2.Text + "', '" + TextBox3.Text + "', " + TextBox4.Text + ", " + TextBox5.Text + ")"
        conexion.read(comando)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class