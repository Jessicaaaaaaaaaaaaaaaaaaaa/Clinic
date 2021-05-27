﻿// <auto-generated />
using CourseRegistrationMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseRegistrationMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210526213508_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseRegistrationMVC.Models.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
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
                            CourseName = "Critical Thinking",
                            CourseNumber = 1,
                            Description = "Learn how to analyze facts to form a judgement."
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Problem Solving",
                            CourseNumber = 2,
                            Description = "Learn how to define and solve problems."
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "Attention to Detail",
                            CourseNumber = 3,
                            Description = "Learn how to achieve thoroughness and accuracy when accomplishing a task."
                        });
                });

            modelBuilder.Entity("CourseRegistrationMVC.Models.Instructors", b =>
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
                            Course = "Critical Thinking",
                            Email = "sholmes@gmail.com",
                            FirstName = "Sherlock",
                            LastName = "Holmes"
                        },
                        new
                        {
                            InstructorId = 2,
                            Course = "Problem Solving",
                            Email = "jwatson@gmail.com",
                            FirstName = "John",
                            LastName = "Watson"
                        },
                        new
                        {
                            InstructorId = 3,
                            Course = "Attention to Detail",
                            Email = "cdrew@gmail.com",
                            FirstName = "Carson",
                            LastName = "Drew"
                        });
                });

            modelBuilder.Entity("CourseRegistrationMVC.Models.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegistrationId");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("StudentId");

                    b.ToTable("Registration");

                    b.HasData(
                        new
                        {
                            RegistrationId = 1,
                            CourseId = 2,
                            InstructorId = 2,
                            StudentId = 1,
                            Type = "Fulltime"
                        },
                        new
                        {
                            RegistrationId = 2,
                            CourseId = 2,
                            InstructorId = 2,
                            StudentId = 2,
                            Type = "Parttime"
                        },
                        new
                        {
                            RegistrationId = 3,
                            CourseId = 1,
                            InstructorId = 1,
                            StudentId = 3,
                            Type = "Fulltime"
                        });
                });

            modelBuilder.Entity("CourseRegistrationMVC.Models.Students", b =>
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                            Email = "ndrew@gmail.com",
                            FirstName = "Nancy",
                            LastName = "Drew",
                            Phone = "+4339003456"
                        },
                        new
                        {
                            StudentId = 2,
                            Email = "bmarvin@yahoo.com",
                            FirstName = "Bess",
                            LastName = "Marvin",
                            Phone = "+2045679888"
                        },
                        new
                        {
                            StudentId = 3,
                            Email = "gfayne@yahoo.com",
                            FirstName = "George",
                            LastName = "Fayne",
                            Phone = "+2049879000"
                        });
                });

            modelBuilder.Entity("CourseRegistrationMVC.Models.Registration", b =>
                {
                    b.HasOne("CourseRegistrationMVC.Models.Courses", "course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegistrationMVC.Models.Instructors", "instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegistrationMVC.Models.Students", "student")
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
