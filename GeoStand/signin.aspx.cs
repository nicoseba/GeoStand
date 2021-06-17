using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeoStand.Controller;
using GeoStand.Class;

namespace GeoStand
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Precargamos usuarios
            UserController.fillUser();

            if (Session["Message"] != null)
            {
                LblMessage.Text = Session["Message"].ToString();
                Session["Message"] = null;
            }

            if (Session["User"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtPass.Text.Equals(TxtPassRepeat.Text))
            {
                Session["Message"] = SigninController.validarUsernameMail(TxtUsername.Text, TxtMail.Text);
                if (Session["Message"] == null)
                {
                    User u = UserController.addUser(TxtUsername.Text, TxtName.Text, TxtPass.Text, TxtMail.Text);
                    if (u != null)
                    {
                        Session["User"] = u;
                    }
                    Response.Redirect("login.aspx");
                }
                else
                {
                    LblMessage.Text = Session["Message"].ToString();
                    Session["Message"] = null;
                }
            }
            else
            {
                LblMessage.Text = "Las contraseñas no coinciden";
            }
        }
    }
}