using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIJames.Models;

namespace WebAPIJames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationMenuItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReservationMenuItemsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ReservationMenuItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservationMenuItem>>> GetReservationMenuItems()
        {
            return await _context.ReservationMenuItems.ToListAsync();
        }

        // GET: api/ReservationMenuItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationMenuItem>> GetReservationMenuItem(int id)
        {
            var reservationMenuItem = await _context.ReservationMenuItems.FindAsync(id);

            if (reservationMenuItem == null)
            {
                return NotFound();
            }

            return reservationMenuItem;
        }

        // PUT: api/ReservationMenuItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservationMenuItem(int id, ReservationMenuItem reservationMenuItem)
        {
            if (id != reservationMenuItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(reservationMenuItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationMenuItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ReservationMenuItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReservationMenuItem>> PostReservationMenuItem(ReservationMenuItem reservationMenuItem)
        {
            _context.ReservationMenuItems.Add(reservationMenuItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReservationMenuItem", new { id = reservationMenuItem.Id }, reservationMenuItem);
        }

        // DELETE: api/ReservationMenuItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservationMenuItem(int id)
        {
            var reservationMenuItem = await _context.ReservationMenuItems.FindAsync(id);
            if (reservationMenuItem == null)
            {
                return NotFound();
            }

            _context.ReservationMenuItems.Remove(reservationMenuItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReservationMenuItemExists(int id)
        {
            return _context.ReservationMenuItems.Any(e => e.Id == id);
        }
    }
}
