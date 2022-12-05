Imports System.Data.SqlClient

Public Class Form5
    Dim conexion As New Class1
    Dim comando As String
    Dim resultado As Boolean
    Dim conn As New Class1
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comando = "insert into Proveedores
                   Values ('" + TextBox1.Text + "'," + TextBox3.Text + ", " + TextBox4.Text + ", '" + TextBox5.Text + "','" + TextBox6.Text + "','" + ComboBox1.Text + "'  )"
        conexion.read(comando)
    End Sub

    Sub refresh()
        conn.dataset = New DataSet

        Try
            conn.execute("Select * From Proveedores")

            conn.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conn.cmd)
            conn.dataadapter.Fill(conn.dataset)

            DataGridView1.DataSource = conn.dataset.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try

        ComboBox1.Items.Clear()
        Dim reader As SqlDataReader
        comando = "Select Rubro from Rubro"
        reader = conexion.executeReader(comando)
        Do While reader.Read()
            ComboBox1.Items.Add(reader.GetString(0))
        Loop
        reader.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        refresh()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        comando = "Insert into Rubros
                    Values ('" + TextBox2.Text + "')"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class