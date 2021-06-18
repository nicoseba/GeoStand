<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="GeoStand.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="¡Pudiste ingresar de pana! "></asp:Label>
            <asp:LinkButton ID="LinkSrc" runat="server" OnClick="LinkSrc_Click">Ahora busca algo</asp:LinkButton>
        </div>
    </form>
</body>
</html>
