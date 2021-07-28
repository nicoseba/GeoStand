using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Class
{
    public class ChatHasUser
    {
        private int chatid;
        private int userid;

        

        public ChatHasUser(int chatid, int userid)
        {
            this.chatid = chatid;
            this.userid = userid;
        }

        public ChatHasUser()
        {

        }

        public int Chatid { get => chatid; set => chatid = value; }
        public int Userid { get => userid; set => userid = value; }
    }
}