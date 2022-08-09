Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Consultar
    Private _adaptador As New MySqlDataAdapter 'instancia de registro del origen de datos MySQL 
    Public _dtsdatos As New DataSet 'instancia que obtiene todos los datos 
    Public _dtvdatos As New DataView ' representa la conexion de los datos que se encuentran en una tabla
    'este metodo me hace devolver todos los datos que encuentran en la base de datos a un datagridview
    Public Sub consulta_datos()
        Try
            Conexion_Global() 'se llama el metodo de conexion de bases de datos
            _adaptador.SelectCommand = New MySqlCommand("select * from usuarios", _conexion) 'selecciona la 
            _adaptador.Fill(_dtsdatos) 'agrega unas finas al dataset                          la tabla
            _dtvdatos.Table = _dtsdatos.Tables(0)
            _conexion.Open() 'hable la conexion
            _adaptador.SelectCommand.Connection = _conexion
            _adaptador.SelectCommand.ExecuteNonQuery()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub CargarDatos()
        Dim _adaptador As New MySqlDataAdapter
        Dim datos As DataSet
        Dim conexion As New MySqlConnection
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
            Inicio_Seccion.CbxUsuario.DataSource = datos.Tables("usuarios")
            Inicio_Seccion.CbxUsuario.DisplayMember = "usuario"
            Inicio_Seccion.CbxUsuario.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
End Module
