Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As New Class1
    Dim comando As String
    Dim usu As String
    Dim con As String
    Dim reader As SqlDataReader

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim Usuario As String
        Dim Contraseña As String
        Dim resultado As Boolean

        Usuario = TextBox1.Text.Trim
        Contraseña = TextBox2.Text.Trim

        'comando = "exec [login] @usuario = " + Usuario + ", @contrasena = " + Contraseña

        'conexion.execute(comando)

        comando = "select puesto_u from usuarios where usuario = '" + Usuario + "' and contraseña_u = '" + Contraseña + "'"

        resultado = conexion.read(comando)

        If resultado = True Then
            Me.Hide()

            If Class1.puesto = True Then ' empleado
                Form3.Show()
            Else ' gerente|
                Form4.Show()
            End If
        Else
            MsgBox("usuario o contraseña incorrectos")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
