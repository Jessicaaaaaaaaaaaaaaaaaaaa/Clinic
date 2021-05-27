using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalCourseRegistrationMVC.Models;

namespace CourseRegistrationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InstructorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Instructors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instructors>>> GetInstructors()
        {
            return await _context.Instructors.ToListAsync();
        }

        // GET: api/Instructors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instructors>> GetInstructors(int id)
        {
            var instructors = await _context.Instructors.FindAsync(id);

            if (instructors == null)
            {
                return NotFound();
            }

            return instructors;
        }

        // PUT: api/Instructors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstructors(int id, Instructors instructors)
        {
            if (id != instructors.InstructorId)
            {
                return BadRequest();
            }

            _context.Entry(instructors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructorsExists(id))
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

        // POST: api/Instructors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Instructors>> PostInstructors(Instructors instructors)
        {
            _context.Instructors.Add(instructors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstructors", new { id = instructors.InstructorId }, instructors);
        }

        // DELETE: api/Instructors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Instructors>> DeleteInstructors(int id)
        {
            var instructors = await _context.Instructors.FindAsync(id);
            if (instructors == null)
            {
                return NotFound();
            }

            _context.Instructors.Remove(instructors);
            await _context.SaveChangesAsync();

            return instructors;
        }

        private bool InstructorsExists(int id)
        {
            return _context.Instructors.Any(e => e.InstructorId == id);
        }
    }
}
