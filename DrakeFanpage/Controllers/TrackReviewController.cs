using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DrakeFanpage.Models;
using DrakeFanpage.Data;
using Microsoft.EntityFrameworkCore;

namespace DrakeFanpage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackReviewController : ControllerBase
    {
        private readonly FanpageContext _dbContext;

        public TrackReviewController(FanpageContext dbContext)
        {
            _dbContext = dbContext;
        }

        //GET: api/TrackReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrackReview>>> GetTrackReviews()
        {
            if (_dbContext.TrackReviews == null)
            {
                return NotFound();
            }
            return await _dbContext.TrackReviews.ToListAsync();
        }

        //GET: api/TrackReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrackReview>> GetTrackReviews(int id)
        {
            if (_dbContext.TrackReviews == null)
            {
                return NotFound();
            }
            var trackReview = await _dbContext.TrackReviews.FindAsync(id);

            if (trackReview == null)
            {
                return NotFound();
            }
            return trackReview;
        }

        // POST: api/TrackReviews
        [HttpPost]
        public async Task<ActionResult<TrackReview>> PostTrackReview(TrackReview trackReview)
        {
            _dbContext.TrackReviews.Add(trackReview);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTrackReviews), new { id = trackReview.Id }, trackReview);
        }

        // PUT: api/TrackReviews/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrackReview(int id, TrackReview trackReview)
        {
            if (id != trackReview.Id)
            {
                return BadRequest();
            }
            _dbContext.Entry(trackReview).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackReviewExists(id))
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

        // DELETE: api/TrackReviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrackReview(int id)
        {
            if (_dbContext.TrackReviews == null)
            {
                return NotFound();
            }
            var trackReview = await _dbContext.TrackReviews.FindAsync(id);
            if (DeleteTrackReview == null)
            {
                return NotFound();
            }

            _dbContext.TrackReviews.Remove(trackReview);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }


        private bool TrackReviewExists(long id)
        {
            return (_dbContext.TrackReviews?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
