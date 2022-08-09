Imports MySql.Data.MySqlClient

Public Class Borrar
    Dim _adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim conexion As New MySqlConnection
    Private Sub BtnDevolver_Click(sender As Object, e As EventArgs) Handles BtnDevolver.Click
        Hide()
        Inicio_Seccion.Show()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim dat As New Datos_Usuario
        Dim conex As New FuncionInsertar

        If TxtContraseña.Text = "" Then
            ErrorProvider1.SetError(TxtContraseña, "digite la contraseña")
            TxtContraseña.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtContraseña, "")

        If conex.eliminardatos(dat) Then
            MessageBox.Show("Usuario eliminado eliminados", "eliminar datos")
            TxtContraseña.Clear()
            TxtUsuario.Clear()
            consulta_datos()
            CargarDatos()
        Else
            MessageBox.Show("datos no eliminos", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub
End Class