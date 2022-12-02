using System.Collections.Generic;

namespace Tp_Synthèse_B
{
    public class Clothes:Product
    {
        public List<string> Colors { get; set; }
        public List<string> Sizes { get; set; }
        public Clothes(int id, string name, string description, double price, List<string> colors, List<string> sizes, int quantities, string image = ""):base(id,  name,  description,  price,  quantities,  image)
        {
            Colors=colors;
            Sizes=sizes;
            //Image = new BitmapImage(new System.Uri(image));
        }
    }
}
