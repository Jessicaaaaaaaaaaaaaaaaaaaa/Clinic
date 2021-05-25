using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class ReservationMenuItems 
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("ReservationId")]
        public Reservation Reservation { get; set; }
        public int ReservationId { get; set; }


        [ForeignKey("MenuItemId")]
        public MenuItem MenuItem { get; set; }
        public int MenuItemId { get; set; }

    }
}
