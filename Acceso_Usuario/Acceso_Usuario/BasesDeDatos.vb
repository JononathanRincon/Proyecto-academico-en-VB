Public Class BasesDeDatos
    Private Sub Llb1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Llb1.LinkClicked
        ProgramaBD.Show()
        Close()
    End Sub

    Private Sub Llb2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Llb2.LinkClicked
        Close()
        PresentacionBD.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Close()
        Conceptos.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        QuizBD.Show()
        Close()
    End Sub

    Private Sub BtnDevolver_Click_1(sender As Object, e As EventArgs) Handles BtnDevolver.Click
        ForPrincipalBasesDeDatos.Show()
        Close()
    End Sub
End Class