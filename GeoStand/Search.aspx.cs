using GeoStand.@class;
using GeoStand.controller;
using System;
using System.Drawing;
using System.Web.UI.WebControls;

namespace GeoStand
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"]!=null)
            {
                User userLog = (User)Session["User"];
                if (userLog.Role.Id != Role.ADMIN_ROLE)
                {
                    LnkEditar.Visible = false;
                }
            }
            else
            {
                LnkEditar.Visible = false;
            }

            UserController.fillUser();
            if (!IsPostBack)
            {
                FillDropDownList();
            }
        }


        protected void SrcButton_Click(object sender, EventArgs e)
        {
            User u = UserController.findUser(int.Parse(TxtSrc.Text));
            Session["UserMod"] = u;
            if (u != null)
            {
                Lbmsj.Text = "Usuario encontrado";
                Lbmsj.ForeColor = Color.Green;

                Panel1.Visible = true;
                HdnId.Value = u.Id.ToString();
                TxUser.Text = u.Username;
                LbUsername.Text = u.Name;
                TxEmail.Text = u.Mail;
                DropRole.SelectedValue = u.Role.Id.ToString();
            }
            else
            {
                Lbmsj.Text = "Usuario no encontrado";
                Lbmsj.ForeColor = Color.Red;
                Panel1.Visible = false;

            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void FillDropDownList()
        {
            ListItem vacio = new ListItem("Seleccione rol", "0");
            ListItem usuario = new ListItem("Usuario", "1");
            ListItem admin = new ListItem("Administrador", "2");

            DropRole.Items.Add(vacio);
            DropRole.Items.Add(usuario);
            DropRole.Items.Add(admin);
        }

        protected void LnkEditar_Click(object sender, EventArgs e)
        {

            if (LnkEditar.Text.Equals("Modificar"))
            {
                TxUser.Enabled = true;
                TxEmail.Enabled=true;
                DropRole.Enabled=true;
                BtnModificar.Visible = true;


                LnkEditar.Text = "Cancelar";
            }
            else
            {
                TxUser.Enabled = false;
                TxEmail.Enabled = false;
                DropRole.Enabled = false;
                BtnModificar.Visible = false;
                LnkEditar.Text = "Modificar";
            }




        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            User userMod = (User) Session["UserMod"];
            if (userMod.Username.Equals(TxUser.Text) && userMod.Mail.Equals(TxEmail.Text))
            {
                modUser(sender, e);
            }
            else if (userMod.Username.Equals(TxUser.Text) && !userMod.Mail.Equals(TxEmail.Text))
            {
                Session["Comprobation"] = SearchController.validarMail(TxEmail.Text);
                if (Session["Comprobation"] == null)
                {
                    modUser(sender, e);
                }
                else
                {
                    LbMsj2.Text = Session["Comprobation"].ToString();
                    Session["Comprobation"] = null;
                }
            }
            else if (!userMod.Username.Equals(TxUser.Text) && userMod.Mail.Equals(TxEmail.Text))
            {
                Session["Comprobation"] = SearchController.validarUsername(TxUser.Text);
                if (Session["Comprobation"] == null)
                {
                    modUser(sender, e);
                }
                else
                {
                    LbMsj2.Text = Session["Comprobation"].ToString();
                    Session["Comprobation"] = null;
                }
            }
            else
            {
                Session["Comprobation"] = SigninController.validarUsernameMail(TxUser.Text, TxEmail.Text);
                if (Session["Comprobation"] == null)
                {
                    modUser(sender, e);
                }
                else
                {
                    LbMsj2.Text = Session["Comprobation"].ToString();
                    Session["Comprobation"] = null;
                }
            }

        }

        private void modUser(object sender, EventArgs e)
        {
            if (DropRole.SelectedValue != "0")
            {

                switch (int.Parse(DropRole.SelectedValue))
                {
                    case 1:
                        LbMsj2.Text = UserController.editUser(int.Parse(HdnId.Value), TxEmail.Text, TxUser.Text, Role.USER_ROLE);
                        break;
                    case 2:
                        LbMsj2.Text = UserController.editUser(int.Parse(HdnId.Value), TxEmail.Text, TxUser.Text, Role.ADMIN_ROLE);
                        break;
                }

                LnkEditar_Click(sender, e);
            }
            else
            {
                LbMsj2.Text = "Debe seleccionar un rol";
            }
        }
    }
}