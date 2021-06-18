using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeoStand.Class;
using GeoStand.Controller;
using System.Drawing;

namespace GeoStand
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserController.fillUser();
        }

        protected void TxtSrc_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SrcButton_Click(object sender, EventArgs e)
        {
            User u = UserController.findUser(int.Parse(TxtSrc.Text));
            Console.WriteLine(u);
            if (u != null)
            {
                Lbmsj.Text = "Usuario encontrado";
                Lbmsj.ForeColor = Color.Green;

                Panel1.Visible = true;
                LbUser.Text = u.Username;
                LbUsername.Text = u.Name;
                LbEmail.Text = u.Mail;
            }
            else
            {
                Lbmsj.Text = "Usuario no encontrado";
                Lbmsj.ForeColor = Color.Red;
                Panel1.Visible = false;

            }
        }
    }
}