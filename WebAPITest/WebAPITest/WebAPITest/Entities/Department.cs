using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = " Location cannot exceed 50 characters")]
        public string Location { get; set; }

        //To specify 1:M relationship
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
