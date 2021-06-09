using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Class
{
    public class Admin
    {
        private int id;
        private int userid;

       

        public Admin(int id, int userid)
        {
            this.id = id;
            this.userid = userid;
        }

        public Admin() { 
        }

        public int Id { get => id; set => id = value; }
        public int Userid { get => userid; set => userid = value; }

    }
}