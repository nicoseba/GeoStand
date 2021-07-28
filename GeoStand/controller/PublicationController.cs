using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Modelo;

namespace GeoStand.controller
{
    public class PublicationController
    {
        private static GeoStandEntities dbc = new GeoStandEntities();

        public static Publication addPublication(string title, string content, int user_id, string url_multimedia)
        {
            User u = UserController.findUser(user_id);

            Multimedia m = MultimediaController.addMultimedia(url_multimedia);

            Publication p = new Publication()
            {
                title = title,
                content = content,
                user_id = u.id,
                multimedia_id = m.id
            };

            dbc.Publication.Add(p);
            dbc.SaveChanges();

            return (Publication) (from ps in dbc.Publication
                                where ps.title == title
                                select ps);

        }


        public static Publication findPublicatiotion(int id_)
        {
            return dbc.Publication.Find(id_);
        }

        public static List<Publication> getAll()
        {
            var publications = from p in dbc.Publication
                               select p;

            return publications.ToList();
        }


        public static string editPublication(int id_, string title_, string content_, string url_,  int user_id)
        {
            Publication p = dbc.Publication.Find(id_);
            User u = UserController.findUser(user_id);
            if (p != null)
            {
                if (p.user_id == u.id || u.Role.id == 2)
                {
                    p.title = title_;
                    p.content = content_;
                    MultimediaController.editMultimedia(p.multimedia_id, url_);

                    dbc.SaveChanges();

                    return "Publicación Modificada.";
                }
                else
                {
                    return "No tiene los permisos suficientes para modificar la publicación.";
                }
            }
            else
            {
                return "Publicación no encontrada.";
            }
        }

        public static List<Publication> listPublicationByUser(int uid)
        {
            var publications = from m in dbc.Publication
                              where m.user_id == uid
                              select m;
            return publications.ToList();
        }

        
    }
}