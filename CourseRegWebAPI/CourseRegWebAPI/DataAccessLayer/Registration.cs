using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseRegWebAPI.DataAccessLayer
{
    public class Registration 
    {
        [Key]
        public int RegistrationId { get; set; }

        [Required]
        public string RegistrationType { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        public Student student { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public Course course { get; set; }

        [ForeignKey("InstructorId")]
        public int InstructorId { get; set; }
        public Instructor instructor { get; set; }
    }
}