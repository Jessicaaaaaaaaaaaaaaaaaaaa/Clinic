using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration1.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public int CourseNumber { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string Description { get; set; }
       

    }
}
