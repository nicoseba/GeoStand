using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Class;

namespace GeoStand.Controller
{
    public class SearchController
    {
        public static string validarUsername(string username)
        {
            foreach (User u in UserController.getAll())
            {
                if (u.Username.Equals(username))
                {
                    return "Nombre de usuario ya en uso.";
                }
            }
            return null;
        }
        public static string validarMail(string mail)
        {
            foreach (User u in UserController.getAll())
            {
                if (u.Mail.Equals(mail))
                {
                    return "Mail de usuario ya en uso.";
                }
            }
            return null;
        }

    }
}