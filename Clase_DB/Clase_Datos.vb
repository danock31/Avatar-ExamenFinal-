Imports System.Data
Imports System.Data.SqlClient
Public Class Clase_Datos
    Dim conexion As New SqlConnection("workstation id=DBAvatarFinal.mssql.somee.com;packet size=4096;user id=Danock31_SQLLogin_1;pwd=rs87wg4nxw;data source=DBAvatarFinal.mssql.somee.com;persist security info=False;initial catalog=DBAvatarFinal;")
    Dim _fila As DataRow
    Dim _TablaPersonas As New DataTable
    Dim _TablaEstudiantes As New DataTable
    Dim _TablaHorariosMaterias As New DataTable
    Dim _TablaRol As New DataTable
    Dim _TablaUsuarios As New DataTable
    Dim _contenedor As New DataSet
    Dim _TablaMeterias As New DataTable
    Dim _TablaComfirmacion As New DataTable
    Dim _TablaMatricula As New DataTable

    Sub New()
        'Inicializa la estructura de la tabla Productos
        Estructura()
    End Sub

    Public Property Fila As DataRow
        Get
            Return _fila
        End Get
        Set(value As DataRow)
            _fila = value
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

    Public Property Tabla_Comfirmacion As DataTable
        Get
            Return _TablaComfirmacion
        End Get
        Set(value As DataTable)
            _TablaComfirmacion = value
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

    Public Property Tabla_Usuarios As DataTable
        Get
            Return _TablaUsuarios
        End Get
        Set(value As DataTable)
            _TablaUsuarios = value
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


    Public Property Tabla_HorariosMaterias As DataTable
        Get
            Return _TablaHorariosMaterias
        End Get
        Set(value As DataTable)
            _TablaHorariosMaterias = value
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

    Public Property Tabla_Materias As DataTable
        Get
            Return _TablaMeterias
        End Get
        Set(value As DataTable)
            _TablaMeterias = value
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

    Public Sub AgregarUsuarios()
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("insert into Login_web (Usuario, Contraseña,idPersona)  values  ( @Usuario, @Contraseña, @idPersona)", conexion)

        Instruccion.Parameters.AddWithValue("@Usuario", _fila("Usuario"))
        Instruccion.Parameters.AddWithValue("@Contraseña", _fila("Contraseña"))
        Instruccion.Parameters.AddWithValue("@idPersona", _fila("idPersona"))

        'enviar la instruccion al SQL a ejecutar
        Instruccion.ExecuteNonQuery()

        conexion.Close()
    End Sub

    Sub BuscarPersona(idPersona As Integer)
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("Select * from Personas where idPersona=@idPersona", conexion)
        Instruccion.Parameters.AddWithValue("@idPersona", idPersona)

        Dim sqlDataAdapter As SqlClient.SqlDataAdapter

        sqlDataAdapter = New SqlClient.SqlDataAdapter(Instruccion)
        Try
            sqlDataAdapter.Fill(_contenedor)
            _TablaPersonas = _contenedor.Tables(0)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        conexion.Close()
    End Sub



    Sub BuscarMaterias(idCarrera As Integer)
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("Select * from Materia where idCarrera=@idCarrera", conexion)
        Instruccion.Parameters.AddWithValue("@idCarrera", idCarrera)

        Dim sqlDataAdapter As SqlClient.SqlDataAdapter

        sqlDataAdapter = New SqlClient.SqlDataAdapter(Instruccion)
        Try
            sqlDataAdapter.Fill(_contenedor)
            _TablaMeterias = _contenedor.Tables(0)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        conexion.Close()
    End Sub

    Public Sub AgregarHorarioMateria()
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("insert into Horario_Materia (idhorario, idcursos,idPersona)  values  ( @idhorario, @idcursos,@idPersona)", conexion)

        Instruccion.Parameters.AddWithValue("@idhorario", _fila("idhorario"))
        Instruccion.Parameters.AddWithValue("@idcursos", _fila("idcursos"))
        Instruccion.Parameters.AddWithValue("@idPersona", _fila("idPersona"))

        'enviar la instruccion al SQL a ejecutar
        Instruccion.ExecuteNonQuery()

        conexion.Close()
    End Sub
    Public Sub AgregarMatricula()
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("insert into Matricula (idPersona, idCarrera,CantidaMaterias,EstadoPago)  values  ( @idPersona, @idCarrera,@CantidaMaterias,@EstadoPago)", conexion)
        Instruccion.Parameters.AddWithValue("@idPersona", _fila("idPersona"))
        Instruccion.Parameters.AddWithValue("@idCarrera", _fila("idCarrera"))
        Instruccion.Parameters.AddWithValue("@CantidaMaterias", _fila("CantidaMaterias"))
        Instruccion.Parameters.AddWithValue("@EstadoPago", _fila("EstadoPago"))

        'enviar la instruccion al SQL a ejecutar
        Instruccion.ExecuteNonQuery()

        conexion.Close()
    End Sub

    Sub BuscarHorarioMaterias(idPersona As Integer)
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar 
        Instruccion = New SqlClient.SqlCommand("Select c.idPersona,a.CodCurso,a.descripcion,b.Dia,b.Hora,a.costo from Materia a,Horario b,Horario_Materia c where idPersona=@idPersona and c.idcursos=a.idcursos and b.idHorario=c.idHorario", conexion)
        Instruccion.Parameters.AddWithValue("@idPersona", idPersona)


        Dim sqlDataAdapter As SqlClient.SqlDataAdapter

        sqlDataAdapter = New SqlClient.SqlDataAdapter(Instruccion)
        Try
            sqlDataAdapter.Fill(_contenedor)
            _TablaComfirmacion = _contenedor.Tables(0)
        Catch ex As Exception
            Throw New System.Exception(ex.Message)
        End Try
        conexion.Close()

    End Sub
    Public Sub ModificaMatricula()
        Dim Instruccion As SqlClient.SqlCommand

        'inicia la conexion con el servidor de BD
        conexion.Open()

        'instruccion a ejecutar en este caso seria el update
        Instruccion = New SqlClient.SqlCommand("Update Matricula set EstadoPago = @EstadoPago", conexion)

        Instruccion.Parameters.AddWithValue("@EstadoPago", _fila("EstadoPago"))



        'enviar la instruccion al SQL a ejecutar
        Instruccion.ExecuteNonQuery()

        conexion.Close()
    End Sub


    Private Sub Estructura()
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

        _TablaHorariosMaterias.Columns.Add(New DataColumn("idHorario", System.Type.GetType("System.Int32")))
        _TablaHorariosMaterias.Columns.Add(New DataColumn("idcursos", System.Type.GetType("System.Int32")))
        _TablaHorariosMaterias.Columns.Add(New DataColumn("idPersona", System.Type.GetType("System.Int32")))

        _TablaUsuarios.Columns.Add(New DataColumn("Usuario", System.Type.GetType("System.String")))
        _TablaUsuarios.Columns.Add(New DataColumn("Contraseña", System.Type.GetType("System.String")))
        _TablaUsuarios.Columns.Add(New DataColumn("idPersona", System.Type.GetType("System.Int32")))

        _TablaMatricula.Columns.Add(New DataColumn("idPersona", System.Type.GetType("System.String")))
        _TablaMatricula.Columns.Add(New DataColumn("idCarrera", System.Type.GetType("System.String")))
        _TablaMatricula.Columns.Add(New DataColumn("CantidaMaterias", System.Type.GetType("System.Int32")))
        _TablaMatricula.Columns.Add(New DataColumn("EstadoPago", System.Type.GetType("System.String")))

        _TablaMeterias.Columns.Add(New DataColumn("idcursos", System.Type.GetType("System.Int32")))
        _TablaMeterias.Columns.Add(New DataColumn("codCurso", System.Type.GetType("System.String")))
        _TablaMeterias.Columns.Add(New DataColumn("descripcion", System.Type.GetType("System.String")))
        _TablaMeterias.Columns.Add(New DataColumn("Cupo", System.Type.GetType("System.String")))
        _TablaMeterias.Columns.Add(New DataColumn("Costo", System.Type.GetType("System.String")))
        _TablaMeterias.Columns.Add(New DataColumn("idCarrera", System.Type.GetType("System.Int32")))

        _TablaComfirmacion.Columns.Add(New DataColumn("idPersona", System.Type.GetType("System.Int32")))
        _TablaComfirmacion.Columns.Add(New DataColumn("codCurso", System.Type.GetType("System.String")))
        _TablaComfirmacion.Columns.Add(New DataColumn("descripcion", System.Type.GetType("System.String")))
        _TablaComfirmacion.Columns.Add(New DataColumn("Dia", System.Type.GetType("System.String")))
        _TablaComfirmacion.Columns.Add(New DataColumn("Hora", System.Type.GetType("System.String")))
        _TablaComfirmacion.Columns.Add(New DataColumn("Costo", System.Type.GetType("System.String")))


    End Sub



End Class
