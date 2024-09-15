using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScoalaCodeFirst.Models;

namespace ScoalaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EleviController : ControllerBase
    {
        private readonly ScoalaDbContext _context;

        public EleviController(ScoalaDbContext context)
        {
            _context = context;
        }

        // Action Methods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elev>>> GetElevi()
        {
            var elevi = await _context.elevi.ToListAsync();
            return Ok(elevi);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Elev>> GetElev(int id)
        {
            var elev = await _context.elevi.FindAsync(id);
            if (elev == null)
                return NotFound();

            return elev;
        }

        [HttpPost]
        public async Task<ActionResult<Elev>> PostElev(Elev elev)
        {
            _context.elevi.Add(elev);
            await _context.SaveChangesAsync();

            return Ok("Elevul a fost adaugat cu succes");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Elev>> PutElev(Elev elev, int id)
        {
            if (id != elev.ElevID)
                return BadRequest();

            if (!ElevExists(id))
                return NotFound();

            _context.Entry(elev).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElevExists(int id)
        {
            return _context.elevi.Any(e =>  e.ElevID == id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Elev>> DeleteElev(int id)
        {
            var elev = await _context.elevi.FindAsync(id);
            if (elev == null) return NotFound();

            _context.elevi.Remove(elev);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("ordonat")]
        public async Task<ActionResult<Elev>> GetElev([FromQuery] string order)
        {
            var elevi = await _context.elevi.ToListAsync();

            if (order == "nume")
                return Ok(elevi.OrderBy(elevi => elevi.Nume));

            return BadRequest();
        }
    }
}
