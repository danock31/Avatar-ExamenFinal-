Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        espacio.Text = "      "
        lblUsuario.Text = Session("Usuario")
        espacio.Text = "      "
        lblRol.Text = Session("ID")
        If (lblRol.Text = "1") Then
            lblRol.Text = "Administrador"
        ElseIf (lblRol.Text = "2") Then
            lblRol.Text = "Administrativo"
        ElseIf (lblRol.Text = "3") Then
            lblRol.Text = "Profesor"
        ElseIf (lblRol.Text = "4") Then
            lblRol.Text = "Estudiante"
        End If
    End Sub

    Protected Sub btnAgregarPersona_Click(sender As Object, e As EventArgs) Handles btnAgregarPersona.Click
        Response.Redirect("Personas.aspx")
    End Sub
End Class