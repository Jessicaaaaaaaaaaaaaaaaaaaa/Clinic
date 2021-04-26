using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public class Instructors 
    {
        [Key]
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
