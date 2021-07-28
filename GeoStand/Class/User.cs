using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Class
{
    public class User
    {
        private int id;
        private string username;
        private string name;
        private string pass;
        private string mail;
        private Role role;
        private DateTime registDate;
        private DateTime confirmDate;
        private static int ID_GLOBAL = 100;

        public User()
        {
        }

        public User( string username, string name, string pass, string mail,int idRole)
        {
            this.id = User.ID_GLOBAL;
            User.ID_GLOBAL1 += 1;
            this.username = username;
            this.name = name;
            this.pass = pass;
            this.mail = mail;
            this.role = new Role(idRole);
            this.registDate = new DateTime();
        }


        public User(string username, string name, string pass, string mail, Role role)
        {
            this.id = User.ID_GLOBAL;
            User.ID_GLOBAL1 += 1;
            this.username = username;
            this.name = name;
            this.pass = pass;
            this.mail = mail;
            this.role = role;
            this.registDate = new DateTime();
        }



        public User(int id, string username, string name, string pass, string mail, Role role, DateTime registDate, DateTime confirmDate)
        {
            this.id = id;
            this.username = username;
            this.name = name;
            this.pass = pass;
            this.mail = mail;
            this.role = role;
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
        public static int ID_GLOBAL1 { get => ID_GLOBAL; set => ID_GLOBAL = value; }
        public Role Role { get => role; set => role = value; }
    }

}