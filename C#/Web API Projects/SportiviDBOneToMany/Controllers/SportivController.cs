using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportiviDBOneToMany.Models;

namespace SportiviDBOneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportivController : ControllerBase
    {
        private readonly SportDbContext _context;

        public SportivController(SportDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sportiv>>> GetSportivi()
        {
            var sportivi = await _context.sportivi.ToListAsync();
            return Ok(sportivi);
        }
    }
}
