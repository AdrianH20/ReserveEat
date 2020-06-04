using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Models
{
    public class MenuModel
    {
       
        
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Ingredients { get; set; }
            public int Price { get; set; }
            public string Path { get; set; }
            public int RestaurantID { get; set; }

        
    }
}
