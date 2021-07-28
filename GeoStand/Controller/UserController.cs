using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Modelo;
using GeoStand.Helpers;

namespace GeoStand.controller
{
    public class UserController
    {

        //Intancia del contexto
        private static GeoStandEntities dbc = new GeoStandEntities();

        //private static List<@class.User> listUser = new List<@class.User>();



        /*
         *Crea paciente y lo agrega al registro 
         */
        public static User addUser(string username, string name, string pass, string mail)
        {
            
            User u = new User()
            {
                username = username,
                name = name,
                pass = Encrypt.GetSHA256(pass),
                mail = mail,
                role_id = RoleController.ROLE_USER,
                regist_date = DateTime.Now
            };

            dbc.User.Add(u);

            dbc.SaveChanges();



            return findByUsername(username);
        }

        public static User findUser(int _id)
        {
            return dbc.User.Find(_id);
        }

        public static User findByUsername(string username)
        {
            return dbc.User.SingleOrDefault( u => u.username.Equals(username));
        }

        public static List<User> getAll()
        {
            var users = from m in dbc.User
                        select m;

            return users.ToList();
        }

        public static string editUser(int _id, string mail, string name, int R)
        {

            User u = dbc.User.Find(_id);
            Role r = dbc.Role.Find(R);

            if (u != null && r != null)
            {
                u.mail = mail;
                u.name = name;
                u.role_id = r.id;

                dbc.SaveChanges();

                return "Usuario modificado.";
            }
            else
            {
                return "Usuario no encontrado.";

            }
        }

        public static string confirmEmail(int id)
        {
            User u = dbc.User.Find(id);
            if (u != null)
            {
                u.confirm_date = DateTime.Now;
                return "Correo confirmado.";
            }

            return "No se ha podido confirmar su Correo.";
        }

        public static string removeUser(int id)
        {
            User u = dbc.User.Find(id);

            if (u != null)
            {
                dbc.User.Remove(u);
                dbc.SaveChanges();
                return "Usuario eliminadop";
            }
            else
            {
                return "El Usuario solicitado no existe";
            }
        }





    }
}