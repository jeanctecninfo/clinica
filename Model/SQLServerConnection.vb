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

    Public Function ExecConsulta(query As String)
        Dim dt As DataTable

        Dim sqlDataAdapter As New SqlDataAdapter()
        Dim sqlCommand As New SqlCommand(query, Me.conn)

        Me.doConn()

        sqlDataAdapter.Fill(sqlCommand)


        Return dt
    End Function


End Class
