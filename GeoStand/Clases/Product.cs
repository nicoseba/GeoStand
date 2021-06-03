using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoStand.Clases
{
    public class Product
    {
        private int id;
        private string characteristics;
        private int exchangeMode;
        private User user;
        private Multimedia multimedia;

        public Product()
        {
        }

        public Product(int id, string characteristics, int exchangeMode, User user, Multimedia multimedia)
        {
            this.id = id;
            this.characteristics = characteristics;
            this.exchangeMode = exchangeMode;
            this.user = user;
            this.multimedia = multimedia;
        }

        public int Id { get => id; set => id = value; }
        public string Characteristics { get => characteristics; set => characteristics = value; }
        public int ExchangeMode { get => exchangeMode; set => exchangeMode = value; }
        public User User { get => user; set => user = value; }
        public Multimedia Multimedia { get => multimedia; set => multimedia = value; }
    }
}