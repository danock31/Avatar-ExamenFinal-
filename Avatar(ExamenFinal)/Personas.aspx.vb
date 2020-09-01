
Public Class Personas
    Inherits System.Web.UI.Page
    Dim obj_personas As New Clase_Negocios.Clase_Personas
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        espacio.Text = "      "
        lblUsuario.Text = Session("Usuario")
        espacio.Text = "      "
        lblRol.Text = Session("ID")
        If (lblUsuario.Text = "") Then
            Response.Redirect("Login.aspx")
        End If
        If (Session("ID") = 1) Then
            DropDownList3.Visible = False
            DropDownList1.Visible = True
        ElseIf (Session("ID") = 2) Then
            DropDownList2.Visible = False
            DropDownList1.Visible = True

        End If
        'If (DropDownList2.SelectedValue = 1) Then
        '    DropDownList1.Visible = False
        'End If
        'If (DropDownList2.SelectedValue = 2) Then
        '    DropDownList1.Visible = False
        'End If
        'If (DropDownList2.SelectedValue = 3) Then
        '    DropDownList1.Visible = False
        'End If
        'If (DropDownList2.SelectedValue = 4) Then
        '    DropDownList1.Visible = True
        'End If

    End Sub

    Protected Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Try
            If (Session("ID") = 1) Then

                obj_personas.idRol = DropDownList2.SelectedValue
            ElseIf (Session("ID") = 2) Then

                obj_personas.idRol = DropDownList3.SelectedValue

            End If

            If (DropDownList2.SelectedValue = 1) Then

                obj_personas.idPersona = TxtIdentificacion.Text
                obj_personas.Nombre = TxtNombre.Text
                obj_personas.Apellido1 = TxtApellido1.Text
                obj_personas.Apellido2 = TxtApellido2.Text
                obj_personas.Telefono = TxtTelefono.Text
                obj_personas.Correo = TxtCorreo.Text
                obj_personas.Carrera = 0
                obj_personas.validarPersona()
                obj_personas.AgregarPersonas()
                ''obj_personas.AgregarEstudiantes()
                obj_personas.AgregarRolesPersonas()
                Session("IdPersona") = TxtIdentificacion.Text
            ElseIf (DropDownList2.SelectedValue = 2) Then
                obj_personas.idPersona = TxtIdentificacion.Text
                obj_personas.Nombre = TxtNombre.Text
                obj_personas.Apellido1 = TxtApellido1.Text
                obj_personas.Apellido2 = TxtApellido2.Text
                obj_personas.Telefono = TxtTelefono.Text
                obj_personas.Correo = TxtCorreo.Text
                obj_personas.Carrera = 0
                obj_personas.validarPersona()
                obj_personas.AgregarPersonas()
                ''                obj_personas.AgregarEstudiantes()
                obj_personas.AgregarRolesPersonas()
                Session("IdPersona") = TxtIdentificacion.Text
            ElseIf (DropDownList2.SelectedValue = 3) Then
                obj_personas.idPersona = TxtIdentificacion.Text
                obj_personas.Nombre = TxtNombre.Text
                obj_personas.Apellido1 = TxtApellido1.Text
                obj_personas.Apellido2 = TxtApellido2.Text
                obj_personas.Telefono = TxtTelefono.Text
                obj_personas.Correo = TxtCorreo.Text
                obj_personas.Carrera = 0
                obj_personas.validarPersona()
                obj_personas.AgregarPersonas()
                ''                obj_personas.AgregarEstudiantes()
                obj_personas.AgregarRolesPersonas()
                Session("IdPersona") = TxtIdentificacion.Text
            ElseIf (DropDownList2.SelectedValue = 4) Then
                obj_personas.idPersona = TxtIdentificacion.Text
                obj_personas.Nombre = TxtNombre.Text
                obj_personas.Apellido1 = TxtApellido1.Text
                obj_personas.Apellido2 = TxtApellido2.Text
                obj_personas.Telefono = TxtTelefono.Text
                obj_personas.Correo = TxtCorreo.Text
                obj_personas.Carrera = DropDownList1.SelectedValue
                obj_personas.validarPersona()
                obj_personas.AgregarPersonas()
                obj_personas.AgregarEstudiantes()
                obj_personas.AgregarRolesPersonas()
                Session("IdPersona") = TxtIdentificacion.Text
            End If

            'obj_personas.idPersona = TxtIdentificacion.Text
            'obj_personas.Nombre = TxtNombre.Text
            'obj_personas.Apellido1 = TxtApellido1.Text
            'obj_personas.Apellido2 = TxtApellido2.Text
            'obj_personas.Telefono = TxtTelefono.Text
            'obj_personas.Correo = TxtCorreo.Text
            'obj_personas.idRol = DropDownList2.SelectedValue
            'obj_personas.Carrera = DropDownList1.SelectedValue
            'obj_personas.validarPersona()
            'obj_personas.AgregarPersonas()
            'obj_personas.AgregarEstudiantes()
            'obj_personas.AgregarRolesPersonas()


        Catch ex As Exception
            LblMensaje.Text = ex.Message
        End Try
        Response.Redirect("Usuarios.aspx")
    End Sub
End Class