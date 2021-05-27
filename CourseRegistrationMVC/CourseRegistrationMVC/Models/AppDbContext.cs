using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseRegistrationMVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Registration> Registration { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Students>().HasData(
                 new Students()
                 {
                     StudentId = 1,
                     FirstName = "Nancy",
                     LastName = "Drew",
                     Email = "ndrew@gmail.com",
                    Phone = "+4339003456"
                 },
                new Students()
                {
                    StudentId = 2,
                    FirstName = "Bess",
                    LastName = "Marvin",
                    Email = "bmarvin@yahoo.com",
                    Phone = "+2045679888"
                },
                new Students()
                {
                    StudentId = 3,
                    FirstName = "George",
                    LastName = "Fayne",
                    Email = "gfayne@yahoo.com",
                    Phone = "+2049879000"
                }
                );

            modelBuilder.Entity<Courses>().HasData(
                new Courses()
                {
                    CourseId = 1,
                    CourseNumber = 1,
                    CourseName = "Critical Thinking",
                    Description = "Learn how to analyze facts to form a judgement."

                },
                new Courses()
                {
                    CourseId = 2,
                    CourseNumber = 2,
                    CourseName = "Problem Solving",
                    Description = "Learn how to define and solve problems."
                },
                new Courses()
                {
                    CourseId = 3,
                    CourseNumber = 3,
                    CourseName = "Attention to Detail",
                    Description = "Learn how to achieve thoroughness and accuracy when accomplishing a task."
                }
                );

            modelBuilder.Entity<Instructors>().HasData(
               new Instructors()
               {
                   InstructorId = 1,
                   FirstName = "Sherlock",
                   LastName = "Holmes",
                   Email = "sholmes@gmail.com",
                   Course = "Critical Thinking"
               },
               new Instructors()
               {
                   InstructorId = 2,
                   FirstName = "John",
                   LastName = "Watson",
                   Email = "jwatson@gmail.com",
                   Course = "Problem Solving"
               },
               new Instructors()
               {
                   InstructorId = 3,
                   FirstName = "Carson",
                   LastName = "Drew",
                   Email = "cdrew@gmail.com",
                   Course = "Attention to Detail"
               }
               );

            modelBuilder.Entity<Registration>().HasData(
                new Registration()
                {
                    RegistrationId = 1,
                    Type = "Fulltime",
                    StudentId = 1,
                    CourseId = 2,
                    InstructorId = 2
                },

                new Registration()
                {
                    RegistrationId = 2,
                    Type = "Parttime",
                    StudentId = 2,
                    CourseId = 2,
                    InstructorId = 2
                },
                new Registration()
                {
                    RegistrationId = 3,
                    Type = "Fulltime",
                    StudentId = 3,
                    CourseId = 1,
                    InstructorId = 1
                }
                );

            base.OnModelCreating(modelBuilder);

        }
    }
}

