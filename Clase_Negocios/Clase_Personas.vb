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


    Dim _idcursos As Integer
    Dim _codCurso As String
    Dim _descripcion As String
    Dim _cupo As String
    Dim _costo As String

    Dim _idHorario As Integer
    Dim _Dia As String
    Dim _hora As String

    Dim _CantidadMaterias As Integer

    Dim _TablaRol As New DataTable
    Dim _TablaPersonas As New DataTable
    Dim _TablaEstudiantes As New DataTable
    Dim _TablaUsuarios As New DataTable
    Dim _TablaHorariosMaterias As New DataTable
    Dim _TablaComfirmacion As New DataTable
    Dim _TablaMatricula As New DataTable

    Public Property CantidadMaterias() As String
        Get
            Return _CantidadMaterias
        End Get
        Set(ByVal value As String)
            _CantidadMaterias = value
        End Set
    End Property

    Public Property idHorario() As String
        Get
            Return _idHorario
        End Get
        Set(ByVal value As String)
            _idHorario = value
        End Set
    End Property

    Public Property Dia() As String
        Get
            Return _Dia
        End Get
        Set(ByVal value As String)
            _Dia = value
        End Set
    End Property

    Public Property Hora() As String
        Get
            Return _hora
        End Get
        Set(ByVal value As String)
            _hora = value
        End Set
    End Property

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

    Public Property idCurso() As String
        Get
            Return _idcursos
        End Get
        Set(ByVal value As String)
            _idcursos = value
        End Set
    End Property
    Public Property CodCurso() As String
        Get
            Return _codCurso
        End Get
        Set(ByVal value As String)
            _codCurso = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Cupo() As String
        Get
            Return _cupo
        End Get
        Set(ByVal value As String)
            _cupo = value
        End Set
    End Property
    Public Property Costo() As String
        Get
            Return _costo
        End Get
        Set(ByVal value As String)
            _costo = value
        End Set
    End Property

    Public Property Tabla_Matricula As DataTable
        Get
            Return _TablaMatricula
        End Get
        Set(value As DataTable)
            _TablaMatricula = value
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

    Public Property Tabla_HorariosMaterias As DataTable
        Get
            Return _TablaHorariosMaterias
        End Get
        Set(value As DataTable)
            _TablaHorariosMaterias = value
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

    Public Property Tabla_Usuarios As DataTable
        Get
            Return _TablaUsuarios
        End Get
        Set(value As DataTable)
            _TablaUsuarios = value
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

    Public Property Tabla_Comfirmacion As DataTable
        Get
            Return _TablaComfirmacion
        End Get
        Set(value As DataTable)
            _TablaComfirmacion = value
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

    Public Sub AgregarHorarioPersonas()
        Dim Fila As DataRow
        Dim obj_activosDB As New Clase_Datos
        Fila = obj_activosDB.Tabla_HorariosMaterias.NewRow

        Fila(0) = _idHorario
        Fila(1) = _idcursos
        Fila(2) = _idPersona

        obj_activosDB.Fila = Fila
        obj_activosDB.AgregarHorarioMateria()

    End Sub

    Public Sub AgregarUsuarios()
        Dim Fila As DataRow
        Dim obj_activosDB As New Clase_Datos
        Fila = obj_activosDB.Tabla_Usuarios.NewRow

        Fila(0) = _usuario
        Fila(1) = _contraseña
        Fila(2) = _idPersona

        obj_activosDB.Fila = Fila
        obj_activosDB.AgregarUsuarios()

    End Sub
    Public Sub AgregarMatricula()
        Dim Fila As DataRow
        Dim obj_activosDB As New Clase_Datos
        Fila = obj_activosDB.Tabla_Matricula.NewRow

        Fila(0) = _idPersona
        Fila(1) = _Carrera
        Fila(2) = _CantidadMaterias
        Fila(3) = "N"

        obj_activosDB.Fila = Fila
        obj_activosDB.AgregarMatricula()

    End Sub
    Public Sub BuscaPersona()
        Dim obj_activosDB As New Clase_Datos

        obj_activosDB.BuscarPersona(_idPersona)

        _idPersona = obj_activosDB.Tabla_Personas.Rows(0).Item(0)
        _nombre = obj_activosDB.Tabla_Personas.Rows(0).Item(1)
        _apellido1 = obj_activosDB.Tabla_Personas.Rows(0).Item(2)
        _apellido2 = obj_activosDB.Tabla_Personas.Rows(0).Item(3)
        _telefono = obj_activosDB.Tabla_Personas.Rows(0).Item(4)
        _correo = obj_activosDB.Tabla_Personas.Rows(0).Item(5)

    End Sub

    Public Sub BuscaCarrera()
        Dim obj_activosDB As New Clase_Datos

        obj_activosDB.BuscarMaterias(_Carrera)

        _idcursos = obj_activosDB.Tabla_Materias.Rows(0).Item(0)
        _codCurso = obj_activosDB.Tabla_Materias.Rows(0).Item(1)
        _descripcion = obj_activosDB.Tabla_Materias.Rows(0).Item(2)
        _cupo = obj_activosDB.Tabla_Materias.Rows(0).Item(3)
        _costo = obj_activosDB.Tabla_Materias.Rows(0).Item(4)
        _Carrera = obj_activosDB.Tabla_Materias.Rows(0).Item(5)



    End Sub
    Public Sub BuscaCarrera1()
        Dim obj_activosDB As New Clase_Datos

        obj_activosDB.BuscarMaterias(_Carrera)
        _idcursos = obj_activosDB.Tabla_Materias.Rows(1).Item(0)
        _codCurso = obj_activosDB.Tabla_Materias.Rows(1).Item(1)
        _descripcion = obj_activosDB.Tabla_Materias.Rows(1).Item(2)
        _cupo = obj_activosDB.Tabla_Materias.Rows(1).Item(3)
        _costo = obj_activosDB.Tabla_Materias.Rows(1).Item(4)
        _Carrera = obj_activosDB.Tabla_Materias.Rows(1).Item(5)

    End Sub
    Public Sub BuscaCarrera2()
        Dim obj_activosDB As New Clase_Datos

        obj_activosDB.BuscarMaterias(_Carrera)
        _idcursos = obj_activosDB.Tabla_Materias.Rows(2).Item(0)
        _codCurso = obj_activosDB.Tabla_Materias.Rows(2).Item(1)
        _descripcion = obj_activosDB.Tabla_Materias.Rows(2).Item(2)
        _cupo = obj_activosDB.Tabla_Materias.Rows(2).Item(3)
        _costo = obj_activosDB.Tabla_Materias.Rows(2).Item(4)
        _Carrera = obj_activosDB.Tabla_Materias.Rows(2).Item(5)

    End Sub
    Public Sub BuscaCarrera3()
        Dim obj_activosDB As New Clase_Datos

        obj_activosDB.BuscarMaterias(_Carrera)
        _idcursos = obj_activosDB.Tabla_Materias.Rows(3).Item(0)
        _codCurso = obj_activosDB.Tabla_Materias.Rows(3).Item(1)
        _descripcion = obj_activosDB.Tabla_Materias.Rows(3).Item(2)
        _cupo = obj_activosDB.Tabla_Materias.Rows(3).Item(3)
        _costo = obj_activosDB.Tabla_Materias.Rows(3).Item(4)
        _Carrera = obj_activosDB.Tabla_Materias.Rows(3).Item(5)

    End Sub
    Public Sub BuscaCarrera4()
        Dim obj_activosDB As New Clase_Datos
        obj_activosDB.BuscarMaterias(_Carrera)
        _idcursos = obj_activosDB.Tabla_Materias.Rows(4).Item(0)
        _codCurso = obj_activosDB.Tabla_Materias.Rows(4).Item(1)
        _descripcion = obj_activosDB.Tabla_Materias.Rows(4).Item(2)
        _cupo = obj_activosDB.Tabla_Materias.Rows(4).Item(3)
        _costo = obj_activosDB.Tabla_Materias.Rows(4).Item(4)
        _Carrera = obj_activosDB.Tabla_Materias.Rows(4).Item(5)

    End Sub
    Public Sub BuscaMeterias()
        Dim obj_activosDB As New Clase_Datos

        obj_activosDB.BuscarHorarioMaterias(_idPersona)

        _TablaComfirmacion = obj_activosDB.Tabla_Comfirmacion

    End Sub

    Public Sub ModificaMatricula()
        Dim fila As DataRow
        Dim obj_activosDB As New Clase_Datos

        fila = obj_activosDB.Tabla_Matricula.NewRow

        fila(3) = "S"



        obj_activosDB.Fila = fila
        obj_activosDB.ModificaMatricula()

    End Sub

End Class
