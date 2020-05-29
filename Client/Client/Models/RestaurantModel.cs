using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Models
{
    class RestaurantModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public int  Stars  { get; set; }


        public List<ReviewModel> reviews = new List<ReviewModel>();


        public void setInfo(string name, string address, string path, string description, int stars, List<ReviewModel> list)
        {
            Name = name;
            Address = address;
            Path = path;
            Description = description;
            Stars = stars;
            reviews = list;
        }
    }
}
