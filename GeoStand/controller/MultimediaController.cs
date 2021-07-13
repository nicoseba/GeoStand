using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.@class;

namespace GeoStand.controller
{
    public class MultimediaController
    {
        private static List<Multimedia> listMultimedia= new List<Multimedia>();
        public static Multimedia addMultimedia(int id_, string url_)
        {
            try
            {
                Multimedia m = new Multimedia()
                {
                    Id = id_,
                    Url = url_
                };

                listMultimedia.Add(m);
                return m;
                
            }
            catch 
            {

                return null;
            }
        }
        public static Multimedia findMultimedia(int id_)
        {
            foreach ( Multimedia m in listMultimedia)
            {
                if (m.Id == id_)
                {
                    return m;
                }
            }
            return null;
        }

        public static Multimedia editMultimedia(int id_, string url_)
        {
            Multimedia m = findMultimedia(id_);
            if (m!=null)
            {
                m.Url = url_;
                return m;
            }
            else
            {
                return m;
            }
        }

        public static void fillMultimedia()
        {
            if (listMultimedia.Count == 0)
            {
                listMultimedia.Add(new Multimedia(1, "http://lorempixel.com/450/450/nature/"));
                listMultimedia.Add(new Multimedia(2, "http://lorempixel.com/450/450/nightlife/"));
                listMultimedia.Add(new Multimedia(3, "http://lorempixel.com/450/450/cats/"));

            }
        }
    }
}