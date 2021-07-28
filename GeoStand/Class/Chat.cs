using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Class
{
    public class Chat
    {
        private int id;
        private DateTime createdate;

        public Chat(int id, DateTime createdate)
        {
            this.id = id;
            this.createdate = createdate;
        }
        public Chat()
        {

        }

        public int Id { get => id; set => id = value; }
        public DateTime Createdate { get => createdate; set => createdate = value; }
    }
}