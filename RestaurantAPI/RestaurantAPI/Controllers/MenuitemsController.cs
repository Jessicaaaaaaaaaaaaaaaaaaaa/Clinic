using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;
using RestaurantAPI_DTO;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuitemsController : ControllerBase
    {
        private readonly restaurantdbContext _context;

        public MenuitemsController(restaurantdbContext context)
        {
            _context = context;
        }

        // GET: api/Menuitems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuItemDTO>>> GetMenuitems()
        {
            return await _context.Menuitems
                .Select(m => new MenuItemDTO
                {
                    Id = m.Id,
                    Name = m.Name,
                    Price = m.Price
                })
                .ToListAsync();
        }

        // GET: api/Menuitems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuItemDTO>> GetMenuitem(int id)
        {
            var menuitem = await _context.Menuitems.FindAsync(id);

            if (menuitem == null)
            {
                return NotFound();
            }

            return new MenuItemDTO
            {
                Id = menuitem.Id,
                Name = menuitem.Name,
                Price = menuitem.Price
            };
        }

        // PUT: api/Menuitems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuitem(int id, MenuItemDTO menuitem)
        {
            if (id != menuitem.Id)
            {
                return BadRequest();
            }

            _context.Entry(
                new Menuitem
                {
                    Id = menuitem.Id,
                    Name = menuitem.Name,
                    Price = menuitem.Price
                }
                ).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuitemExists(id))
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

        // POST: api/Menuitems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Menuitem>> PostMenuitem(MenuItemDTO menuitem)
        {
            _context.Menuitems.Add(
                new Menuitem
                {
                    Id = menuitem.Id,
                    Name = menuitem.Name,
                    Price = menuitem.Price
                }
                );
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenuitem", new { id = menuitem.Id }, menuitem);
        }

        // DELETE: api/Menuitems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuitem(int id)
        {
            var menuitem = await _context.Menuitems.FindAsync(id);
            if (menuitem == null)
            {
                return NotFound();
            }

            _context.Menuitems.Remove(menuitem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuitemExists(int id)
        {
            return _context.Menuitems.Any(e => e.Id == id);
        }
    }
}
