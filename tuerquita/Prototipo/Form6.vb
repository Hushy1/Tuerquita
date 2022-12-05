Imports System.Data.SqlClient
Public Class Form6
    Dim conexion As New Class1
    Dim comando As String
    Dim reader As SqlDataReader
    Dim resultado As Boolean
    Dim car As Integer
    Dim conn As New Class1

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBox1.Text() = "Gerente" Then
            car = 0
        End If
        If ComboBox1.Text() = "Empleado" Then
            car = 1
        End If

        comando = "Insert Into Usuarios
                    Values ('" + usuario.Text + "', '" + nombre.Text + "', '" + contraseña.Text + "','" + car.ToString() + "')"
        conexion.read(comando)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh()
    End Sub

    Sub refresh()
        conn.dataset = New DataSet

        Try
            conn.execute("Select * From Usuarios")

            conn.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conn.cmd)
            conn.dataadapter.Fill(conn.dataset)

            DataGridView1.DataSource = conn.dataset.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        comando = "delete from Usuarios where Usuario = '" + DeleteUser.Text + "'"
        conexion.read(comando)
    End Sub


End Class