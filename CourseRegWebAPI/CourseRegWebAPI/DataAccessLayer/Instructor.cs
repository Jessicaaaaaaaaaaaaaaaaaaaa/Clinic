using System.ComponentModel.DataAnnotations;

namespace CourseRegWebAPI.DataAccessLayer
{
    public class Instructor 
    {
        [Key]
        public int InstructorId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Course { get; set; } 
    }
}