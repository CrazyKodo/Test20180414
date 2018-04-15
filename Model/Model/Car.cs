using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
            //"Make": "Audi",
            //"Model": "A4",
            //"Title": "2012 Audi A4 1.8 TFSI Multitronic 160 CV Sport Cuero",
            //"Price": 410000,
            //"Thumbnail": "/post/private/pp5204484838941071227.jpg"
    public class Car
    {
        public string make { get; set; } = "";
        public string model { get; set; } = "";
        public string title { get; set; } = "";
        public decimal price { get; set; } = 0;
        public string thumbnail { get; set; } = "";
        public string GetDisplayImgUrl()
        {
            return thumbnail;
        }
    }
    
}
