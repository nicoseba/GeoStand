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
        public static User addUser(string username, string name, string pass, string mail)
        {
            try
            {
                User u = new User( username, name, pass, mail, Role.USER_ROLE);
                listUser.Add(u);
                return u;
            }
            catch
            {
                return null;

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

        public static string editUser(int _id, string mail, string name,  int R)
        {

            try
            {
                User u = findUser(_id);
                if (u != null)
                {
                    u.Role = new Role(R);
                    u.Username = name;
                    u.Mail = mail;

                    return "Usuario modificado.";
                }
                else
                {
                    return "Usuario no encontrado.";
                }
            }
            catch (Exception e)
            {
                return "Error: " + e;
            }
        }

        public static void fillUser()
        {
            if (listUser.Count == 0)
            {
                listUser.Add(new User("username1","Usuario1","123456","correo1@uwu.cl",Role.ADMIN_ROLE));
                listUser.Add(new User("username2", "Usuario2", "123456", "correo2@uwu.cl", Role.USER_ROLE));
                listUser.Add(new User("username3", "Usuario3", "123456", "correo3@uwu.cl", Role.ADMIN_ROLE));
                listUser.Add(new User("username4", "Usuario4", "123456", "correo4@uwu.cl", Role.USER_ROLE));
            }
        }


    }
}