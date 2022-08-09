Public Class Programas
    Private Sub BtnBigData_Click(sender As Object, e As EventArgs) Handles BtnBigData.Click
        Big_Data.Show()
        Hide()
    End Sub

    Private Sub BtnBasesDeDatosVisual_Click(sender As Object, e As EventArgs) Handles BtnBasesDeDatosVisual.Click
        ForPrincipalBasesDeDatos.Show()
        Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub DevolverseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverseToolStripMenuItem.Click
        Inicio_Seccion.Show()
        Hide()
    End Sub

End Class