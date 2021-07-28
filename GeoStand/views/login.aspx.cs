using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using GeoStand.Modelo;
using GeoStand.controller;

namespace GeoStand.views
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            User u = LoginController.login(TxtUsername.Text, TxtPass.Text);
            if (u != null)
            {
                Session["User"] = u;
                Response.Redirect("index.aspx");
            }
            else
            {
                LblMessage.Visible = true;
                LblMessage.Text = "Credenciuales de acceso incorrectas.";
            }
        }

        protected void LnkSignin_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }
    }
}