Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form8
    Dim conn As New Class1
    Dim conexion As New Class1
    Dim comando As String
    Dim Tipo As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Sub refresh()
        conn.dataset = New DataSet

        Try
            conn.execute("Select * From Kardex")

            conn.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conn.cmd)
            conn.dataadapter.Fill(conn.dataset)

            DataGridView1.DataSource = conn.dataset.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try

        ComboBox1.Items.Clear()
        Dim reader As SqlDataReader
        comando = "Select CodBarras from Articulos"
        reader = conexion.executeReader(comando)
        Do While reader.Read()
            ComboBox1.Items.Add(CType(reader(0), String))
        Loop
        reader.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        comando = "Insert Into Kardex
                    Values (" + TextBox1.Text + ", " + TextBox2.Text + ", '" + MaskedTextBox1.Text + "', '" + TextBox3.Text + "', 'Entrada', " + ComboBox1.Text + " )"



        'MsgBox(comando)
        conexion.execute(comando)
    End Sub

End Class