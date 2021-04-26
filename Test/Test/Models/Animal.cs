using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NationalZoo.Models
{
    public class AnimalViewModel
    {
        public List<DTO.Animal> Animals { get; set; }

    }
}
