Public Class Big_Data

    Private Sub Llb1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Llb1.LinkClicked
        VideoPresentacion.Show()
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Caracteristicas.Show()
        Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Close()
        EstructurasBigData.Show()

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Close()
        Practica1.Show()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Close()
        Practica2.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Close()
        ExamenBigData.Show()
    End Sub

    Private Sub BtnDevolver_Click(sender As Object, e As EventArgs) Handles BtnDevolver.Click
        Programas.Show()
        Close()
    End Sub

    Private Sub LkLbExamen_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LkLbExamen.LinkClicked
        Examenfase2BigData.Show()
        Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LkLectura.LinkClicked
        LecturaFase2BigData.Show()
        Close()
    End Sub
End Class