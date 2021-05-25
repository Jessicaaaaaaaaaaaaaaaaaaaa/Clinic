using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class ReservationVM
    {
        public int ReservationId { get; set; }
        public string PersonName { get; set; }
        public string MenuItem { get; set; }
        public double Price { get; set; } 

    }
}
