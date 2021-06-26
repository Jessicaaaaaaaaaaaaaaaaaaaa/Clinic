using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Models;
using RestaurantAPI_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly restaurantdbContext _context;

        public ReservationsController(restaurantdbContext context)
        {
            _context = context;
        }

        // GET: api/<ReservationsController>
        [HttpGet]
        public IEnumerable<ReservationDTO> Get()
        {
            var res = _context.Reservations
                .Select(r => new ReservationDTO
                {
                    Id = r.Id,
                    Name = r.Name,
                    Date = r.Date,
                    MenuItemsDTO = _context.Reservationmenuitems
                        .Where(rvm => rvm.IdReservations == rvm.IdReservations)
                        .Select(m => new MenuItemDTO
                        {
                            Id = m.Menuitem.Id,
                            Name = m.Menuitem.Name,
                            Price = m.Menuitem.Price
                        })
                        .ToList()
                })
                .ToList();

            return res;
        }

        // GET api/<ReservationsController>/5
        [HttpGet("{id}")]
        public Menuitem Get(int id)
        {
            var res = _context.Reservations
                .Select(r => new ReservationDTO
                {
                    Id = r.Id,
                    Name = r.Name,
                    Date = r.Date,
                    MenuItemsDTO = _context.Reservationmenuitems
                        .Where(rvm => rvm.IdReservations == rvm.IdReservations)
                        .Select(m => new MenuItemDTO
                        {
                            Id = m.Menuitem.Id,
                            Name = m.Menuitem.Name,
                            Price = m.Menuitem.Price
                        })
                        .ToList()
                })
                .FirstOrDefault();

            return res;
        }

        // POST api/<ReservationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
