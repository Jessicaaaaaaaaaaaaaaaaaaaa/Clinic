using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Reservation
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    }
}
