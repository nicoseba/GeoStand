using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.@class;

namespace GeoStand.controller
{
    public class PublicationController
    {
        private static string content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eleifend at ante nec cursus. Quisque mattis risus sed luctus fringilla. Ut commodo ipsum sed mi facilisis, vel condimentum tellus suscipit. Donec fringilla tortor sem. Aliquam erat volutpat. Sed ut erat fermentum ligula mollis vestibulum. Morbi ultrices ac nisi ac congue. Suspendisse non sem sed tortor posuere rhoncus. Fusce nec gravida nulla. Donec pretium auctor tortor sit amet iaculis. Nullam rhoncus mi quis convallis ultricies. Morbi vel dapibus est, eget iaculis urna. Duis sit amet diam vel sapien vestibulum malesuada.\nPraesent mi nisl, pellentesque et elit id, placerat scelerisque ex. Vivamus fermentum nisi at mauris scelerisque blandit. Donec magna felis, malesuada nec bibendum a, commodo in est. Suspendisse aliquam sapien fermentum quam lacinia, non dictum mi dictum. Maecenas sollicitudin dolor purus, vel laoreet nibh ullamcorper in. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer ac porta quam, id posuere magna. Duis vitae est molestie, auctor est eu, feugiat risus. Aenean a enim blandit, sagittis diam vitae, consectetur orci.\nNulla consequat mi quis arcu mollis sodales. Maecenas sed mattis nisl, at blandit sapien. Aenean nibh arcu, aliquet nec malesuada ut, porttitor id neque. Vivamus volutpat sapien nunc, nec elementum mi rutrum vitae. Maecenas elit eros, vehicula quis viverra eu, tincidunt eget ligula. Maecenas interdum, justo quis commodo suscipit, turpis leo rutrum mi, sit amet aliquam ligula libero at erat. Nam magna metus, ullamcorper ut sodales eu, placerat id lectus. Praesent sit amet ligula efficitur, ornare lectus aliquet, tincidunt orci.\nDuis feugiat tempor arcu, sit amet tincidunt neque. Pellentesque laoreet risus nec turpis semper ultricies. Sed dapibus mauris dui, at sollicitudin nisi cursus a. Aenean quis dignissim odio, in rhoncus sapien. Vivamus porttitor accumsan ligula, eget placerat nisi vulputate sed. Fusce cursus pharetra diam, id rhoncus est faucibus vel. Interdum et malesuada fames ac ante ipsum primis in faucibus. Mauris eget gravida eros. Maecenas elementum mattis libero a rutrum. Maecenas dictum dui pretium tincidunt luctus. Duis quis sagittis elit, ut scelerisque sem. Integer et sapien tortor. Suspendisse arcu neque, blandit eget sodales non, tristique ut mauris. Praesent in massa ut sem sollicitudin lacinia.";
        private static List<Publication> listPublications = new List<Publication>();

        public static Publication addPublication(int id_, string title_, string content_,
            User u_ , Multimedia m_)
        {
            try
            {
                Publication p = new Publication()
                {
                    Id = id_,
                    Title = title_,
                    Content = content_,
                    Date = new DateTime(),
                    User = u_,
                    Multimedia = m_

                };
                listPublications.Add(p);
                return p;
            }
            catch
            {
                return null;
            }
        }

        public static Publication findPublicatiotion(int id_)
        {
            foreach (Publication p in listPublications)
            {
                if (p.Id == id_)
                {
                    return p;
                }
            }
            return null;
        }

        public static List<Publication> getAll()
        {
            return listPublications;
        }

        public static string editPublication( int id_ , string title_ , string content_ , string url_ , User u)
        {
            try
            {
                Publication p = findPublicatiotion(id_);
                if (p != null)
                {
                    if ((p.User.Id==u.Id) || (u.Role.Id==Role.ADMIN_ROLE)) //si es dueño de la publicacion o admin
                    {
                        p.Title = title_;
                        p.Content = content_;
                        p.Multimedia = MultimediaController.editMultimedia(p.Multimedia.Id,url_);
                        return "Publicacion Modificada.";
                    }
                    else
                    {
                        return "Permisos insuficientes para modifcar la publicacion";
                    }
                }
                else
                {
                    return "Publicacion no encontrada";
                }

            }
            catch (Exception e)
            {
                return "Error: " + e;

            }
        }

        public static void fillPublication()
        {
            if ( listPublications.Count == 0 )
            {
                
                listPublications.Add(new Publication(1,"Titulo publicacion 1",content,new DateTime() , UserController.findUser(100),MultimediaController.findMultimedia(1)));
                listPublications.Add(new Publication(2, "Titulo publicacion 2", content, new DateTime(), UserController.findUser(102), MultimediaController.findMultimedia(2)));
                listPublications.Add(new Publication(3, "Titulo publicacion 3", content, new DateTime(), UserController.findUser(101), MultimediaController.findMultimedia(3)));
            }
        }
        
    }
}