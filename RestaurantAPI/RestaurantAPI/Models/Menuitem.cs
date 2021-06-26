using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantAPI.Models
{
    public partial class Menuitem
    {
        public Menuitem()
        {
            Reservationmenuitems = new HashSet<Reservationmenuitem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Reservationmenuitem> Reservationmenuitems { get; set; }
    }
}
