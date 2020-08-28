<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Avatar_ExamenFinal_.Login" %>


<!DOCTYPE html>
<meta charset=”utf-8″>
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">

<link href=”style/css/bootstrap.min.css” rel=”stylesheet”>
<link href="Estilos.css" rel="stylesheet" /> 

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 44%;
            height: 111px;
        }
        .auto-style4 {
            width: 81px;
        }
        .auto-style5 {
            width: 87px;
        }
        .auto-style6 {
            width: 58px;
        }
    </style>
</head>
<body>

    
<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <ul class="navbar-nav">
    <li class="nav-item active">
      <a class="nav-link" href="#">Depreciaciones</a>
    </li>
   
  </ul>
</nav>


    <form id="form1" runat="server">


        <div class="text-center">


<div class="container">
  <div class="row p-2">
       <div class="col-4">

        </div>

       <div class="col-2 text-right">
            <asp:Label ID="LblUser" runat="server" Text="Usuario:" CssClass="etiquetas"></asp:Label>
        </div>

      
       <div class="col-2">
             <asp:TextBox ID="TxtUsuario" runat="server"  CssClass="Textos" TextMode="Password"></asp:TextBox>    
        </div>

       <div class="col-4">

        </div>

       
  </div>


      <div class="row  p-2">
       <div class="col-4">

        </div>

       <div class="col-2 text-right">
             <asp:Label ID="LblClave" runat="server" Text="Contraseña:" CssClass="etiquetas"></asp:Label>
        </div>

      
       <div class="col-2">
             <asp:TextBox ID="TxtContraseña" runat="server" CssClass="Textos" TextMode="Password"></asp:TextBox> 
        </div>

       <div class="col-4">

        </div>

       
  </div>


      <div class="row">
       <div class="col-6">

        </div>


       <div class="col-2 text-left">
              <asp:Button type="button" class="btn btn-dark"  ID="BtnIniciar" runat="server" Text="Iniciar" />
              <asp:Label ID="LblMensaje" runat="server"></asp:Label>
        </div>

       <div class="col-4">

        </div>

       
  </div>


 



</div>

          
         
                       

                     
 
                       
                      
        </div>

        <div class="text-center">
            <table class="auto-style3">
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style5">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AvatarConnectionString %>" SelectCommand="consultaUsuario" SelectCommandType="StoredProcedure">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TxtUsuario" Name="usuario" PropertyName="Text" Type="String" />
                                <asp:ControlParameter ControlID="TxtContraseña" Name="contraseña" PropertyName="Text" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    
    </form>
</body>

<script src=”style/js/jquery-3.3.1.min.js”></script>
<script src=”style/js/popper.min.js”></script>
<script src=”style/js/bootstrap.min.js”></script>

</html>