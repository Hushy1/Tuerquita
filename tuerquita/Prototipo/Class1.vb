Imports System.Data.SqlClient

Public Class Class1
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dataadapter As New SqlDataAdapter
    Public dataset As New DataSet
    Public connError As String
    Public reader As SqlDataReader
    Public car As String
    Public Shared puesto As Boolean


    Public Sub New()
        Try
            conn.ConnectionString = "Server=DESKTOP-0836U4C\SQLEXPRESS;Database=Tuerquita;Integrated Security=true;User Id=admin;Password=12345678;"
            conn.Open()

            cmd.Connection = conn
            connError = ""
        Catch ex As Exception
            connError = ex.Message
            MsgBox(connError)
        End Try
    End Sub

    Public Function Conectado()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function desconectado()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
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

        Return resultado
    End Function

    Public Function executeReader(comando As String) As SqlDataReader
        Try
            cmd.CommandText = comando
            executeReader = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message, vbOK)
        End Try

        Return executeReader
    End Function
End Class