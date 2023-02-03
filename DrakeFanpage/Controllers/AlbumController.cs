using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DrakeFanpage.Models;
using DrakeFanpage.Data;
using Microsoft.EntityFrameworkCore;

namespace DrakeFanpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly FanpageContext _dbContext;

        public AlbumController(FanpageContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/Albums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Album>>> GetAlbums()
        {
            if (_dbContext.Albums == null)
            {
                return NotFound();
            }
            return await _dbContext.Albums.ToListAsync();
        }

        //GET: api/Albums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Album>> GetAlbum(int id)
        {
            if (_dbContext.Albums == null)
            {
                return NotFound();
            }
            var album = await _dbContext.Albums.FindAsync(id);

            if (album == null)
            {
                return NotFound();
            }
            return album;
        }

        // POST: api/Albums
        [HttpPost]
        public async Task<ActionResult<Album>> PostAlbum(Album album)
        {
            _dbContext.Albums.Add(album);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAlbum), new { id = album.ID }, album);
        }

        // PUT: api/Albums/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlbum(int id, Album album)
        {
            if (id != album.ID)
            {
                return BadRequest();
            }
            _dbContext.Entry(album).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumExists(id))
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

        // DELETE: api/Albums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlbum(int id)
        {
            if (_dbContext.Albums == null)
            {
                return NotFound();
            }
            var album = await _dbContext.Albums.FindAsync(id);
            if (album == null) return NotFound($"Album with id = {id} not found");

            _dbContext.Albums.Remove(album);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        
        
        private bool AlbumExists(long id)
        {
            return (_dbContext.Albums?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
