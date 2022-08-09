Public Class QuizBD
    Dim contador As Integer

    Private Property puntaje As Integer
    Private Sub BtnTerminar_Click(sender As Object, e As EventArgs) Handles BtnTerminar.Click
        BtnNuevaOportunidad.Enabled = True
        calificar()
        radiobloquear()
    End Sub

    Private Sub calificar()
        puntaje = 0
        If RadioButton1.Checked = True Then puntaje = puntaje + 10
        If RadioButton5.Checked = True Then puntaje = puntaje + 10
        If RadioButton9.Checked = True Then puntaje = puntaje + 10
        If RadioButton10.Checked = True Then puntaje = puntaje + 10
        If RadioButton14.Checked = True Then puntaje = puntaje + 10
        Timer1.Enabled = False

        If puntaje <= 20 Then
            TextBox1.Text = puntaje
            imagen.Visible = True
            Aprobar.Text = "No Aprobaste, Debes repasar los temas," + Str(puntaje) + " de 50"
            imagen.Image = Image.FromFile("triste.jpg")
            Return
        Else
            TextBox1.Text = puntaje
            imagen.Visible = True
            Aprobar.Text = "Su puntaje es :" + Str(puntaje) + " de 50" + " !Felicidades Aprobaste!"
            imagen.Image = Image.FromFile("feliz.jpg")
            ForPrincipalBasesDeDatos.BtnFase2BDB.Enabled = True
            LbMensaje.Text = "ya puedes realizar el examen de fase 2"
            Return
        End If
    End Sub

    Private Sub radioenabled()
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True
        RadioButton10.Enabled = True
        RadioButton11.Enabled = True
        RadioButton12.Enabled = True
        RadioButton13.Enabled = True
        RadioButton14.Enabled = True
        RadioButton15.Enabled = True
    End Sub

    Private Sub radiochecked()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False
        RadioButton14.Checked = False
        RadioButton15.Checked = False
    End Sub

    Private Sub radiobloquear()
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton6.Enabled = False
        RadioButton7.Enabled = False
        RadioButton8.Enabled = False
        RadioButton9.Enabled = False
        RadioButton10.Enabled = False
        RadioButton11.Enabled = False
        RadioButton12.Enabled = False
        RadioButton13.Enabled = False
        RadioButton14.Enabled = False
        RadioButton15.Enabled = False

    End Sub

    Private Sub BtnInicia_Click(sender As Object, e As EventArgs) Handles BtnInicia.Click
        Aprobar.ResetText()
        '  imagen.Visible = False
        LbMensaje.ResetText()
        BtnNuevaOportunidad.Enabled = False
        radiochecked()
        radioenabled()
        contador = 120
        Timer1.Enabled = True
        BtnTerminar.Enabled = True
        BtnInicia.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        contador = contador - 1
        TxtTemposizador.Text = contador

        If contador = 0 Then
            Timer1.Enabled = False
            MsgBox("Su tiempo Termino")
            BtnNuevaOportunidad.Enabled = True
            calificar()
        End If

    End Sub

    Private Sub BtnNuevaOportunidad_Click(sender As Object, e As EventArgs) Handles BtnNuevaOportunidad.Click
        BtnInicia.Enabled = True
        BtnTerminar.Enabled = False

        Timer1.Enabled = False
        puntaje = 0
        Aprobar.ResetText()
        imagen.Visible = False
        LbMensaje.ResetText()
        radiochecked()
        radiobloquear()

        TxtTemposizador.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BasesDeDatos.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

End Class