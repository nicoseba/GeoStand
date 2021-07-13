<%@ Page Title="Ingreso" Language="C#" MasterPageFile="~/paginas-maestras/SecondMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GeoStand.views.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CphContent" runat="server" >
    <div class="body-form">
        <asp:Panel runat="server" CssClass="form-login">
            <h2>Esto es titulo de ingreso</h2>
            <div class="form-login-section">
                <asp:Label Text="Nombre de usuario" runat="server" CssClass="login-label" />
                <asp:TextBox ID="TxtUsername" runat="server" CssClass="login-txt"></asp:TextBox>
                <asp:RequiredFieldValidator ID="TxtRequiredUsername" ControlToValidate="TxtUsername" runat="server" ErrorMessage="Nombre de usuario obligatorio" CssClass="login-validate" ></asp:RequiredFieldValidator>
            </div>
            <div class="form-login-section">
                <asp:Label Text="Contraseña" runat="server" CssClass="login-label" />
                <asp:TextBox ID="TxtPass" TextMode="Password" runat="server" CssClass="login-txt" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="TxtRequiredPass" ControlToValidate="TxtPass" Display="Dynamic" runat="server" ErrorMessage="Contraseña obligatoria" CssClass="login-validate" ></asp:RequiredFieldValidator>
            </div>
            <asp:Button ID="BtnLogin" Text="Ingresar" runat="server" CssClass="btn btn-login" OnClick="BtnLogin_Click" />
            <asp:Label Text="" runat="server"  ID="LblMessage" Visible="false" CssClass="login-validate" />
            <p>No tienes cuenta. <asp:LinkButton ID="LnkSignin" Text="Registrate." CausesValidation="false" runat="server" CssClass="form-link" OnClick="LnkSignin_Click" /></p>
        </asp:Panel>
    </div>
</asp:Content>
