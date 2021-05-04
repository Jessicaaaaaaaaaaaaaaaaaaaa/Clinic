using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public class RegistrationViewModel
    {
        public int RegistrationId { get; set; }
        [Required]
        public string Type { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }

        [ForeignKey("InstructorId")]
        public int IntructorId { get; set; }



        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public string InstrutorName { get; set; }
        public string RegistrationType { get; set; }

    }
}
