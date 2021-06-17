using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeoStand.Class;
using GeoStand.Controller;

namespace GeoStand.Class
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Precargamos usuarios
            UserController.fillUser();

            if (Session["Error"]!= null) 
            {
                LblMessage.Text = Session["Error"].ToString();
                Session["Error"] = null;
            }

            if (Session["User"] != null)
                {
                Response.Redirect("home.aspx");
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            User u = LoginController.login(TxtUser.Text,TxtPass.Text);
            if (u != null)
            {
                Session["User"] = u;
                Response.Redirect("home.aspx");
            }
            else
            {
                LblMessage.Text = "Credenciuales de acceso incorrectas.";
            }
        }
    }
}