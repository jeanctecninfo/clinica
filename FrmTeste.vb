Imports Manager

Public Class FrmTeste
    Dim convenioManager As New ConvenioManager()

    Private Sub btnTeste_Click(sender As Object, e As EventArgs) Handles btnTeste.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        convenioManager.ConvenioName = txtConvenioNome.text()

        convenioManager.ConvenioSave()
    End Sub
End Class