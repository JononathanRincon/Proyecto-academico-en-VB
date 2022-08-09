Imports MySql.Data.MySqlClient

Public Class Inicio_Seccion
    Dim _adaptador As MySqlDataAdapter
    Dim datos As DataSet
    Dim conexion As New MySqlConnection

    Public Sub Inicio_Seccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "server = localhost;user id=root; password = 12345678; 
                        database = registro_usuarios;Sslmode=none"
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT * FROM usuarios"
            _adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            datos.Tables.Add("usuarios")
            _adaptador.Fill(datos.Tables("usuarios"))
            CbxUsuario.DataSource = datos.Tables("usuarios")
            CbxUsuario.DisplayMember = "usuario"
            CbxUsuario.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    'inicio de seccion
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        Dim rest As String

        If CbxUsuario.Text = "" Then
            ErrorProvider1.SetError(CbxUsuario, "seleccione un usuario")
            CbxUsuario.Select()
            Return
        End If
        ErrorProvider1.SetError(CbxUsuario, "")

        If TxtContraseña.Text = "" Then
            ErrorProvider1.SetError(TxtContraseña, "escriba la  contraseña")
            TxtContraseña.Select()
            Return
        End If

        Dim consulta As String
        Dim lista As Byte
        If CbxUsuario.Text <> "" And TxtContraseña.Text <> "" Then

            consulta = "select * from usuarios where usuario='" & CbxUsuario.Text & "'and contrasena='" & TxtContraseña.Text & "'"
            _adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            _adaptador.Fill(datos, "usuarios")
            lista = datos.Tables("usuarios").Rows.Count
        End If
        If lista <> 0 Then
            rest = MessageBox.Show("contraseña Correcta, desea ingresar al programa", "contraseña correcta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If rest = DialogResult.Yes Then
                Programas.Show()
                Hide()
                CbxUsuario.Text = ""
                TxtContraseña.Text = ""
            End If
        Else
            MessageBox.Show("Intentero de nuevo", "contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtContraseña.Clear()
            CbxUsuario.ResetText()

        End If


    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Hide()
        Registro.Show()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Modificar.Show()
        Hide()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Borrar.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Mostrar_Datos.Show()
        Hide()
    End Sub
End Class
