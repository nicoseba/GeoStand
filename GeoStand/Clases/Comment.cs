using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Clases
{
    public class Comment
    {
        private int id;
        private User user;
        private Publication publication;
        private string content;
        private DateTime date;

        public Comment()
        {
        }

        public Comment(int id, User user, Publication publication, string content, DateTime date)
        {
            this.id = id;
            this.user = user;
            this.publication = publication;
            this.content = content;
            this.date = date;
        }

        public int Id { get => id; set => id = value; }
        public User User { get => user; set => user = value; }
        public Publication Publication { get => publication; set => publication = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}