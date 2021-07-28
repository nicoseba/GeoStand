using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Modelo;

namespace GeoStand.controller
{
    public class MultimediaController
    {
        private static GeoStandEntities dbc = new GeoStandEntities();
        
        public static Multimedia addMultimedia( string url_ )
        {
            try
            {
                Multimedia m = new Multimedia()
                { 
                    url = url_
                };

                dbc.Multimedia.Add(m);
                dbc.SaveChanges();

                return dbc.Multimedia.SingleOrDefault( mul => mul.url.Equals(url_));
                
            }
            catch 
            {

                return null;
            }
        }
        public static Multimedia findMultimedia(int id_)
        {
            return dbc.Multimedia.Find(id_);
        }

        public static Multimedia editMultimedia(int id_, string url_)
        {
            
            Multimedia m = dbc.Multimedia.Find(id_);
            if (m!=null)
            {
                m.url = url_;
            }
            dbc.SaveChanges();
            return m;
        }
    }
}