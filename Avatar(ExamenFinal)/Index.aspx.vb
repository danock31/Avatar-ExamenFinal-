Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        espacio.Text = "      "
        lblUsuario.Text = Session("Usuario")
        espacio.Text = "      "
        lblRol.Text = Session("ID")
        If (lblUsuario.Text = "") Then
            Response.Redirect("Login.aspx")
        End If

        If (lblRol.Text = "1") Then
            lblRol.Text = "Administrador"
        ElseIf (lblRol.Text = "2") Then
            lblRol.Text = "Administrativo"
        ElseIf (lblRol.Text = "3") Then
            btnAgregarPersona.Visible = False
            lblRol.Text = "Profesor"
        ElseIf (lblRol.Text = "4") Then
            btnAgregarPersona.Visible = False
            lblRol.Text = "Estudiante"
        End If
    End Sub
    Protected Sub BtnMatricula_Click(sender As Object, e As ImageClickEventArgs) Handles BtnMatricula.Click
        Response.Redirect("Matricular.aspx")
    End Sub
    Protected Sub btnAgregarPersona_Click1(sender As Object, e As ImageClickEventArgs) Handles btnAgregarPersona.Click
        Response.Redirect("Personas.aspx")
    End Sub
End Class