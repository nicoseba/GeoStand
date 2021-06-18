<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="GeoStand.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <nav>
        <div>

            <asp:LinkButton ID="LinkSrc" runat="server" OnClick="LinkSrc_Click">Ahora busca algo</asp:LinkButton>

            <h3 class="auto-style1">GeoStand</h3>
        </div>
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server">Link1</asp:LinkButton>
        </div>
        <div>
            <asp:LinkButton ID="LnkLogin" runat="server" OnClick="LnkLogin_Click">Ingresar</asp:LinkButton><br />
            <asp:LinkButton ID="LnkSignin" runat="server" OnClick="LnkSignin_Click">Registrarse</asp:LinkButton><br />  
            <asp:LinkButton ID="LnkSession" runat="server" Visible="False" OnClick="LnkSession_Click">Cerrar Sesión</asp:LinkButton>
        </div>
    </nav>
        <div>
            <br />
            <asp:Label ID="LblMsg" runat="server" Text="Pagina principal sin iniciar Sesión"></asp:Label>
        </div>
    </form>
</body>
</html>
