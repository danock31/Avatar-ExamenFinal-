<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="Avatar_ExamenFinal_.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 150px;
        }
        .auto-style2 {
            width: 682px;
        }
        .auto-style3 {
            width: 342px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="53px" ImageUrl="~/Imagenes/descarga1.png" Width="93px" />
            <asp:Label ID="lblUsuario" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="espacio" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Tipo de Usuario : "></asp:Label>
            <asp:Label ID="lblRol" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:ImageButton ID="BtnMatricula" runat="server" Height="99px" ImageUrl="~/Imagenes/mat-buttons.png" Width="100px" />
                    </td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="89px" ImageUrl="~/Imagenes/images (1).png" Width="98px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnAgregarPersona" runat="server" Height="74px" ImageUrl="~/Imagenes/descarga.png" Width="84px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
