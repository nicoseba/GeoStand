using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Clases
{
    public class Multimedia
    {

        private int id;
        private string url;

        public Multimedia()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }

        public Multimedia(int id, string url)
        {
            this.id = id;
            this.url = url;
        }
    }
}