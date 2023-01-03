using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DrakeFanpage.Models;
using DrakeFanpage.Data;
using Microsoft.EntityFrameworkCore;

namespace DrakeFanpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly FanpageContext _dbContext;

        public ArtistController(FanpageContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/Artists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> GetArtists()
        {
            if (_dbContext.Artists == null)
            {
                return NotFound();
            }
            return await _dbContext.Artists.ToListAsync();
        }

        //GET: api/Artists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtists(int id)
        {
            if (_dbContext.Artists == null)
            {
                return NotFound();
            }
            var artist = await _dbContext.Artists.FindAsync(id);

            if (artist == null)
            {
                return NotFound();
            }
            return artist;
        }

        // POST: api/Artists
        [HttpPost]
        public async Task<ActionResult<Artist>> PostArtist(Artist artist)
        {
            _dbContext.Artists.Add(artist);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetArtists), new { id = artist.Id }, artist);
        }

        // PUT: api/Artists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtist(int id, Artist artist)
        {
            if (id != artist.Id)
            {
                return BadRequest();
            }
            _dbContext.Entry(artist).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtistExists(id))
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

        // DELETE: api/Artists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(int id)
        {
            if (_dbContext.Artists == null)
            {
                return NotFound();
            }
            var artist = await _dbContext.Artists.FindAsync(id);
            if (DeleteArtist == null)
            {
                return NotFound();
            }

            _dbContext.Artists.Remove(artist);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


        private bool ArtistExists(long id)
        {
            return (_dbContext.Artists?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
