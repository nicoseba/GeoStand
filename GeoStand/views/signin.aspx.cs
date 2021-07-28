using GeoStand.Modelo;
using GeoStand.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GeoStand.views
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Message"] != null)
            {
                LblMessage.Text = Session["Message"].ToString();
                LblMessage.Visible = true;
                Session["Message"] = null;
            }

            if (Session["User"] != null)
            {
                Response.Redirect("index.aspx");
            }

        }

        protected void LnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Session["Message"] = SigninController.validarUsernameMail(TxtUsername.Text, TxtMail.Text);
            if (Session["Message"] == null)
            {
                User u = UserController.addUser(TxtUsername.Text, TxtName.Text, TxtPass.Text, TxtMail.Text);
                if (u != null)
                {
                    Session["User"] = u;
                }

                Response.Redirect("index.aspx");
            }
            else
            {
                LblMessage.Text = Session["Message"].ToString();
                LblMessage.Visible = true;
                Session["Message"] = null;
            }
            
        }


    }
}