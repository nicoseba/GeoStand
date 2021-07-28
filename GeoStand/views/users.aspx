<%@ Page Title="" Language="C#" MasterPageFile="~/paginas-maestras/home.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="GeoStand.views.users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .wrap{
            width:75%;
            margin: 0px auto;
        }

        .msg{
            font-size: 40px;
            text-align:center;
            font-weight:800;
            font-family: sans-serif;
            color: red;
        }
        .panel-lateral-content {
            width: 200px;
        }

        .panel-lateral {
            display: flex;
            flex-direction: column;
            width: 100%;
            border: 1px solid #ccc;
        }

        .panel-lateral__links {
            display: block;
            text-decoration: none;
            background: #445a14;
            color: #d9ef9f;
            border-bottom: 1px solid #3a4d11;
            border-top: 1px solid #3a4d11;
            text-align: center;
            width: 100%;
            height: 30px;
            font-weight: 800;
            line-height: 30px;
        }

            .panel-lateral__links:hover {
                background: #3a4d11;
            }

        .panel {
            padding-left: 50px;
        }

        .list {
            list-style: disc;
        }

            .list li {
            }

                .list li a {
                    color: #3a4d11;
                }
        .panel-lnk-edit{
            text-align:right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CphContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server" ID="UpgratePanelUser">
        <ContentTemplate>
            <asp:Panel CssClass="wrap" runat="server" ID="PanelUser">
                <table style="width: 100%">
                    <tr>
                        <td colspan="2">
                            <div style="text-align: center">
                                <asp:Literal Text="" runat="server" ID="LiteralNombre" />
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="panel-lateral-content">
                            <asp:Panel runat="server" ID="LabelsLinks" CssClass="panel-lateral">
                                <asp:LinkButton Text="Publicaciones" runat="server" ID="LnkPublication" CssClass="panel-lateral__links" OnClick="LnkPublication_Click" />
                                <asp:LinkButton Text="Productos" runat="server" ID="LnkProducts" CssClass="panel-lateral__links" OnClick="LnkProducts_Click" />
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel runat="server">
                                <asp:Panel runat="server" ID="PanelPublication" CssClass="panel">
                                    <ul class="list">
                                        <asp:Literal Text="" runat="server" ID="PublicationList" />
                                    </ul>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="PanelProduct" Visible="false" CssClass="panel">
                                    <ul class="list">
                                        <asp:Literal Text="" runat="server" ID="ProductList" />
                                    </ul>
                                </asp:Panel>
                                <asp:Panel runat="server" ID="PanelLnkEdit" CssClass="panel-lnk-edit">
                                    <asp:LinkButton Text="Editar Perfil" runat="server" ID="EditPerfil" CssClass="btn btn-login"/>
                                </asp:Panel>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="wrap" ID="PanelError" Visible="false">
                <h2 class="msg">Usuario no encontrado</h2>
                <asp:LinkButton runat="server" ID="LnkHome" CssClass="btn btn-login" OnClick="LnkHome_Click" >Volver a Inicio</asp:LinkButton>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
