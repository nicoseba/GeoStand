using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Class
{
    public class Message
    {
        private int id;
        private int userid;
        private int chatid;
        private String content;
        private DateTime date;
        private String url;
        private int statusid;

        public Message(int id, int userid, int chatid, string content, DateTime date, string url, int statusid)
        {
            this.id = id;
            this.userid = userid;
            this.chatid = chatid;
            this.content = content;
            this.date = date;
            this.url = url;
            this.statusid = statusid;
        }

        public Message()
        {

        }

        public int Id { get => id; set => id = value; }
        public int Userid { get => userid; set => userid = value; }
        public int Chatid { get => chatid; set => chatid = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Url { get => url; set => url = value; }
        public int Statusid { get => statusid; set => statusid = value; }
    }
}