using MetroidAbilityTrackerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MetroidAbilityTrackerApi.Data.Interfaces
{
    public class TrackerRepository : ITrackerRepository
    {

        private readonly MetroidAbilityTrackerApiContext _ctx;
        public TrackerRepository(MetroidAbilityTrackerApiContext ctx)
        {
            _ctx = ctx;
        }

        public Task<Tracker> CreateTrackerItem(Tracker item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTrackerItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Tracker>> GetAllTrackersItems()
        {
            return await _ctx.Trackers
                        .Include(t => t.Game)
                        .Include(t => t.Abilities)
                        .ToListAsync();
        }

        public Task<Tracker> GetSpecificTrackerItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTrackerItem(Tracker trackerObj)
        {
           /* if (id != tracker.ID)
            {
                return BadRequest();
            }



            try
            {
                _ctx.Entry(trackerObj).State = EntityState.Modified;

                await _ctx.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();*/
        }
    }
}
