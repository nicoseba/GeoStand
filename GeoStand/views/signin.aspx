<%@ Page Title="Registro" Language="C#" MasterPageFile="~/paginas-maestras/SecondMaster.Master" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="GeoStand.views.signin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CphContent" runat="server">
     <div class="body-form">
        <asp:Panel runat="server" CssClass="form-login">
            <h2>Registro</h2>
            <div class="form-login-section"><!--username-->
                <asp:Label Text="Nombre de usuario." runat="server" CssClass="login-label" />
                <asp:TextBox ID="TxtUsername" runat="server" CssClass="login-txt"></asp:TextBox>
                <asp:RequiredFieldValidator ID="TxtRequiredUsername" ControlToValidate="TxtUsername" Display="Dynamic" runat="server" ErrorMessage="Campo Obligatorio" CssClass="login-validate" ></asp:RequiredFieldValidator>
            </div>
            <div class="form-login-section"><!--nombre-->
                <asp:Label Text="Nombre." runat="server" CssClass="login-label" />
                <asp:TextBox runat="server" ID="TxtName" CssClass="login-txt"/>
                <asp:RequiredFieldValidator ID="TxtRequiredName" ErrorMessage="Campo Obligatorio" Display="Dynamic" ControlToValidate="TxtName" runat="server" CssClass="login-validate"/>
            </div>
            <div class="form-login-section"><!--correo-->
                <asp:Label Text="Correo." runat="server" CssClass="login-label" />
                <asp:TextBox runat="server" ID="TxtMail" CssClass="login-txt"/>
                <asp:RequiredFieldValidator ID="TxtRequiredMail" ErrorMessage="Campo Obligatorio" Display="Dynamic" ControlToValidate="TxtMail" runat="server" CssClass="login-validate"/>
                <asp:RegularExpressionValidator ID="TxtRegExMail" runat="server" ControlToValidate="TxtMail" Display="Dynamic" ErrorMessage="Formato de correo no valido." CssClass="login-validate" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-login-section"><!--contraseña-->
                <asp:Label Text="Contraseña." runat="server" CssClass="login-label" />
                <asp:TextBox ID="TxtPass" TextMode="Password" runat="server" CssClass="login-txt" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="TxtRequiredPass" ControlToValidate="TxtPass" Display="Dynamic" runat="server" ErrorMessage="Campo Obligatorio" CssClass="login-validate" ></asp:RequiredFieldValidator>
            </div>
            <div class="form-login-section"><!--contraseña2-->
                <asp:Label Text="Repita la Contraseña." runat="server" CssClass="login-label" />
                <asp:TextBox ID="TxtPass2" TextMode="Password" runat="server" CssClass="login-txt" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtPass2" Display="Dynamic" runat="server" ErrorMessage="Campo Obligatorio" CssClass="login-validate" ></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="TxtComparePass" runat="server" Display="Dynamic" ErrorMessage="Las contraseñas no coinciden" ControlToValidate="TxtPass2" ControlToCompare="TxtPass" CssClass="login-validate"></asp:CompareValidator>
            </div>
            <asp:Button ID="BtnLogin" Text="Registrarse" runat="server" CssClass="btn btn-login" OnClick="BtnLogin_Click" />
            <asp:Label Text="" runat="server"  ID="LblMessage" Visible="false" CssClass="login-validate" />
            <p>¿Ya tienes cuenta? <asp:LinkButton ID="LnkLogin" Text="Inicia Sesión." CausesValidation="false" runat="server" CssClass="form-link" OnClick="LnkLogin_Click"/></p>
            
        </asp:Panel>
    </div>
</asp:Content>
