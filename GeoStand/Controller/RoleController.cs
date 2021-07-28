using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Modelo;

namespace GeoStand.controller
{
    public class RoleController
    {

        //Instancia del contexto
        private static GeoStandEntities dbc = new GeoStandEntities();

        public static int ROLE_USER = userRole().id;

        public static int ROLE_ADMIN = adminRole().id;

        public static List<Role> getAll()
        {
            var roles = from r in dbc.Role
                        select r;

            return roles.ToList();
        }

        public static Role userRole()
        {
            return dbc.Role.SingleOrDefault( r => r.name.Equals("Usuario"));
        }

        public static Role adminRole()
        {
            return dbc.Role.SingleOrDefault(r => r.name.Equals("Administrador"));
        }

        public static Role findRole(int id)
        {
            return dbc.Role.Find(id);
        }
    }
}