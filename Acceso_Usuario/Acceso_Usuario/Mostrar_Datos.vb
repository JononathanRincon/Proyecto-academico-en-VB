Public Class Mostrar_Datos
    Private Sub Mostrar_Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dtsdatos.Reset()
        consulta_datos()
        DataGridView1.DataSource = _dtvdatos

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Inicio_Seccion.Show()
        Close()
    End Sub
End Class