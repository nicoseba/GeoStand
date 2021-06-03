using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Clases
{
    public class User
    {
        private int id;
        private string username;
        private string name;
        private string pass;
        private string mail;
        private DateTime registDate;
        private DateTime confirmDate;

        public User()
        {
        }

        public User(int id, string username, string name, string pass, string mail, DateTime registDate, DateTime confirmDate)
        {
            this.id = id;
            this.username = username;
            this.name = name;
            this.pass = pass;
            this.mail = mail;
            this.registDate = registDate;
            this.confirmDate = confirmDate;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Name { get => name; set => name = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Mail { get => mail; set => mail = value; }
        public DateTime RegistDate { get => registDate; set => registDate = value; }
        public DateTime ConfirmDate { get => confirmDate; set => confirmDate = value; }
    }

}