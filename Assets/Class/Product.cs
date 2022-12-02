﻿using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Tp_Synthèse_B
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string GetPrice { get => (Price*Quantity).ToString("0.##") + "$"; }
        public int Quantity { get; set; }
        public int Quantities { get;set; }
        public BitmapImage Image { get; set; }
        

        public Product(int id, string name, string description, double price, int quantities, string image="")
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantities = quantities;
            Quantity = 1;
            //Image = new BitmapImage(new System.Uri(image));
        }
    }
}
