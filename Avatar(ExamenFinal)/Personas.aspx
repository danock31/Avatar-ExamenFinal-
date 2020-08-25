<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Personas.aspx.vb" Inherits="Avatar_ExamenFinal_.Personas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuario:
            <asp:Label ID="lblUsuario" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="espacio" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Tipo de Usuario : "></asp:Label>
            <asp:Label ID="lblRol" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Identificación"></asp:Label>
            <asp:TextBox ID="TxtIdentificacion" runat="server" Height="16px" Width="141px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TxtNombre" runat="server" Height="16px" Width="141px"></asp:TextBox>
            <br />
            Primer Apellido<asp:TextBox ID="TxtApellido1" runat="server" Height="16px" Width="141px"></asp:TextBox>
            <br />
            Segundo Apellido<asp:TextBox ID="TxtApellido2" runat="server" Height="16px" Width="141px"></asp:TextBox>
            <br />
            Telefono<asp:TextBox ID="TxtTelefono" runat="server" Height="16px" Width="141px"></asp:TextBox>
            <br />
            Correo<asp:TextBox ID="TxtCorreo" runat="server" Height="16px" Width="141px"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Rol"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="1">Administrador</asp:ListItem>
                <asp:ListItem Value="2">Administrativo</asp:ListItem>
                <asp:ListItem Value="3">Profesor</asp:ListItem>
                <asp:ListItem Value="4">Estudiante</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Carrera"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">Tecnologias de la Informacion</asp:ListItem>
                <asp:ListItem Value="2">Turismo</asp:ListItem>
                <asp:ListItem Value="3">Electronica</asp:ListItem>
                <asp:ListItem Value="0">Ninguna</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnSiguiente" runat="server" Height="28px" Text="Siguiente" Width="60px" />
            <br />
            <br />
            <asp:Label ID="LblMensaje" runat="server" CssClass="etiquetas"></asp:Label>
        </div>
    </form>
</body>
</html>
