using CourseRegWebAPI.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegWebAPI.DataAccessLayer
{
    public class CourseRegContext : DbContext
    {
        public CourseRegContext(DbContextOptions<CourseRegContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentId = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "jsmith@gmail.com",
                    Phone = "(204) 123-4567"
                },
                new Student()
                {
                    StudentId = 2,
                    FirstName = "Liza",
                    LastName = "Ray",
                    Email = "lray@gmail.com",
                    Phone = "(204) 123-4568"
                },
                new Student()
                {
                    StudentId = 3,
                    FirstName = "Michelle",
                    LastName = "Fraise",
                    Email = "mfraise@gmail.com",
                    Phone = "(204) 123-4569"
                }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    CourseId = 1,
                    CourseNumber = 101,
                    CourseName = "Accounting",
                    Description = "Learn to account for your actions."
                },
                new Course()
                {
                    CourseId = 2,
                    CourseNumber = 202,
                    CourseName = "Finance",
                    Description = "Finance your dream getaway with us!"
                },
                new Course()
                {
                    CourseId = 3,
                    CourseNumber = 303,
                    CourseName = "Rainbows",
                    Description = "Find the pot of gold in your life today!"
                }
                );

            modelBuilder.Entity<Instructor>().HasData(
               new Instructor()
               {
                   InstructorId = 1,
                   FirstName = "Daisy",
                   LastName = "Duck",
                   Email = "dduck@gmail.com",
                   Course = "Accounting"

               },
               new Instructor()
               {
                   InstructorId = 2,
                   FirstName = "Tom",
                   LastName = "Bargen",
                   Email = "tbargen@gmail.com",
                   Course = "Finance"
               },
               new Instructor()
               {
                   InstructorId = 3,
                   FirstName = "Sasha",
                   LastName = "Obama",
                   Email = "sobama@gmail.com",
                   Course = "Rainbows"
               }
               );

            modelBuilder.Entity<Registration>().HasData(
                new Registration()
                {
                    RegistrationId = 1,
                    RegistrationType = "Fulltime",
                    StudentId = 1,
                    CourseId = 1,
                    InstructorId = 1
                },

                new Registration()
                {
                    RegistrationId = 2,
                    RegistrationType = "Parttime",
                    StudentId = 2,
                    CourseId = 1,
                    InstructorId = 1
                },
                new Registration()
                {
                    RegistrationId = 3,
                    RegistrationType = "Fulltime",
                    StudentId = 2,
                    CourseId = 2,
                    InstructorId = 2
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
