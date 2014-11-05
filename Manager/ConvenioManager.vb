Imports Model

Public Class ConvenioManager
    Dim conn As New SQLServerConnection()

    Public Sub InsertConvenio()
        conn.ExecManipulation("INSERT INTO convenio VALUES (1, 'UNIMED', '(88) 8888-8888', 'unimed@unimed.com.br')")
    End Sub

End Class
