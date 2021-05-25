using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class SQLReservation : IReservation
    {
        private readonly AppDbContext _context;

        public SQLReservation(AppDbContext context)
        {
            _context = context;
        }

        // decorate everything with HttpGet etc.
        // remember to add checks ie model state is valid etc. to all relevant methods
        public MenuItem AddMenuItem(MenuItem menuItem)
        {
            // model state valid check here
            _context.menuItems.Add(menuItem);
            _context.SaveChanges();
            // not finished
        }

        public Reservation AddReservation(Reservation reservation)
        {
            // model state valid check here
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            // not finished
        }

        public void DeleteMenuItem(int Id)
        {
            // not null check here
            var item = _context.menuItems.Find(Id);
            _context.menuItems.Remove(item);
            _context.SaveChanges();
        }

        public void DeleteReservation(int Id)
        {
            // not null check here
            var item = _context.Reservations.Find(Id);
            _context.Reservations.Remove(item);
            _context.SaveChanges();
        }

        public MenuItem GetMenuItem(int Id)
        {
            return _context.menuItems.Find(Id);
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _context.menuItems.ToList();
        }

        public Reservation GetReservation(int Id)
        {
            return _context.Reservations.Find(Id);
        }

        [HttpGet]
        public List<ReservationVM> GetAllReservationMenuItems()
        {
            //var reservationIds = (from data in _context.ReservationMenuItems
            //              select new {
            //              reservationId = data.ReservationId
            //              }).ToList();
            //var menuItems = (from data in _context.ReservationMenuItems
            //                 select new 
            //                 {
            //                     menuItemIds = data.MenuItemId
            //                 }
            //                 ).ToList();
            var result = (from data in _context.ReservationMenuItems
                          join res in _context.Reservation on data.ReservationId equals res.Id
                          join mi in _context.MenuItem on data.MenuItemId equals mi.Id
                          select new ReservationViewModel()
                          {
                              ReservationId = res.Id,
                              ReservationDate = res.Date,
                              PersonName = res.Name,
                              MenuItem = mi.Name,
                              Price = mi.Price
                          }
                          ).ToList();
            return result;

        }

        public IEnumerable<Reservation> GetReservations()
        {
            return _context.Reservations.ToList();
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            var item = _context.menuItems.Attach(menuItem);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateReservation(Reservation reservation)
        {
            var item = _context.Reservations.Attach(reservation);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public List<ReservationVM> GetReservationMenuItems()
        {
            throw new NotImplementedException();
        }
    }
}
