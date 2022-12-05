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
        Dim resultado As Boolean = False, puesto As Boolean

        Usuario = TextBox1.Text.Trim
        Contraseña = TextBox2.Text.Trim

        comando = "select puesto from usuarios where usuario = '" + Usuario + "' and contraseña = '" + Contraseña + "'"

        reader = conexion.executeReader(comando)

        Do While reader.Read()
            puesto = reader.GetBoolean(0)
            resultado = True
        Loop

        reader.Close()

        If resultado Then
            Me.Hide()

            If puesto Then ' empleado
                Form10.Show()
            Else ' gerente|
                Form2.Show()
            End If
        Else
            MsgBox("usuario o contraseña incorrectos")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub


End Class
