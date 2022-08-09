Public Class Examenfase2BigData
    Dim contador As Integer

    Private Property puntaje As Integer

    Private Sub BtnTerminar_Click(sender As Object, e As EventArgs) Handles BtnTerminar.Click
        BtnNuevaOportunidad.Enabled = True
        calificar()

    End Sub

    Private Sub BtnInicia_Click(sender As Object, e As EventArgs) Handles BtnInicia.Click
        Aprobar.ResetText()
        imagen.Visible = False
        BtnNuevaOportunidad.Enabled = False
        radioenable()
        contador = 120
        Timer1.Enabled = True
        BtnTerminar.Enabled = True
        BtnInicia.Enabled = False
    End Sub

    Private Sub radioChecked()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
    End Sub

    Private Sub radioenable()
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton10.Enabled = True
        RadioButton11.Enabled = True
        RadioButton12.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        contador = contador - 1
        TxtTemposizador.Text = contador

        If contador = 0 Then
            Timer1.Enabled = False
            MsgBox("Su tiempo Termino")
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
        radioChecked()
        TxtTemposizador.Clear()
        TextBox1.Clear()
        radioenable()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Big_Data.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub calificar()
        BtnNuevaOportunidad.Enabled = True

        puntaje = 0
        If RadioButton1.Checked = True Then puntaje = puntaje + 10
        If RadioButton10.Checked = True Then puntaje = puntaje + 10
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
            Return
        End If
    End Sub

End Class