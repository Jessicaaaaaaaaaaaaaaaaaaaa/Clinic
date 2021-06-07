using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseRegistration1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                 new Student()
                 {
                     StudentId = 1,
                     FirstName = "Nancy",
                     LastName = "Drew",
                     Email = "ndrew@gmail.com",
                    Phone = "+4339003456"
                 },
                new Student()
                {
                    StudentId = 2,
                    FirstName = "Bess",
                    LastName = "Marvin",
                    Email = "bmarvin@yahoo.com",
                    Phone = "+2045679888"
                },
                new Student()
                {
                    StudentId = 3,
                    FirstName = "George",
                    LastName = "Fayne",
                    Email = "gfayne@yahoo.com",
                    Phone = "+2049879000"
                }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    CourseId = 1,
                    CourseNumber = 1,
                    CourseName = "Critical Thinking",
                    Description = "Learn how to analyze facts to form a judgement."

                },
                new Course()
                {
                    CourseId = 2,
                    CourseNumber = 2,
                    CourseName = "Problem Solving",
                    Description = "Learn how to define and solve problems."
                },
                new Course()
                {
                    CourseId = 3,
                    CourseNumber = 3,
                    CourseName = "Attention to Detail",
                    Description = "Learn how to achieve thoroughness and accuracy when accomplishing a task."
                }
                );

            modelBuilder.Entity<Instructor>().HasData(
               new Instructor()
               {
                   InstructorId = 1,
                   FirstName = "Sherlock",
                   LastName = "Holmes",
                   Email = "sholmes@gmail.com",
                   Course = "Critical Thinking"
               },
               new Instructor()
               {
                   InstructorId = 2,
                   FirstName = "John",
                   LastName = "Watson",
                   Email = "jwatson@gmail.com",
                   Course = "Problem Solving"
               },
               new Instructor()
               {
                   InstructorId = 3,
                   FirstName = "Carson",
                   LastName = "Drew",
                   Email = "cdrew@gmail.com",
                   Course = "Attention to Detail"
               }
               );

            base.OnModelCreating(modelBuilder);

        }
    }
}

