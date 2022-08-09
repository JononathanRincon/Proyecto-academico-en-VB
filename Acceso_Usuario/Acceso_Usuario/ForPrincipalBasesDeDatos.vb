Public Class ForPrincipalBasesDeDatos
    Private Sub BtnFase1BDB_Click(sender As Object, e As EventArgs) Handles BtnFase1BDB.Click
        BasesDeDatos.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Programas.Show()
        Close()
    End Sub

    Private Sub BtnFase2BDB_Click(sender As Object, e As EventArgs) Handles BtnFase2BDB.Click
        ExamenFase2BDB.Show()
        Close()
    End Sub


End Class