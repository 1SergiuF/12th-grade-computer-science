using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportiviDBOneToMany.Models;

namespace SportiviDBOneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        private readonly SportDbContext _context;

        public SportController(SportDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sport>>> GetSporturi()
        {
            var sporturi = await _context.sporturi.Include(s => s.Sportivi).ToListAsync();

            return Ok(sporturi);
        }

        [HttpGet("contains_name")]
        public async Task<ActionResult<IEnumerable<Sport>>> GetSpecificSporturi([FromQuery] string nume)
        {
            var sporturi = await _context.sporturi.Include(s => s.Sportivi).ToListAsync();

            var specificSporturi = sporturi.Where(s => s.SportNume.Contains(nume));

            return Ok(specificSporturi);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sport>> GetSportById(int id)
        {
            var sport = await _context.sporturi.FindAsync(id);
            if (sport == null)
                return NotFound();

            return Ok(sport);
        }

        [HttpPost]
        public async Task<ActionResult<Sport>> PostSport(Sport sport)
        {
            await _context.sporturi.AddAsync(sport);
            await _context.SaveChangesAsync();

            return Ok(sport);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Sport>> PutSport(int id, Sport sport)
        {
            if (id != sport.SportID)
                return BadRequest();

            if (!SportExists(id))
                return NotFound();

            _context.Entry(sport).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SportExists(int id)
        {
            return _context.sporturi.Any(s => s.SportID == id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Sport>> DeleteSport(int id)
        {
            var sport = await _context.sporturi.FindAsync(id);

            if (sport == null)
                return NotFound();

            _context.sporturi.Remove(sport);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
