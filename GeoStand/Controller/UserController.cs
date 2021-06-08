using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Class;

namespace GeoStand.Controller
{
    public class UserController
    {
        private static List<User> listUser = new List<User>();

        /*
         *Crea paciente y lo agrega al registro 
         */
        public static bool addUser(int _id, string username, string name, string pass, string mail)
        {
            try
            {
                User u = new User(_id, username, name, pass, mail);
                listUser.Add(u);
                return true;
            }
            catch
            {
                return false;

            }
        }

        public static User findUser(int _id)
        {
            foreach (User u in listUser)
            {
                if (u.Id == _id)
                {
                    return u;
                }
            }

            return null;
        }

        public static List<User> getAll()
        {
            return listUser;
        }

        public static void fillUser()
        {
            if (listUser.Count == 0)
            {
                listUser.Add(new User(101,"username1","Usuario1","123456","correo1@uwu.cl"));
                listUser.Add(new User(102, "username2", "Usuario2", "123456", "correo2@uwu.cl"));
            }
        }


    }
}