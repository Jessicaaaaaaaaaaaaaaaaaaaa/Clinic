using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public class Registration 
    {
        [Key]
        public int RegistrationId { get; set; }

        [Required]
        public string RegistrationType { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }

        [ForeignKey("InstructorId")]
        public int InstructorId { get; set; }

    }
}
