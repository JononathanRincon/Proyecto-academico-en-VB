Imports MySql.Data.MySqlClient

Public Class Registro
    Private Sub BtnGuardad_Click(sender As Object, e As EventArgs) Handles BtnGuardad.Click
        Dim conexion As New MySqlConnection

        If (Not Char.IsLetter(TxtPNombre.Text)) Then
            ErrorProvider1.SetError(TxtPNombre, "digite solo letras")
            TxtPNombre.Clear()
            TxtPNombre.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtPNombre, "")

        If (Not Char.IsLetter(TxtSNombre.Text)) Then
            ErrorProvider1.SetError(TxtSNombre, "digite solo letras")
            TxtSNombre.Clear()
            TxtSNombre.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtSNombre, "")

        If (Not Char.IsLetter(TxtPApellido.Text)) Then
            ErrorProvider1.SetError(TxtPApellido, "digite solo letras")
            TxtPApellido.Clear()
            TxtPApellido.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtPApellido, "")

        If (Not Char.IsLetter(TxtSApellido.Text)) Then
            ErrorProvider1.SetError(TxtSApellido, "digite solo letras")
            TxtSApellido.Clear()
            TxtSApellido.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtSApellido, "")

        If (Not IsNumeric(TxtCedula.Text)) Then
            ErrorProvider1.SetError(TxtCedula, "solo se ingresa numeros")
            TxtCedula.Text = ""
            TxtCedula.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtCedula, "")

        If (Not Char.IsLetter(TxtCorreo.Text)) Then
            ErrorProvider1.SetError(TxtCorreo, "digite solo letras")
            TxtCorreo.Clear()
            TxtCorreo.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtCorreo, "")

        If TxtContraseña.Text = "" Then
            ErrorProvider1.SetError(TxtContraseña, "digite la contraseña")
            TxtContraseña.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtContraseña, "")

        If TxtReContraseña.Text = "" Then
            ErrorProvider1.SetError(TxtReContraseña, "tiene que repetir la contraseña")
            TxtReContraseña.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtReContraseña, "")

        If TxtContraseña.Text <> TxtReContraseña.Text Then
            ErrorProvider1.SetError(TxtReContraseña, "la contraseñas no coinciden")
            TxtReContraseña.Text = ""
            TxtReContraseña.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtReContraseña, "")


        Dim _conexion As New FuncionInsertar
        Dim DatosUsuarios As New Datos_Usuario

        DatosUsuarios.Primer_nombre = TxtPNombre.Text
        DatosUsuarios.segundo_nombre = TxtSNombre.Text
        DatosUsuarios.Primer_apellido = TxtPApellido.Text
        DatosUsuarios.segundo_apellido = TxtSApellido.Text
        DatosUsuarios.cedula = Convert.ToDouble(TxtCedula.Text)
        DatosUsuarios.usuario = TxtUsuario.Text
        DatosUsuarios.correo = TxtCorreo.Text
        DatosUsuarios.contrasena = TxtContraseña.Text
        DatosUsuarios.repetir_contrasena = TxtReContraseña.Text

        Dim rest As String
        If _conexion.InsertarDatos(DatosUsuarios) Then
            rest = MessageBox.Show("datos guardados", "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If rest = DialogResult.OK Then
                CargarDatos()
                Close()
                Inicio_Seccion.Show()
            End If
        Else
            rest = MessageBox.Show("datos no guardados", "no se guardo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Inicio_Seccion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub
End Class