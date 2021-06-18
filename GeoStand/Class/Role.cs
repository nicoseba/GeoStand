using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Class
{
    public class Role
    {
        private int id;
        private string roleName;
        public static int USER_ROLE = 0;
        public static int ADMIN_ROLE = 1;

        public Role()
        {

        }

        public Role(int id)
        {
            switch (id)
            { 
                case 0:
                    this.id = id;
                    this.roleName = "Usuario";
                    break;
                case 1:
                    this.id = id;
                    this.roleName = "Administrador";
                    break;
            }
        }

        public int Id { get => id; set => id = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        
    }
}