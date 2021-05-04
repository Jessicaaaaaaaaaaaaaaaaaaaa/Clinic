using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public class Instructor
    {
        [Key]
        public int InstructoreID { get; set; }


        [Required]
        public string Name { get; set; }
    }
}
