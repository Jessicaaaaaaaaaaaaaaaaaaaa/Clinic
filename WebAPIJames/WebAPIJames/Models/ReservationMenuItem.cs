using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIJames.Models
{
    public class ReservationMenuItem
    {
        [Key]
        public int Id { set; get; }

        [ForeignKey("MenuItemId")]
        public MenuItem MenuItem { set; get; }
        public int MenuItemId { set; get; }


        [ForeignKey("ReservationId")]
        public Reservation Reservation { set; get; }
        public int ReservationId { set; get; }
    }
}
