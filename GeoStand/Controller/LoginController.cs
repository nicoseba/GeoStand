using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Modelo;
using GeoStand.Helpers;

namespace GeoStand.controller
{
    public class LoginController
    {
        public static User login(string username, string pass)
        {
            User u = UserController.findByUsername(username);

            return (u != null && u.pass.Equals(Encrypt.GetSHA256(pass))) ? u : null;

        }

    }
}