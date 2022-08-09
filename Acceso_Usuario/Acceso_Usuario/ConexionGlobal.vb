Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module ConexionGlobal
    Public _cadena As String
    Public _conexion As New MySqlConnection 'se crea una instancia que va a establecer la
    'conexion a la bases de datos
    Public Function Conexion_Global() As Boolean
        Dim estado As Boolean = True
        'se realiza una excepcion, si la conexion a la bases de datos falla, sale 
        'un mensaje de error
        Try
            'en la variable _cadena se almacena toda la informacion del 
            'usuario del servidor, la contraseña y la bases de datos
            _cadena = ("server = localhost;user id=root; password = 12345678; 
                        database = registro_usuarios;Sslmode=none") 'Ssslmode=none es un protocolo de 
            _conexion = New MySqlConnection(_cadena)                'conexion .net con MySQL

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            estado = False
        End Try
        Return estado
    End Function
    'Metodo de cerrar la conexion a la bases de datos
    Public Sub Cerrar()
        _conexion.Close()
    End Sub

End Module
