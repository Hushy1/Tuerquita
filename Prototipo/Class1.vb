Imports System.Data.SqlClient

Public Class Class1
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dataadapter As New SqlDataAdapter
    Public dataset As New DataSet
    Public connError As String
    Public reader As SqlDataReader

    Public Shared puesto As Boolean

    Public Sub New()
        Try
            conn.ConnectionString = "Server=ANUBIS\SQLEXPRESS;Database=Tuerquita;Integrated Security=true;User Id=admin;Password=12345678;"
            conn.Open()

            cmd.Connection = conn
            MsgBox("Conexion Exitosa")

            connError = ""
        Catch ex As Exception
            connError = ex.Message
            MsgBox(connError)
        End Try
    End Sub

    Public Sub execute(comando As String)
        Try
            cmd.CommandText = comando
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, vbOK)
        End Try
    End Sub

    Public Function read(comando As String) As Boolean
        Dim resultado As Boolean = False

        cmd = conn.CreateCommand
        Try
            cmd.CommandText = comando
            reader = cmd.ExecuteReader()
            Do While reader.Read()
                puesto = reader.GetBoolean(0)
                resultado = True
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, vbOK)
        End Try
        conn.Close()

        Return resultado
    End Function
End Class