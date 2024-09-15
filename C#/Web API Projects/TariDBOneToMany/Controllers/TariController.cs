using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TariDBOneToMany.Models;

namespace TariDBOneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariController : ControllerBase
    {
        private readonly TariDbContext _context;

        public TariController(TariDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tara>>> GetTari()
        {
            var tari = await _context.tari.Include(t => t.Locuitori).ToListAsync();
            return Ok(tari);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tara>> GetTaraById(int id)
        {
            var tara = await _context.tari.FindAsync(id);
            if (tara == null)
                return NotFound();

            return Ok(tara);
        }

        [HttpGet("sort")]
        public async Task<ActionResult<IEnumerable<Tara>>> GetSpecificTari([FromQuery] string assortment)
        {
            var tari = await _context.tari.Include(t => t.Locuitori).ToListAsync();
            IEnumerable<Tara> sortedTari = tari;// = tari.Where(t => t.TaraNume.Contains(text));

            switch(assortment)
            {
                case "Nume":
                    sortedTari = tari.OrderBy(t => t.TaraNume);
                    break;
                case "NrLoc":
                    sortedTari = tari.OrderBy(t => t.Locuitori == null ? 0 : t.Locuitori.Count);
                    break;
            }

            return Ok(sortedTari);
        }

        [HttpPost]
        public async Task<ActionResult<Tara>> PostTara(Tara tara)
        {
            await _context.tari.AddAsync(tara);
            await _context.SaveChangesAsync();

            return Ok(tara);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Tara>> PutTara(int id, Tara tara)
        {
            if (id != tara.TaraID)
                return BadRequest();

            if (!TaraExists(id))
                return NotFound();

            _context.Entry(tara).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaraExists(int id)
        {
            return _context.tari.Any(t => t.TaraID == id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Tara>> DeleteTara(int id)
        {
            var tara = await _context.tari.FindAsync(id);

            if (tara == null)
                return NotFound();

            _context.tari.Remove(tara);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
