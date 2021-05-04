using System.ComponentModel.DataAnnotations;

namespace CourseRegWebAPI.DataAccessLayer 
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