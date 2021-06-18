<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="GeoStand.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TxtSrc" runat="server" placeholder="Objeto a Buscar" OnTextChanged="TxtSrc_TextChanged"></asp:TextBox>
        <asp:Button ID="SrcButton" runat="server" Text="Buscar" OnClick="SrcButton_Click" /> <br/>
        <asp:Label ID="Lbmsj" runat="server" Text=""></asp:Label>
        
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            
           Usuario: <asp:Label ID="LbUser" runat="server" Text=""></asp:Label><br />
           Nombre usuario: <asp:Label ID="LbUsername" runat="server" Text=""></asp:Label><br />
           Email: <asp:Label ID="LbEmail" runat="server" Text=""></asp:Label><br />
        </asp:Panel>
    </form>
</body>
</html>
