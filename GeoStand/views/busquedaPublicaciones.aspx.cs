using GeoStand.Modelo;
using GeoStand.controller;
using System;

namespace GeoStand.views
{
    public partial class busquedaPublicaciones : System.Web.UI.Page
    {
        private Publication p;


        protected void Page_Load(object sender, EventArgs e)
        {
            string pubId = Request.QueryString["pid"];
            if (!String.IsNullOrEmpty(pubId))
            {
                int pid = int.Parse(pubId);
                showPublication(pid);
            }
        }


        protected void BtnSearchPublication_Click(object sender, EventArgs e)
        {
            string idPublication = TxtIdSearch.Text;
            showPublication(int.Parse(idPublication));
            
        }

        private bool SessionCheck()
        {
            if (Session["User"] != null)
            {
                User u = (User) Session["User"];
                Publication p = PublicationController.findPublicatiotion(int.Parse(HdnIDPublication.Value));
                if ((p.User.id == u.id) || (u.Role.id == 2))
                {
                    return true;
                }
            }

            return false;
        }

        private void showPublication(int pid)
        {
            p = PublicationController.findPublicatiotion(pid);
            System.Threading.Thread.Sleep(1500);
            if (p != null)
            {
                PublicationView.Visible = true;
                HdnIDPublication.Value = p.id.ToString();
                TitlePublication.Text = p.title;
                UserPublication.Text = p.User.name;
                HdnUser.Value = p.user_id.ToString();
                ImgPublication.ImageUrl = p.Multimedia.url;
                ContentPublication.Text = p.content;
                PanelMsg.Visible = false;
                BtnEditPublication.Visible = SessionCheck();

            }
            else
            {
                PanelMsg.Visible = true;
                LblMsg.Text = "Publicacion no encontrada.";
                PublicationView.Visible = false;
            }
        }

        protected void BtnEditPublication_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            Publication p = PublicationController.findPublicatiotion(int.Parse(HdnIDPublication.Value));
            PublicationView.Visible = false;
            PublicationSearch.Visible = false;
            PublicationEdit.Visible = true;
            HdnPublicationEdit.Value = p.id.ToString();
            TxtTitle.Text = p.title;
            TxtContent.Text = p.content;
            TxtUrl.Text = p.Multimedia.url;


        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            User u = (User)Session["User"];
            PanelMsg.Visible = true;
            LblMsg.Text = PublicationController.editPublication(int.Parse(HdnPublicationEdit.Value), TxtTitle.Text, TxtContent.Text, TxtUrl.Text, u.id);
            PublicationSearch.Visible = true;
            PublicationView.Visible = true;
            PublicationEdit.Visible = false;
            TxtIdSearch.Text = HdnPublicationEdit.Value;
            BtnSearchPublication_Click(sender, e);
        }

        protected void UserPublication1_Click(object sender, EventArgs e)
        {
            Response.Redirect("users.aspx?uid="+HdnUser.Value);
        }
    }
}