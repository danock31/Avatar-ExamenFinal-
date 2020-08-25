Imports Clase_Negocios
Public Class Personas
    Inherits System.Web.UI.Page
    Dim obj_personas As New Clase_Personas
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Try
            obj_personas.idPersona = TxtIdentificacion.Text
            obj_personas.Nombre = TxtNombre.Text
            obj_personas.Apellido1 = TxtApellido1.Text
            obj_personas.Apellido2 = TxtApellido2.Text
            obj_personas.Telefono = TxtTelefono.Text
            obj_personas.Correo = TxtCorreo.Text
            obj_personas.idRol = DropDownList2.SelectedValue
            obj_personas.Carrera = DropDownList1.SelectedValue
            obj_personas.validarPersona()
            obj_personas.AgregarPersonas()
            obj_personas.AgregarEstudiantes()
            obj_personas.AgregarRolesPersonas()


        Catch ex As Exception
            LblMensaje.Text = ex.Message
        End Try

    End Sub
End Class