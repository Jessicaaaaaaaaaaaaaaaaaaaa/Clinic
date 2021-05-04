using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITest.Entities;

namespace WebAPITest.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Registration> Registration { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    StudentID = 1,
                    Name = "John Smith"
                },
                new Student()
                {
                    StudentID = 2,
                    Name = "Liza Ray"
                }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    CourseId = 1,
                    Name = "Accounting",
                    Credits = 3,
                },
                new Course()
                {
                    CourseId = 2,
                    Name = "Finance",
                    Credits = 3,
                }
                );
            modelBuilder.Entity<Instructor>().HasData(
               new Instructor()
               {
                   InstructoreID = 1,
                   Name = "Daisy Duck"
               },
               new Instructor()
               {
                   InstructoreID = 2,
                   Name = "Tom"
               }
               );

            modelBuilder.Entity<Registration>().HasData(
                new Registration()
                {
                    RegistrationId = 1,
                    Type="Fulltime",
                    StudentId = 1,
                    CourseId = 1,
                    IntructorId = 1
                },

                new Registration()
                {
                    RegistrationId = 2,
                    Type = "Parttime",
                    StudentId = 2,
                    CourseId = 1,
                    IntructorId = 1
                },
                new Registration()
                {
                    RegistrationId = 3,
                    Type = "Fulltime",
                    StudentId = 2,
                    CourseId = 2,
                    IntructorId = 2
                });
            base.OnModelCreating(modelBuilder);

        }
    }
}
