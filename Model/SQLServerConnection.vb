Imports System.Data
Imports System.Data.SqlClient

Public Class SQLServerConnection
    Private conn As SqlConnection

    Private Sub doConn()
        Me.conn = New SqlConnection(modelSetting.Default.SQLServerString)
        Me.conn.Open()
    End Sub

    Public Sub ExecManipulation(query As String)
        Me.doConn()

        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = query
        cmd.Connection = Me.conn

        cmd.ExecuteNonQuery()
    End Sub

End Class
