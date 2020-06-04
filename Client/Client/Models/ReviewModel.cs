using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Models
{
    class ReviewModel
    {
        public string Content { get; set; }
        public string Author { get; set; }
        public bool Checked { get; set; }
        public int NrofRates { get; set; }
      
    }
}
