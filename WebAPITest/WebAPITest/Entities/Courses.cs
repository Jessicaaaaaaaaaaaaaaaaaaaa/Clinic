using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public class Courses 
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
    }
}
