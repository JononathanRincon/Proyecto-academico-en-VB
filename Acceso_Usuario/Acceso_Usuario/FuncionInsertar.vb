Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class FuncionInsertar
    Private _adaptador As New MySqlDataAdapter
    Public Function InsertarDatos(ByVal datos As Datos_Usuario) As Boolean
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into usuarios (primer_nombre, segundo_nombre,
                                                         primer_apellido,segundo_apellido,cedula,usuario,correo,contrasena,
                                                        repetir_contrasena) values (@primer_nombre, @segundo_nombre,
                                                         @primer_apellido,@segundo_apellido,@cedula,@usuario,@correo,@contrasena,
                                                        @repetir_contrasena)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@primer_nombre", MySqlDbType.VarChar, 60).Value = datos.Primer_nombre
            _adaptador.InsertCommand.Parameters.Add("@segundo_nombre", MySqlDbType.VarChar, 60).Value = datos.segundo_nombre
            _adaptador.InsertCommand.Parameters.Add("@primer_apellido", MySqlDbType.VarChar, 60).Value = datos.Primer_apellido
            _adaptador.InsertCommand.Parameters.Add("@segundo_apellido", MySqlDbType.VarChar, 60).Value = datos.segundo_apellido
            _adaptador.InsertCommand.Parameters.Add("@cedula", MySqlDbType.Int32, 30).Value = datos.cedula
            _adaptador.InsertCommand.Parameters.Add("@usuario", MySqlDbType.VarChar, 40).Value = datos.usuario
            _adaptador.InsertCommand.Parameters.Add("@correo", MySqlDbType.VarChar, 40).Value = datos.correo
            _adaptador.InsertCommand.Parameters.Add("@contrasena", MySqlDbType.VarChar, 30).Value = datos.repetir_contrasena
            _adaptador.InsertCommand.Parameters.Add("@repetir_contrasena", MySqlDbType.VarChar, 30).Value = datos.repetir_contrasena
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            Cerrar()
        End Try
        Return estado
    End Function

    Public Function ActualizarDatos(ByVal datos As Datos_Usuario) As Boolean
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.UpdateCommand = New MySqlCommand("update usuarios set primer_nombre=@primer_nombre, segundo_nombre=@segundo_nombre,
                                                         primer_apellido=@primer_apellido, segundo_apellido=@segundo_apellido,
                                                        cedula=@cedula,usuario=@usuario,correo=@correo,contrasena=@contrasena,
                                                        repetir_contrasena=@repetir_contrasena where id=@id ", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Modificar.Labelid.Text
            _adaptador.UpdateCommand.Parameters.Add("@primer_nombre", MySqlDbType.VarChar).Value = Modificar.TxtPNombre.Text
            _adaptador.UpdateCommand.Parameters.Add("@segundo_nombre", MySqlDbType.VarChar).Value = Modificar.TxtSNombre.Text
            _adaptador.UpdateCommand.Parameters.Add("@primer_apellido", MySqlDbType.VarChar).Value = Modificar.TxtPApellido.Text
            _adaptador.UpdateCommand.Parameters.Add("@segundo_apellido", MySqlDbType.VarChar).Value = Modificar.TxtSApellido.Text
            _adaptador.UpdateCommand.Parameters.Add("@cedula", MySqlDbType.Int32).Value = Modificar.TxtCedula.Text
            _adaptador.UpdateCommand.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = Modificar.TxtUsuario.Text
            _adaptador.UpdateCommand.Parameters.Add("@correo", MySqlDbType.VarChar).Value = Modificar.TxtCorreo.Text
            _adaptador.UpdateCommand.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = Modificar.TxtContraseña.Text
            _adaptador.UpdateCommand.Parameters.Add("@repetir_contrasena", MySqlDbType.VarChar).Value = Modificar.TxtReContraseña.Text
            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            Cerrar()
        End Try
        Return estado
    End Function

    Public Function eliminardatos(ByVal datos As Datos_Usuario)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.DeleteCommand = New MySqlCommand("DELETE FROM usuarios Where contrasena=@contrasena", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = Borrar.TxtContraseña.Text
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            Cerrar()
        End Try
        Return estado
    End Function

End Class
