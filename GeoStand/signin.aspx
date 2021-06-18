<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="GeoStand.signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 45%;
            height: 120px;
            margin-left: 249px;
        }
        .auto-style3 {
            width: 379px;
        }
        .auto-style4 {
            width: 395px;
        }
        .auto-style5 {
            width: 503px;
            height: 43px;
            margin-left: 249px;
        }
        .auto-style6 {
            width: 395px;
            height: 26px;
        }
        .auto-style7 {
            width: 379px;
            height: 26px;
        }
    </style>
</head>
<body>
    <h1 class="auto-style5">Registro</h1>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Nombre de Usuario</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style4">Nombre</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtName" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style4">Correo</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtMail" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style6">Contraseña</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TxtPass" runat="server" TextMode="Password" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style4">Repita la contraseña</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TxtPassRepeat" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="BtnLogin" runat="server" Text="Registrarse" Width="129px" OnClick="BtnLogin_Click"/>
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
