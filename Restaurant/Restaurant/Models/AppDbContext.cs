using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<MenuItem> menuItems { get; set; }  
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationMenuItems> ReservationMenuItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MenuItem>().HasData(
                 new MenuItem()
                 {
                     Id = 1,
                     Name = "Brain Soup",
                     Price = 12.99
                 },
                 new MenuItem()
                 {
                     Id = 2,
                     Name = "Sauteed Tail of Lab Rat",
                     Price = 6.99
                 },
                new MenuItem()
                {
                    Id = 3,
                    Name = "Fried Brains with Slaw",
                    Price = 14.99
                }
                );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation()
                {
                    Id = 1,
                    Name = "Carl Jung",
                    Date = DateTime.Now,
                    MenuItems = new List<MenuItem>()
                },
                new Reservation()
                {
                    Id = 2,
                    Name = "Sigmund Freud",
                    Date = DateTime.Now,
                    MenuItems = new List<MenuItem>()
                },
                new Reservation()
                {
                    Id = 3,
                    Name = "Ivan Pavlov",
                    Date = DateTime.Now,
                    MenuItems = new List<MenuItem>()
                }
                );

            modelBuilder.Entity<ReservationMenuItems>().HasData(
                new ReservationMenuItems()
                {
                    Id = 1,
                    MenuItemId = 1,
                    ReservationId = 1
                }
                );

            base.OnModelCreating(modelBuilder);

        }
    }
}

