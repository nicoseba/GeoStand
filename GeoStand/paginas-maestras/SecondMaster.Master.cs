﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GeoStand.paginas_maestras
{
    public partial class SecondMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LnkPublication_Click(object sender, EventArgs e)
        {
            Response.Redirect("busquedaPublicaciones.aspx");
        }
    }
}