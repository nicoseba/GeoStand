<%@ Page Title="Busqueda Publicaciones" Language="C#" MasterPageFile="~/paginas-maestras/home.Master" AutoEventWireup="true" CodeBehind="busquedaPublicaciones.aspx.cs" Inherits="GeoStand.views.busquedaPublicaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .wrap {
            width: 75%;
            max-width: 1250px;
            margin: 0px auto;
        }

        .loading {
            position: fixed;
            top: 0px;
            right: 0px;
            bottom: 0px;
            left: 0px;
            display: flex;
            justify-content: center;
            align-items: center;
            background-color: rgba(0, 0, 0, .7);
            z-index: 2;
        }

        .img-loading {
            width: 50%;
            height: 50%;
            background-image: url('../images/loading1.gif');
            background-repeat: no-repeat;
            background-position: center;
            opacity: 1;
        }

        .txt-area-edit {
            width: 100%;
            min-height: 400px;
        }
    </style>
</asp:Content>
<asp:Content ID="CphContent" ContentPlaceHolderID="CphContent" runat="server">

    <div class="wrapp" runat="server">
        <asp:ScriptManager ID="ScrMng1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdPanel1" runat="server">
            <ContentTemplate>
                <asp:Panel runat="server" ID="PublicationSearch">
                    <table style="width: 100%;">
                        <tr>
                            <td style="width: 33%; text-align: end">Ingresa el codigo de la publicacion a ver:</td>
                            <td style="width: 33%;">
                                <asp:TextBox runat="server" Width="100%" ID="TxtIdSearch" />
                            </td>
                            <td style="width: 33%;">
                                <asp:RequiredFieldValidator ID="ReqSearch" runat="server" ControlToValidate="TxtIdSearch" ErrorMessage="No puede quedar vacio." ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ControlToValidate="TxtIdSearch" ForeColor="Red" ValidationExpression="^\d+" ErrorMessage="Ingrese solo numeros."></asp:RegularExpressionValidator>

                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: center">
                                <asp:Button Text="Buscar" runat="server" ID="BtnSearchPublication" OnClick="BtnSearchPublication_Click" CssClass="btn btn-login" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel runat="server" ID="PublicationView" Visible="false">
                    <table style="width: 100%;">
                        <tr>
                            <td style="text-align: center">
                                <asp:Label Text="" runat="server" ID="TitlePublication" />
                                <asp:HiddenField ID="HdnIDPublication" runat="server" />
                                <p>
                                    Escrito por
                                    <asp:Label Text="" runat="server" ID="UserPublication" />
                                    <asp:LinkButton ID="UserPublication1" runat="server" OnClick="UserPublication1_Click" CausesValidation="false">Ver Perfil</asp:LinkButton>
                                </p>
                                <asp:HiddenField ID="HdnUser" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <asp:Image ID="ImgPublication" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: justify">
                                <asp:Label Text="" runat="server" ID="ContentPublication" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <asp:Button Text="Editar" runat="server" ID="BtnEditPublication" CssClass="btn btn-login" OnClick="BtnEditPublication_Click" />

                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel runat="server" ID="PanelMsg" Visible="false">
                    <table style="width: 100%;">
                        <tr>
                            <td style="text-align: center; color: red; font-weight: bold">
                                <asp:Label Text="Publicacion No Encontrada" ID="LblMsg" runat="server" />

                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel runat="server" ID="PublicationEdit" Visible="false">
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 15%">Titulo:</td>
                            <td style="width: 40%">
                                <asp:TextBox ID="TxtTitle" runat="server" Width="100%" />
                                <asp:HiddenField ID="HdnPublicationEdit" runat="server" />
                            </td>
                            <td style="width: 25%">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El titulo no puede quedar en blanco" ControlToValidate="TxtTitle" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Contenido</td>
                            <td>
                                <asp:TextBox runat="server" TextMode="MultiLine" ID="TxtContent" CssClass="txt-area-edit" />
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="El contenido no puede quedar en blanco" ControlToValidate="TxtContent" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Url Imagen</td>
                            <td>
                                <asp:TextBox runat="server" ID="TxtUrl" Width="80%" /></td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="La URL no puede quedar en blanco" ControlToValidate="TxtUrl" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Url no valida" Display="Dynamic" ControlToValidate="TxtUrl" ForeColor="Red" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: center">
                                <asp:Button Text="Confirmar" ID="BtnConfirm" CssClass="btn btn-login" runat="server" OnClick="BtnConfirm_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="UpdPanel1" runat="server">
            <ProgressTemplate>
                <div class="loading">
                    <div class="img-loading">
                    </div>
                </div>

            </ProgressTemplate>
        </asp:UpdateProgress>
    </div>
</asp:Content>
