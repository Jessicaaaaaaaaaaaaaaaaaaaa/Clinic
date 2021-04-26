using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}
