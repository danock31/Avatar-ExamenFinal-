Imports Clase_DB
Public Class Clase_Personas
    Dim _idPersona As Integer
    Dim _nombre As String
    Dim _apellido1 As String
    Dim _apellido2 As String
    Dim _telefono As String
    Dim _correo As String
    Dim _Carrera As String

    Dim _idRol As Integer
    Dim _usuario As String
    Dim _contraseña As String

    Dim _TablaRol As New DataTable
    Dim _TablaPersonas As New DataTable
    Dim _TablaEstudiantes As New DataTable


    Public Property idPersona() As String
        Get
            Return _idPersona
        End Get
        Set(ByVal value As String)
            _idPersona = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido1() As String
        Get
            Return _apellido1
        End Get
        Set(ByVal value As String)
            _apellido1 = value
        End Set
    End Property

    Public Property Apellido2() As String
        Get
            Return _apellido2
        End Get
        Set(ByVal value As String)
            _apellido2 = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Public Property Carrera() As String
        Get
            Return _Carrera
        End Get
        Set(ByVal value As String)
            _Carrera = value
        End Set
    End Property

    Public Property idRol() As String
        Get
            Return _idRol
        End Get
        Set(ByVal value As String)
            _idRol = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property Contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Tabla_Personas As DataTable
        Get
            Return _TablaPersonas
        End Get
        Set(value As DataTable)
            _TablaPersonas = value
        End Set
    End Property

    Public Property Tabla_Estudiantes As DataTable
        Get
            Return _TablaEstudiantes
        End Get
        Set(value As DataTable)
            _TablaEstudiantes = value
        End Set
    End Property

    Public Property Tabla_Rol As DataTable
        Get
            Return _TablaRol
        End Get
        Set(value As DataTable)
            _TablaRol = value
        End Set
    End Property


    Public Sub validarPersona()
        If Not IsNumeric(_idPersona) Then
            Throw New System.Exception("La identificacion es incorrecto o ya se encuentra utilizado")
        End If

        If _nombre.Trim.Length = 0 Or IsNumeric(_nombre) Then
            Throw New System.Exception("El nombre del Estudiante es incorrecto!")
        End If

        If _apellido1.Trim.Length = 0 Or IsNumeric(_apellido1) Then
            Throw New System.Exception("El Primer Apellido del Estudiante es incorrecto!")
        End If

        If _apellido2.Trim.Length = 0 Or IsNumeric(_apellido2) Then
            Throw New System.Exception("El Segundo Apellido del Estudiante es incorrecto!")
        End If

        If _telefono.Trim.Length = 0 Then
            Throw New System.Exception("El telefono es incorrecto")
        End If

    End Sub

    Public Sub AgregarPersonas()
        Dim Fila As DataRow
        Dim obj_activosDB As New Clase_Datos
        Fila = obj_activosDB.Tabla_Personas.NewRow

        Fila(0) = _idPersona
        Fila(1) = _nombre
        Fila(2) = _apellido1
        Fila(3) = _apellido2
        Fila(4) = _telefono
        Fila(5) = _correo
        obj_activosDB.Fila = fila
        obj_activosDB.AgregarPersonas()

    End Sub

    Public Sub AgregarEstudiantes()
        Dim Fila As DataRow
        Dim obj_activosDB As New Clase_Datos
        Fila = obj_activosDB.Tabla_Estudiantes.NewRow

        Fila(0) = _idPersona
        Fila(1) = _Carrera

        obj_activosDB.Fila = Fila
        obj_activosDB.AgregarEstudiantes()

    End Sub

    Public Sub AgregarRolesPersonas()
        Dim Fila As DataRow
        Dim obj_activosDB As New Clase_Datos
        Fila = obj_activosDB.Tabla_Rol.NewRow

        Fila(0) = _idPersona
        Fila(1) = _idRol

        obj_activosDB.Fila = Fila
        obj_activosDB.AgregarPersonasRoles()

    End Sub

End Class
