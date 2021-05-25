﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class MenuItem
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required] 
        public Double Price { get; set; }
    }
}
