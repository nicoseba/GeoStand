using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using GeoStand.controller;
using GeoStand.Modelo;

namespace GeoStand
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private int uid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                User u = (User) Session["User"];
                uid = u.id;
                //HtmlGenericControl divSession = (HtmlGenericControl)this.FindControl("sessionDiv");
                sessionDiv.Attributes["class"] = "session-on";

                //HtmlGenericControl divLinks = (HtmlGenericControl)this.FindControl("linksDiv");
                //divLinks.Style.Add("display","none");
                linksDiv.Attributes["class"] = "links-off";

                LblSession.Text = $"{u.name} <i class=\"fas fa-user\"></i>";
            }
        }



        protected void LnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        protected void LnkSession_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Session["User"] = null;
                Response.Redirect("index.aspx");
            }
        }

        protected void LnkSignin_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }

        protected void LnkPublication_Click(object sender, EventArgs e)
        {
            Response.Redirect("busquedaPublicaciones.aspx");
        }

        protected void LblSession_Click(object sender, EventArgs e)
        {
            Response.Redirect($"users.aspx?uid={uid}");
        }
    }
}