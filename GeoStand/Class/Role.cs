using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.@class
{
    public class Role
    {
        private int id;
        private string roleName;
        public static int USER_ROLE = 1;
        public static int ADMIN_ROLE = 2;

        public Role()
        {

        }

        public Role(int id)
        {
            switch (id)
            { 
                case 1:
                    this.id = id;
                    this.roleName = "Usuario";
                    break;
                case 2:
                    this.id = id;
                    this.roleName = "Administrador";
                    break;
                default:
                    this.id = 0;
                    this.roleName = "";
                    break;
            }
        }

        public int Id { get => id; set => id = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        
    }
}