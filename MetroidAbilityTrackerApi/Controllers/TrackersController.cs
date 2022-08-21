using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MetroidAbilityTrackerApi.Data;
using MetroidAbilityTrackerApi.Models;
using MetroidAbilityTrackerApi.Data.Interfaces;

namespace MetroidAbilityTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackersController : ControllerBase
    {
        private readonly ITrackerRepository _trackerRepo;
        public TrackersController(ITrackerRepository trackerRepo)
        {
            _trackerRepo = trackerRepo;
        }

        // GET: api/Trackers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tracker>>> GetTrackers()
        {
           return Ok(await _trackerRepo.GetAllTrackersItems());
        }

        // GET: api/Trackers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tracker>> GetTracker(int id)
        {
         /* if (_context.Trackers == null)
          {
              return NotFound();
          }
            var tracker = await _context.Trackers
                .Include(t => t.Game)
                .Include(t => t.Abilities)
                .SingleOrDefaultAsync(t => t.ID == id);

            if (tracker == null)
            {
                return NotFound();
            }

            return tracker; */

         return Ok(_trackerRepo.GetSpecificTrackerItem(id));
        }

        // PUT: api/Trackers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTracker(int id, Tracker tracker)
        {
            return NoContent();
        }

        // POST: api/Trackers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tracker>> PostTracker(Tracker tracker)
        {
            /*if (_context.Trackers == null)
            {
                return Problem("Entity set 'MetroidAbilityTrackerApiContext.Trackers'  is null.");
            }
              _context.Trackers.Add(tracker);
              await _context.SaveChangesAsync();

              return CreatedAtAction("GetTracker", new { id = tracker.ID }, tracker);*/
            return NoContent();
        }

        // DELETE: api/Trackers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTracker(int id)
        {
            /* if (_context.Trackers == null)
             {
                 return NotFound();
             }
             var tracker = await _context.Trackers.FindAsync(id);
             if (tracker == null)
             {
                 return NotFound();
             }

             _context.Trackers.Remove(tracker);
             await _context.SaveChangesAsync();

             return NoContent();*/
            return NoContent();
        }

        private bool TrackerExists(int id)
        {
            // return (_context.Trackers?.Any(e => e.ID == id)).GetValueOrDefault();
            return true;
        }
    }
}
