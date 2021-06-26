using System;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

public class AppDbContext : DbContext
{
    public DbSet<Doctor> Doctors { set; get; }
    public DbSet<Patient> Patients { set; get; }
    public DbSet<IntakeForm> IntakeForms { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(@"server=localhost;username=root;password=qnQCqHAvtXqOSksz;database=Clinic",
            ServerVersion.Parse("5.7.31-mysql")
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Doctor>().HasData(
            new Doctor()
            {
                Id = 1,
                Name = "Gandalf"
            },
            new Doctor()
            {
                Id = 2,
                Name = "Sauroman"
            },
            new Doctor()
            {
                Id = 3,
                Name = "Radagast"
            }
            );

        modelBuilder.Entity<Patient>().HasData(
            new Patient()
            {
                Id = 1,
                Name = "Baggins",
                DateOfBirth = DateTime.Now,
                HealthNumber = 111222333,
                Address = "Bag-End, Underhill, Hobbiton",
                PhoneNumber = "+44 7911 123456"
            },
            new Patient()
            {
                Id = 2,
                Name = "Gamgee",
                DateOfBirth = DateTime.Now,
                HealthNumber = 444555666,
                Address = "3 Bagshot Row, Hobbiton",
                PhoneNumber = "+44 7911 123457"
            },
            new Patient()
            {
                Id = 3,
                Name = "Brandybuck",
                DateOfBirth = DateTime.Now,
                HealthNumber = 777888999,
                Address = "Brandy Hall, Buckland",
                PhoneNumber = "+44 7911 123458"
            }
            );

        modelBuilder.Entity<IntakeForm>().HasData(
           new IntakeForm()
           {
               Id = 1,
               Ailment = "Extreme weight loss, irritability",
               DoctorId = 2,
               PatientId = 1
           },
           new IntakeForm()
           {
               Id = 2,
               Ailment = "Unable to enjoy gardening",
               DoctorId = 1,
               PatientId = 2
           },
           new IntakeForm()
           {
               Id = 3,
               Ailment = "Loneliness",
               DoctorId = 3,
               PatientId = 3
           }
           );

        base.OnModelCreating(modelBuilder);

    }
}