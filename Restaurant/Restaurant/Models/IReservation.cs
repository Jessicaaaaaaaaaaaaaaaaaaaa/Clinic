using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    interface IReservation
    {
        IEnumerable<MenuItem> GetMenuItems();
        MenuItem GetMenuItem(int Id);
        MenuItem AddMenuItem(MenuItem menuItem);
        void DeleteMenuItem(int Id);
        void UpdateMenuItem(MenuItem menuItem);


        IEnumerable<Reservation> GetReservations();
        Reservation GetReservation(int Id);
        Reservation AddReservation(Reservation reservation);
        void DeleteReservation(int Id);
        void UpdateReservation(Reservation reservation);

        List<ReservationVM> GetReservationMenuItems();
    } 
}
