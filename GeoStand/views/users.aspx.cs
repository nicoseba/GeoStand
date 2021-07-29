using GeoStand.controller;
using GeoStand.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GeoStand.views
{
    public partial class users : System.Web.UI.Page
    {
        private User ux;
        private List<Publication> publications;
        private List<Product> products;
        protected void Page_Load(object sender, EventArgs e)
        {


            string usId = Request.QueryString["uid"];
            if (!String.IsNullOrEmpty(usId))
            {
                int uid = int.Parse(usId);
                ux = UserController.findUser(uid);
                if (ux != null)
                {
                    LiteralNombre.Text = $"<h2>{ux.name}</h2>{Environment.NewLine}";
                    LiteralNombre.Text += $"<p><b>Registrado en: <b/>{ux.regist_date.ToString("dd/MM/yyyy")}</p>{Environment.NewLine}";
                    LiteralNombre.Text += $"<p><b>Rol: <b/>{ux.Role.name}</p>{Environment.NewLine}";
                    PublicationList.Text = generateListPublication(ux.id);
                    ProductList.Text = generateListProduct(ux.id);
                    PanelLnkEdit.Visible = sessionCheck(ux.id);

                }
                else
                {
                    PanelUser.Visible = false;
                    PanelError.Visible = true;
                    PanelLnkEdit.Visible = false;
                }

            }
            else
            {
                PanelUser.Visible = false;
                PanelError.Visible = true;
                PanelLnkEdit.Visible = false;
            }

        }

        private string generateListPublication(int uid)
        {
            string list = "";
            publications = PublicationController.listPublicationByUser(uid);
            if (publications.Count != 0)
            {

                list += $"<h3>Publicaciones hechas: {publications.Count} </h3>\n";
                foreach (Publication p in publications)
                {
                    list += $"<li><a href=\"busquedaPublicaciones.aspx?pid={p.id}\">{p.title}</a></li>\n";
                }
                return list;
            }
            else
            {
                return "<li>El Usuario no a escrito ninguna publicación.</li>";
            }

        }

        private bool sessionCheck(int id)
        {
            if (Session["User"] != null)
            {
                User u = (User)Session["User"];
                return ((u.id == ux.id) || (u.role_id == RoleController.ROLE_ADMIN));
            }
            return false;
        }

        private string generateListProduct(int uid)
        {
            string list = "";
            products = ProductController.GetProducts(uid);
            if (products.Count != 0)
            {
                list += $"<h3>Publicaciones hechas: {products.Count} </h3>\n";
                foreach (Product p in products)
                {
                    list += $"<li><a href=\"busquedaProductos.aspx?pid={p.id}\">{p.name}</a></li>\n";
                }
                return list;

            }
            else
            {
                return "<li> El Usuario no ha publicado ningun producto </li>";
            }
        }

        protected void LnkPublication_Click(object sender, EventArgs e)
        {
            PanelPublication.Visible = true;
            PanelProduct.Visible = false;
        }

        protected void LnkProducts_Click(object sender, EventArgs e)
        {
            PanelProduct.Visible = true;
            PanelPublication.Visible = false;
        }

        protected void LnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}