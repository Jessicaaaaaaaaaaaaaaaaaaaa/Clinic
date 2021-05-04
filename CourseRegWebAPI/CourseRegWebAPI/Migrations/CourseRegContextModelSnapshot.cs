﻿// <auto-generated />
using CourseRegWebAPI.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseRegWebAPI.Migrations
{
    [DbContext(typeof(CourseRegContext))]
    partial class CourseRegContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseRegWebAPI.DataAccessLayer.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Accounting",
                            CourseNumber = 101,
                            Description = "Learn to account for your actions."
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Finance",
                            CourseNumber = 202,
                            Description = "Finance your dream getaway with us!"
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "Rainbows",
                            CourseNumber = 303,
                            Description = "Find the pot of gold in your life today!"
                        });
                });

            modelBuilder.Entity("CourseRegWebAPI.DataAccessLayer.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstructorId");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            InstructorId = 1,
                            Course = "Accounting",
                            Email = "dduck@gmail.com",
                            FirstName = "Daisy",
                            LastName = "Duck"
                        },
                        new
                        {
                            InstructorId = 2,
                            Course = "Finance",
                            Email = "tbargen@gmail.com",
                            FirstName = "Tom",
                            LastName = "Bargen"
                        },
                        new
                        {
                            InstructorId = 3,
                            Course = "Rainbows",
                            Email = "sobama@gmail.com",
                            FirstName = "Sasha",
                            LastName = "Obama"
                        });
                });

            modelBuilder.Entity("CourseRegWebAPI.DataAccessLayer.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("RegistrationId");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("StudentId");

                    b.ToTable("Registrations");

                    b.HasData(
                        new
                        {
                            RegistrationId = 1,
                            CourseId = 1,
                            InstructorId = 1,
                            RegistrationType = "Fulltime",
                            StudentId = 1
                        },
                        new
                        {
                            RegistrationId = 2,
                            CourseId = 1,
                            InstructorId = 1,
                            RegistrationType = "Parttime",
                            StudentId = 2
                        },
                        new
                        {
                            RegistrationId = 3,
                            CourseId = 2,
                            InstructorId = 2,
                            RegistrationType = "Fulltime",
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("CourseRegWebAPI.DataAccessLayer.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Email = "jsmith@gmail.com",
                            FirstName = "John",
                            LastName = "Smith",
                            Phone = "(204) 123-4567"
                        },
                        new
                        {
                            StudentId = 2,
                            Email = "lray@gmail.com",
                            FirstName = "Liza",
                            LastName = "Ray",
                            Phone = "(204) 123-4568"
                        },
                        new
                        {
                            StudentId = 3,
                            Email = "mfraise@gmail.com",
                            FirstName = "Michelle",
                            LastName = "Fraise",
                            Phone = "(204) 123-4569"
                        });
                });

            modelBuilder.Entity("CourseRegWebAPI.DataAccessLayer.Registration", b =>
                {
                    b.HasOne("CourseRegWebAPI.DataAccessLayer.Course", "course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegWebAPI.DataAccessLayer.Instructor", "instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegWebAPI.DataAccessLayer.Student", "student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("instructor");

                    b.Navigation("student");
                });
#pragma warning restore 612, 618
        }
    }
}
