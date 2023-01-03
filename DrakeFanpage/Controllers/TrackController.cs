using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DrakeFanpage.Models;
using DrakeFanpage.Data;
using Microsoft.EntityFrameworkCore;

namespace DrakeFanpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly FanpageContext _dbContext;

        public TrackController(FanpageContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/Tracks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Track>>> GetTracks()
        {
            if (_dbContext.Tracks == null)
            {
                return NotFound();
            }
            return await _dbContext.Tracks.ToListAsync();
        }

        //GET: api/Tracks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Track>> GetTracks(int id)
        {
            if (_dbContext.Tracks == null)
            {
                return NotFound();
            }
            var track = await _dbContext.Tracks.FindAsync(id);

            if (track == null)
            {
                return NotFound();
            }
            return track;
        }

        // POST: api/Tracks
        [HttpPost]
        public async Task<ActionResult<Track>> PostTrack(Track track)
        {
            _dbContext.Tracks.Add(track);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTracks), new { id = track.Id }, track);
        }

        // PUT: api/Tracks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrack(int id, Track track)
        {
            if (id != track.Id)
            {
                return BadRequest();
            }
            _dbContext.Entry(track).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackExists(id))
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

        // DELETE: api/Tracks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrack(int id)
        {
            if (_dbContext.Tracks == null)
            {
                return NotFound();
            }
            var track = await _dbContext.Tracks.FindAsync(id);
            if (DeleteTrack == null)
            {
                return NotFound();
            }

            _dbContext.Tracks.Remove(track);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


        private bool TrackExists(long id)
        {
            return (_dbContext.Tracks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
