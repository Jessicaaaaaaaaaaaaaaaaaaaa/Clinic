using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseRegistrationWithDb.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseRegistrationWithDb.Entities
{
    public class SeedClass
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                    new Student 
                    {
                        StudentId = 1,
                        FirstName = "Amphibian",
                        LastName = "Amphibian",
                        Email = "Frog",
                        Phone = "Frog"
                    },
                    new Student
                    {
                        StudentId = 2,
                        FirstName = "Mammel",
                        LastName = "Amphibian",
                        Email = "Rabbit",
                        Phone = "Frog"
                    }
                    );
        }
    }
}
