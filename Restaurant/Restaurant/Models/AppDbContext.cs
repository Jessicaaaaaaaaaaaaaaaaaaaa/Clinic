using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<ReservationMenuItem> ReservationMenuItems { get; set; } 
        public DbSet<Reservation> Reservations { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem()
                {
                    Id = 1,
                    Name = "Kjielkje & Schmaunt Fat",
                    Price = 14.99
                },
                new MenuItem()
                {
                    Id = 2,
                    Name = "Plumi Moos",
                    Price = 7.99
                },
                new MenuItem()
                {
                    Id = 3,
                    Name = "Vereniki",
                    Price = 12.99
                }
                );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation()
                {
                    Id = 1,
                    Name = "John Klassen",
                    Date = DateTime.Now
                    // list of menu items??

                },
                new Reservation()
                {
                    Id = 2,
                    Name = "Margaret Froese",
                    Date = DateTime.Now
                },
                new Reservation()
                {
                    Id = 3,
                    Name = "Anna Giesbrecht",
                    Date = DateTime.Now
                }
                );

            modelBuilder.Entity<ReservationMenuItem>().HasData(

               new ReservationMenuItem()
               {
                   Id = 1,
                   MenuItemId = 1,
                   ReservationId = 1
               },
               new ReservationMenuItem()
               {
                   Id = 2,
                   MenuItemId = 2,
                   ReservationId = 2
               },
               new ReservationMenuItem()
               {
                   Id = 3,
                   MenuItemId = 3,
                   ReservationId = 3
               }
               );

            base.OnModelCreating(modelBuilder);

        }
    }
}