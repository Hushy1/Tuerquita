Imports System.Data.SqlClient

Public Class Form6
    Dim conexion As New Class1
    Dim comando As String
    Dim reader As SqlDataReader
    Dim resultado As Boolean
    Dim car As Integer
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBox1.Text() = "Gerente" Then
            car = 1
        End If
        If ComboBox1.Text() = "Empleado" Then
            car = 0
        End If

        comando = "Insert Into Usuarios
                    Values ('" + usuario.Text + "', '" + nombre.Text + "', '" + contraseña.Text + "','" + car.ToString() + "')"
        'resultado =
        conexion.read(comando)

    End Sub
End Class