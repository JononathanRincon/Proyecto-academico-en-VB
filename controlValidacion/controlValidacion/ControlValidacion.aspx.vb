Imports System.Data.SqlClient
Imports controlValidacion.persona.PersonaDataTable
Imports System.Data

Public Class ControlValidacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Conexion()

    End Sub

    Dim conn As New SqlConnection(My.Settings.Conexion)

    Private Sub Conexion()
        Try
            conn.Open()
            'MsgBox("Conexión realizada exitosamente")
            conn.Close()
        Catch ex As Exception
            ' MsgBox("No fue posible realizar conexión")
        End Try

    End Sub


    Protected Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNombre.Text = "" Then
            MsgBox("Ingrese el nombre")
            TxtNombre.Focus()
            Return

        End If

        If TxtApellido.Text = "" Then
            MsgBox("Ingrese el apellido")
            TxtApellido.Focus()
            Return

        End If


        If TxtCorreo.Text = "" Then
            MsgBox("Ingrese el correo")
            TxtCorreo.Focus()
            Return

        End If

        Try
            Dim sql As String = "INSERT INTO Persona VALUES(@Nombre, @Apellido, @Nacionalidad, @Estado Civil, @Correo Electronico)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.CommandType = CommandType.Text

            cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
            cmd.Parameters.AddWithValue("@Nacionalidad", CbxNcionalidad.SelectedItem)
            cmd.Parameters.AddWithValue("@Estadocivil", Cbxestado.SelectedItem)
            cmd.Parameters.AddWithValue("@CorreoElectronico", TxtCorreo.Text)
            cmd.CommandType = CommandType.Text

            Dim sql1 As String = "SELECT * FROM [Persona]"
            Dim cmd1 As New SqlCommand(sql1, conn)
            Dim ds As New SqlDataAdapter(cmd1)
            Dim da As New DataSet
            ds.Fill(da, "Persona")
            Me.GridView1.DataSource = da.Tables("Persona")
            conn.Open()
            cmd1.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            conn.Close()

            MsgBox("Usuario registrado correctamente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class