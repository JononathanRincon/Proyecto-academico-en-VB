Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Datos_Usuario
    Private _id As Integer
    Private _primer_nombre As String
    Private _segundo_nombre As String
    Private _primer_apellido As String
    Private _segundo_apellido As String
    Private _cedula As Double
    Private _usuario As String
    Private _correo As String
    Private _contrasena As String
    Private _repetir_contrasena

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property Primer_nombre() As String
        Get
            Return _primer_nombre
        End Get
        Set(ByVal value As String)
            _primer_nombre = value
        End Set
    End Property

    Public Property segundo_nombre() As String
        Get
            Return _segundo_nombre
        End Get
        Set(ByVal value As String)
            _segundo_nombre = value
        End Set
    End Property

    Public Property Primer_apellido() As String
        Get
            Return _primer_apellido
        End Get
        Set(ByVal value As String)
            _primer_apellido = value
        End Set
    End Property

    Public Property segundo_apellido() As String
        Get
            Return _segundo_apellido
        End Get
        Set(ByVal value As String)
            _segundo_apellido = value
        End Set
    End Property

    Public Property cedula() As Double
        Get
            Return _cedula
        End Get
        Set(ByVal value As Double)
            _cedula = value
        End Set
    End Property

    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Public Property contrasena() As String
        Get
            Return _contrasena
        End Get
        Set(ByVal value As String)
            _contrasena = value
        End Set
    End Property

    Public Property repetir_contrasena() As String
        Get
            Return _repetir_contrasena
        End Get
        Set(ByVal value As String)
            _repetir_contrasena = value
        End Set
    End Property

End Class
