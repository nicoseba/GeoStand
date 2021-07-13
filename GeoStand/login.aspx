<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GeoStand.class.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 46%;
            height: 108px;
            margin-left: 167px;
        }
        .auto-style2 {
            width: 122px;
        }
        .auto-style3 {
            width: 191px;
        }
        .auto-style4 {
            width: 122px;
            height: 26px;
        }
        .auto-style5 {
            width: 191px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Nombre de Usuario</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtUser" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">Contraseña</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="BtnLogin" runat="server" Text="INGRESAR" Width="129px" OnClick="BtnLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="LblMessage" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
