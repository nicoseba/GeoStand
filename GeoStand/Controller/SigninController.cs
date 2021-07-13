using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.@class;

namespace GeoStand.controller
{
    public class SigninController
    {
        public static string validarUsernameMail(string username, string mail)
        {
            foreach (User u in UserController.getAll())
            {
                if (u.Username.Equals(username))
                {
                    return "Nombre de usuario ya en uso.";

                }else if (u.Mail.Equals(mail))
                {
                    return "Correo electronico ya en uso.";
                }
            }

            return null;

        }
            
       
    }
}