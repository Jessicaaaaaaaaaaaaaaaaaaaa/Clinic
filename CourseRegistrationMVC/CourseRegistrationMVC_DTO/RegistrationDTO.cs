using CourseRegistrationMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationMVC_DTO
{
    class RegistrationDTO
    {
        [Key]
        public int RegistrationId { get; set; }

        [Required]
        public string Type { get; set; }

        [ForeignKey("StudentId")]
        public Students student { get; set; }
        public int StudentId { get; set; }

        [ForeignKey("CourseId")]
        public Courses course { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("InstructorId")]
        public Instructors instructor { get; set; }
        public int InstructorId { get; set; }
    }
}
