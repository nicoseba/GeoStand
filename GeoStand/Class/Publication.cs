using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.@class
{
    public class Publication
    {
        private int id;
        private string title;
        private string content;
        private DateTime date;
        private User user;
        private Multimedia multimedia;

        public Publication()
        {
        }

        public Publication(int id, string title, string content, DateTime date, User user, Multimedia multimedia)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.date = date;
            this.user = user;
            this.multimedia = multimedia;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Date { get => date; set => date = value; }
        public User User { get => user; set => user = value; }
        public Multimedia Multimedia { get => multimedia; set => multimedia = value; }
    }
}