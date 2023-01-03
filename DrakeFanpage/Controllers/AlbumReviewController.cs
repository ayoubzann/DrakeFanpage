using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DrakeFanpage.Models;
using DrakeFanpage.Data;
using Microsoft.EntityFrameworkCore;

namespace DrakeFanpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumReviewController : ControllerBase
    {
        private readonly FanpageContext _dbContext;

        public AlbumReviewController(FanpageContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/AlbumReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlbumReview>>> GetAlbumReviews()
        {
            if (_dbContext.AlbumReviews == null)
            {
                return NotFound();
            }
            return await _dbContext.AlbumReviews.ToListAsync();
        }

        //GET: api/AlbumReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlbumReview>> GetAlbumReviews(int id)
        {
            if (_dbContext.AlbumReviews == null)
            {
                return NotFound();
            }
            var albumReview = await _dbContext.AlbumReviews.FindAsync(id);

            if (albumReview == null)
            {
                return NotFound();
            }
            return albumReview;
        }

        // POST: api/AlbumReviews
        [HttpPost]
        public async Task<ActionResult<AlbumReview>> PostAlbumReview(AlbumReview albumReview)
        {
            _dbContext.AlbumReviews.Add(albumReview);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAlbumReviews), new { id = albumReview.Id }, albumReview);
        }

        // PUT: api/AlbumReviews/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlbumReview(int id, AlbumReview albumReview)
        {
            if (id != albumReview.Id)
            {
                return BadRequest();
            }
            _dbContext.Entry(albumReview).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumReviewExists(id))
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

        // DELETE: api/AlbumReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlbumReview(int id)
        {
            if (_dbContext.AlbumReviews == null)
            {
                return NotFound();
            }
            var albumReview = await _dbContext.AlbumReviews.FindAsync(id);
            if (DeleteAlbumReview == null)
            {
                return NotFound();
            }

            _dbContext.AlbumReviews.Remove(albumReview);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


        private bool AlbumReviewExists(long id)
        {
            return (_dbContext.AlbumReviews?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
