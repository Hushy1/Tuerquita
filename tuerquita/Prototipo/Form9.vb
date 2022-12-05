Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form9
    Dim conn As New Class1
    Dim conexion As New Class1
    Dim comando As String
    Dim cae As String
    Dim reader As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
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

    End Sub
    Sub actualizar2()
        conn.dataset = New DataSet

        Try
            conn.execute("Select * From Cabecera")

            conn.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conn.cmd)
            conn.dataadapter.Fill(conn.dataset)

            DataGridView2.DataSource = conn.dataset.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try
    End Sub
    Sub actualizar()
        conn.dataset = New DataSet

        Try
            conn.execute("Select * From Detalles")

            conn.dataadapter = New System.Data.SqlClient.SqlDataAdapter(conn.cmd)
            conn.dataadapter.Fill(conn.dataset)

            DataGridView1.DataSource = conn.dataset.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error." + vbCrLf + ex.Message, vbOK)
        End Try

        idcliente.Items.Clear()
        Dim reader As SqlDataReader
        comando = "Select id_cliente from Clientes"
        reader = conexion.executeReader(comando)
        Do While reader.Read()
            idcliente.Items.Add(CType(reader(0), String))
        Loop
        reader.Close()

        codbarras.Items.Clear()
        comando = "Select CodBarras from Articulos"
        reader = conexion.executeReader(comando)
        Do While reader.Read()
            codbarras.Items.Add(CType(reader(0), String))
        Loop
        reader.Close()

        metodo_pago.Items.Clear()
        comando = "Select Metodo from Forma_Pago"
        reader = conexion.executeReader(comando)
        Do While reader.Read()
            metodo_pago.Items.Add(CType(reader(0), String))
        Loop
        reader.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        actualizar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        actualizar2()
    End Sub

    Sub generarcae()
        Dim num As New Random
        Dim generarcae As String = ""

        For i = 1 To 7
            If i = 4 Then
                generarcae += "-"
            Else
                generarcae += $"{num.Next(1, 9)}"
            End If
        Next

        cae = generarcae
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        comando = "insert into Cabecera
                   Values (" + ids.Text + ",'" + Fecha.Text + "', '" + Categoria.Text + "', cae, " + ids.Text + ", " + idcliente.Text + ")"
        conexion.execute(comando)
        comando = "insert into Detalles
                   Values (" + ids.Text + ", " + codbarras.Text + ", " + cantidad.Text + ", " + total.Text + ", " + Impuestos.Text + ", '" + metodo_pago.Text + "')"
        conexion.execute(comando)
    End Sub


End Class