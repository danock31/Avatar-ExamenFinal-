Imports System.Data
Imports System.Data.SqlClient
Public Class Clase_Datos
    Dim conexion As New SqlConnection("Data Source=DESKTOP-8353J2V\SERVER_PRINCIPAL; Integrated Security=SSPI; Initial Catalog=Avatar;")
    Dim _fila As DataRow
    Dim _TablaPersonas As New DataTable
    Dim _TablaEstudiantes As New DataTable
    Dim _TablaRol As New DataTable

    Sub New()
        'Inicializa la estructura de la tabla Productos
        EstructuraActivos()
    End Sub

    Public Property Fila As DataRow
        Get
            Return _fila
        End Get
        Set(value As DataRow)
            _fila = value
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

    Public Sub AgregarPersonas()
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("insert into Personas (idPersona, Nombre, apellido1,apellido2,telefono,Correo)  values  ( @idPersona, @Nombre, @apellido1,@apellido2,@telefono,@Correo)", conexion)

        Instruccion.Parameters.AddWithValue("@idPersona", _fila("idPersona"))
        Instruccion.Parameters.AddWithValue("@Nombre", _fila("Nombre"))
        Instruccion.Parameters.AddWithValue("@apellido1", _fila("apellido1"))
        Instruccion.Parameters.AddWithValue("@apellido2", _fila("apellido2"))
        Instruccion.Parameters.AddWithValue("@telefono", _fila("telefono"))
        Instruccion.Parameters.AddWithValue("@Correo", _fila("Correo"))

        'enviar la instruccion al SQL a ejecutar
        Instruccion.ExecuteNonQuery()

        conexion.Close()
    End Sub

    Public Sub AgregarEstudiantes()
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("insert into Carreras_Personas (idPersona, idCarrera)  values  ( @idPersona, @idCarrera)", conexion)

        Instruccion.Parameters.AddWithValue("@idPersona", _fila("idPersona"))
        Instruccion.Parameters.AddWithValue("@idCarrera", _fila("idCarrera"))

        'enviar la instruccion al SQL a ejecutar
        Instruccion.ExecuteNonQuery()

        conexion.Close()
    End Sub

    Public Sub AgregarPersonasRoles()
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("insert into Roles_Personas (idPersona, idrol)  values  ( @idPersona, @idrol)", conexion)

        Instruccion.Parameters.AddWithValue("@idPersona", _fila("idPersona"))
        Instruccion.Parameters.AddWithValue("@idrol", _fila("idrol"))

        'enviar la instruccion al SQL a ejecutar
        Instruccion.ExecuteNonQuery()

        conexion.Close()
    End Sub


    Private Sub EstructuraActivos()
        _TablaPersonas.Columns.Add(New DataColumn("idPersona", System.Type.GetType("System.Int32")))
        _TablaPersonas.Columns.Add(New DataColumn("Nombre", System.Type.GetType("System.String")))
        _TablaPersonas.Columns.Add(New DataColumn("apellido1", System.Type.GetType("System.String")))
        _TablaPersonas.Columns.Add(New DataColumn("apellido2", System.Type.GetType("System.String")))
        _TablaPersonas.Columns.Add(New DataColumn("telefono", System.Type.GetType("System.String")))
        _TablaPersonas.Columns.Add(New DataColumn("Correo", System.Type.GetType("System.String")))

        _TablaEstudiantes.Columns.Add(New DataColumn("idPersona", System.Type.GetType("System.Int32")))
        _TablaEstudiantes.Columns.Add(New DataColumn("idCarrera", System.Type.GetType("System.Int32")))


        _TablaRol.Columns.Add(New DataColumn("idPersona", System.Type.GetType("System.Int32")))
        _TablaRol.Columns.Add(New DataColumn("idrol", System.Type.GetType("System.Int32")))

    End Sub



End Class
