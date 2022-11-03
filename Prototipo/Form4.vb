Public Class Form4
    Private Sub btnSalirG_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        Me.Hide()
        Form6.Show()
    End Sub

End Class