using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Class
{
    public class ExchangeMode
    {
        private int id;
        private String name;

        public ExchangeMode(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public ExchangeMode()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}