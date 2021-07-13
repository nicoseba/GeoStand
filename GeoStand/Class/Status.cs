using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.@class
{
    public class Status
    {
        private int id;
        private String name;

        public Status(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Status()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}