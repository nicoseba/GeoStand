using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Class;

namespace GeoStand.Controller
{
    public class LoginController
    {
        public static User login(string username, string pass)
        {
            foreach (User u in UserController.getAll())
            {
                if (u.Username.Equals(username))
                {
                    if (u.Pass.Equals(pass))
                    {
                        return u;
                    }
                }
            }
            return null;
        }

    }
}