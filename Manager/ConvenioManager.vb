Imports Model

Public Class ConvenioManager
    Dim conn As New SQLServerConnection()

    Private convenioNome As String
    Private convenioTelefone As String
    Private convenioContato As String
    Private convenioCode As String

    Public Property ConvenioID() As String
        Get
            Return convenioCode
        End Get
        Set(ByVal value As String)
            convenioCode = value
        End Set
    End Property

    Public Property ConvenioName() As String
        Get
            Return ConvenioNome
        End Get
        Set(ByVal value As String)
            convenioNome = value
        End Set
    End Property

    Public Property ConvenioPhone() As String
        Get
            Return convenioTelefone
        End Get
        Set(ByVal value As String)
            convenioTelefone = value
        End Set
    End Property

    Public Property ConvenioContact() As String
        Get
            Return convenioContato
        End Get
        Set(ByVal value As String)
            convenioContato = value
        End Set
    End Property


    Public Sub ConvenioSave()
        conn.ExecManipulation("INSERT INTO convenio VALUES ('" & Me.ConvenioName() & "', '" & Me.ConvenioPhone() & "', '" & Me.ConvenioContact() & "')")
    End Sub

    Public Sub ConvenioUpdate()
        conn.ExecManipulation("UPDATE convenio SET convenio_name=" & Me.ConvenioName() & ", convenio_telefone=" & Me.ConvenioPhone() & ", convenio_contato=" & Me.ConvenioContact() & " WHERE convenio_ID=" & Me.ConvenioID())
    End Sub

    Public Sub ConvenioDelete()
        conn.ExecManipulation("DELETE FROM convenio WHERE convenio_ID=" & Me.ConvenioID())
    End Sub

    Public Sub ConvenioAll()
        conn.ExecManipulation("SELECT * FROM convenio")
    End Sub

    Public Sub ConvenioForName()
        conn.ExecManipulation("SELECT * FROM convenio WHERE convenio_name LIKE '%" & Me.ConvenioName() & "%'")
    End Sub

    Public Sub ConvenioForID()
        conn.ExecManipulation("SELECT * FROM convenio WHERE convenio_ID =" & Me.ConvenioID())
    End Sub
End Class
