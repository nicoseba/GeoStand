using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Modelo;

namespace GeoStand.controller
{
    public class SigninController

    {
        private static GeoStandEntities dbc = new GeoStandEntities();
        public static string validarUsernameMail(string username, string mail)
        {
            User usname = dbc.User.SingleOrDefault(us => us.username.Equals(username));

            User usmail = dbc.User.SingleOrDefault(us => us.mail.Equals(mail));

            if (usmail != null)
            {
                return "Nombre de usuario ya en uso.";
            }
            else if (usname != null)
            {
                return "Correo electronico ya en uso.";
            }

            return null;

        }


    }
}