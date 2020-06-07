using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Models
{
    public class ReservationModel
    {
        public int ReservationCode { get; set; }
        public string Day { get; set; }
        public string StatHour { get; set; }
        public string  EndHour { get; set; }
        public string Client { get; set; }
        public string Restaurant { get; set; }
        public int TotalPrice { get; set; }

    }
}
