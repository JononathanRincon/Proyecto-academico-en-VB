Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Modificar
    Dim _adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim conexion As New MySqlConnection
    Dim datos2 As New DataTable

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim consulta, rest As String
        Dim lista As Byte

        If (Not Char.IsLetter(TxtUsuario1.Text)) Then
            ErrorProvider1.SetError(TxtUsuario1, "digite solo letras")
            TxtUsuario1.Clear()
            TxtUsuario1.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtUsuario1, "")

        If (Not IsNumeric(TxtCedula1.Text)) Then
            ErrorProvider1.SetError(TxtCedula1, "digite solo letras")
            TxtCedula1.Clear()
            TxtCedula1.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtCedula1, "")

        conexion.ConnectionString = "server = localhost;user id=root; password = 12345678; 
                        database = registro_usuarios;Sslmode=none"
        conexion.Open()
        If TxtCedula1.Text <> "" And TxtUsuario1.Text <> "" Then
            Conexion_Global()
            consulta = "select * from usuarios where usuario='" & TxtUsuario1.Text & "'and cedula='" & TxtCedula1.Text & "'"
            _adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            _adaptador.Fill(datos, "usuarios")
            lista = datos.Tables("usuarios").Rows.Count
        End If
        If lista <> 0 Then
            rest = MessageBox.Show("Desea modificar el usuario '" & TxtUsuario1.Text & "' presione 'SI'", "usuario correcto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rest = DialogResult.Yes Then
                GbxModificar.Enabled = True
                Try
                    consulta = "select * from usuarios where usuario='" & TxtUsuario1.Text & "'and cedula='" & TxtCedula1.Text & "'"
                    Dim comando As New MySqlCommand(consulta, conexion)

                    Dim conec As MySqlDataReader
                    conec = comando.ExecuteReader
                    If conec.Read() Then
                        Labelid.Text = conec.Item("id").ToString
                        TxtPNombre.Text = conec.Item("primer_nombre").ToString
                        TxtSNombre.Text = conec.Item("segundo_nombre").ToString
                        TxtPApellido.Text = conec.Item("primer_apellido").ToString
                        TxtSApellido.Text = conec.Item("segundo_apellido").ToString
                        TxtCedula.Text = conec.Item("cedula").ToString
                        TxtUsuario.Text = conec.Item("usuario").ToString
                        TxtCorreo.Text = conec.Item("correo").ToString
                        TxtContraseña.Text = conec.Item("contrasena").ToString
                        TxtReContraseña.Text = conec.Item("repetir_contrasena").ToString

                        conec.Close()
                    End If
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    conexion.Close()
                End Try

            End If
        Else
            MessageBox.Show("Digite bien el usuario", "usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtCedula1.Clear()
            TxtUsuario1.Clear()
        End If
        conexion.Close()

    End Sub


    Private Sub BtnGuardad_Click(sender As Object, e As EventArgs) Handles BtnGuardad.Click
        Dim conexion As New FuncionInsertar
        Dim datos As New Datos_Usuario
        Dim _conexion As New MySqlConnection


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



        If conexion.ActualizarDatos(datos) Then
            MessageBox.Show("datos actualizados", "datos actualizados")
            CargarDatos()
            Close()
            limpiar()
            Inicio_Seccion.Show()
        Else
            MessageBox.Show("datos no actualizados", "actualizar datos")
        End If

    End Sub

    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GbxModificar.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Inicio_Seccion.Show()
    End Sub

    Public Sub limpiar()
        TxtCedula.Clear()
        TxtCedula1.Clear()
        TxtContraseña.Clear()
        TxtCorreo.Clear()
        TxtReContraseña.Clear()
        TxtSApellido.Clear()
        TxtPApellido.Clear()
        TxtSNombre.Clear()
        TxtUsuario1.Clear()
        TxtUsuario.Clear()
        TxtPNombre.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class