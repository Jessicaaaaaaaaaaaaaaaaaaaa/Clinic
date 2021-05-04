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
        public string Type { get; set; }

        [ForeignKey("StudentId")]
        public Student student { get; set; }
        public int StudentId { get; set; }

        [ForeignKey("CourseId")]
        public Course course { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("InstructorId")]
        public Instructor instructor { get; set; }
        public int IntructorId { get; set; }

    }
}
