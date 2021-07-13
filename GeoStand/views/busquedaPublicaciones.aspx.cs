using GeoStand.@class;
using GeoStand.controller;
using System;

namespace GeoStand.views
{
    public partial class busquedaPublicaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSearchPublication_Click(object sender, EventArgs e)
        {
            string idPublication = TxtIdSearch.Text;
            Publication p = PublicationController.findPublicatiotion(int.Parse(idPublication));
            System.Threading.Thread.Sleep(1500);
            if (p != null)
            {
                HdnIDPublication.Value = p.Id.ToString();
                TitlePublication.Text = p.Title;
                UserPublication.Text = p.User.Name;
                ImgPublication.ImageUrl = p.Multimedia.Url;
                ContentPublication.Text = p.Content;
                PublicationView.Visible = true;
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

        private bool SessionCheck()
        {
            if (Session["User"] != null)
            {
                User u = (User)Session["User"];
                Publication p = PublicationController.findPublicatiotion(int.Parse(HdnIDPublication.Value));
                if ((p.User.Id == u.Id) || (u.Id == Role.ADMIN_ROLE))
                {
                    return true;
                }
            }

            return false;
        }

        protected void BtnEditPublication_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            Publication p = PublicationController.findPublicatiotion(int.Parse(HdnIDPublication.Value));
            PublicationView.Visible = false;
            PublicationSearch.Visible = false;
            PublicationEdit.Visible = true;
            HdnPublicationEdit.Value = p.Id.ToString();
            TxtTitle.Text = p.Title;
            TxtContent.Text = p.Content;
            TxtUrl.Text = p.Multimedia.Url;


        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            User u = (User)Session["User"];
            PanelMsg.Visible = true;
            LblMsg.Text = PublicationController.editPublication(int.Parse(HdnPublicationEdit.Value), TxtTitle.Text, TxtContent.Text, TxtUrl.Text, u);
            PublicationSearch.Visible = true;
            PublicationView.Visible = true;
            PublicationEdit.Visible = false;
            TxtIdSearch.Text = HdnPublicationEdit.Value;
            BtnSearchPublication_Click(sender, e);
        }
    }
}