using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeoStand.@class;

namespace GeoStand
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"]!=null)
            {
                User u = (User)Session["User"];

                LnkLogin.Visible = false;
                LnkSignin.Visible = false;
                LnkSession.Visible = true;
                LnkSession.Text = u.Name +" - Cerrar Sesión";
                LblMsg.Text = "Pagina de inicio con sesion activa.";
            }

        }

        protected void LnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void LnkSignin_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }

        protected void LnkSession_Click(object sender, EventArgs e)
        {
            if(Session["User"] != null)
            {
                Session["User"] = null;
                Response.Redirect("home.aspx");
            }
        }

        protected void LinkSrc_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx");
        }
    }
}