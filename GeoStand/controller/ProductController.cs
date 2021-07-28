using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GeoStand.Modelo;

namespace GeoStand.controller
{
    public class ProductController
    {
        private static GeoStandEntities dbc = new GeoStandEntities();

        public static  List<Product> GetProducts(int uid)
        {
            var products = from p in dbc.Product
                           where p.user_id == uid
                           select p;
            return products.ToList();
        }
    }
}