using GenshinDBCodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace GenshinDBCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly GenshinDbContext _context;

        public CharacterController(GenshinDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> GetCharacters()
        {
            var characters = await _context.characters.ToListAsync();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await _context.characters.FindAsync(id);
            return Ok(character);
        }

        [HttpPost]
        public async Task<ActionResult<Character>> PostCharacter(Character character)
        {
            _context.characters.Add(character);
            await _context.SaveChangesAsync();

            return Ok("The character was added");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Character>> PutCharacter(Character character, int id)
        {
            if (id != character.CharID)
                return BadRequest();

            if (!CharExists(id))
                return NotFound();

            _context.Entry(character).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharExists(int id)
        {
            return _context.characters.Any(c => c.CharID == id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Character>> DeleteCharacter(int id)
        {
            var character = await _context.characters.FindAsync(id);

            if (character == null)
                return NotFound();

            _context.characters.Remove(character);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
