using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantAPI.Models
{
    public partial class Reservation
    {
        public Reservation()
        {
            Reservationmenuitems = new HashSet<Reservationmenuitem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Reservationmenuitem> Reservationmenuitems { get; set; }
    }
}
