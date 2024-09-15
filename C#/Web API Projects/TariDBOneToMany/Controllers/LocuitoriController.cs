using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TariDBOneToMany.Models;

namespace TariDBOneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocuitoriController : ControllerBase
    {
        private readonly TariDbContext _context;

        public LocuitoriController(TariDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Locuitor>>> GetLocuitori()
        {
            var locuitori = await _context.locuitori.Include(l => l.Tara).ToListAsync();
            return Ok(locuitori);
        }
    }
}
