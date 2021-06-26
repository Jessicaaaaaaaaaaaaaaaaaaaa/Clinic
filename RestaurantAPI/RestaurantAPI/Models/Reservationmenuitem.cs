using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantAPI.Models
{
    public partial class Reservationmenuitem
    {
        public int IdReservations { get; set; }
        public int IdMenuItems { get; set; }

        public virtual Menuitem Menuitem { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
