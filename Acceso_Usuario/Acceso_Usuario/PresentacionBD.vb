﻿Public Class PresentacionBD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reproductor.Ctlcontrols.play()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Reproductor.Ctlcontrols.stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reproductor.Ctlcontrols.pause()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BasesDeDatos.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub PresentacionBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reproductor.URL = "Visual.mp4"

    End Sub
End Class