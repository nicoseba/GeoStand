<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="GeoStand.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TxtSrc" runat="server" placeholder="Objeto a Buscar" ></asp:TextBox>
        <asp:Button ID="SrcButton" runat="server" Text="Buscar" OnClick="SrcButton_Click" /> <br/>
        <asp:Label ID="Lbmsj" runat="server" Text=""></asp:Label><br/>
        
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            
          <table class="auto-style1">
              <asp:HiddenField ID="HdnId" runat="server" />
                <tr>
                    <td colspan="2">Detalles del Usuario.</td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre:</td>
                    <td>
                        <asp:Label ID="LbUsername" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nombre de usuario:</td>
                    <td>
                        <asp:TextBox ID="TxUser" Enabled="false" runat="server"></asp:TextBox>
                    </td>
                </tr>
                            
                <tr>
                    <td class="auto-style2">Email:</td>
                    <td>
                        <asp:TextBox ID="TxEmail" Enabled="false" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style2">Rol:</td>
                    <td>
                        <asp:DropDownList ID="DropRole" Enabled="false" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:LinkButton ID="LnkEditar" runat="server" OnClick="LnkEditar_Click">Modificar</asp:LinkButton>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="BtnModificar" Visible="false" runat="server" Text="Modificar" OnClick="BtnModificar_Click" />
                        <br />
                        <asp:Label ID="LbMsj2" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Volver Home</asp:LinkButton>
    </form>
</body>
</html>
