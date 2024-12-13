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

        public async Task<Tracker> CreateTrackerItem(Tracker item)
        {
            
            await _ctx.Trackers.AddAsync(item);
            await _ctx.SaveChangesAsync();


            return item;

        }

        public async Task DeleteTrackerItem(int id)
        {
            if (id == null) throw new Exception(); // need to log this return result

            var itemToDelete = await _ctx.Trackers.SingleOrDefaultAsync(t => t.ID == id);

             _ctx.Trackers.Remove(itemToDelete);

            await _ctx.SaveChangesAsync();

            return;
        }

        public async Task<ICollection<Tracker>> GetAllTrackersItems()
        {
            return await _ctx.Trackers
                        .Include(t => t.Game)
                        .Include(t => t.Abilities)
                        .ToListAsync();
        }

        public async Task<Tracker> GetSpecificTrackerItem(int id)
        {
            //TODO
            //Handle if there is a null value for id
            
           var trackedItem = await _ctx.Trackers
                .Include(t => t.Game)
                .Include(t => t.Abilities)
                .FirstOrDefaultAsync(trackerId => trackerId.ID == id);

            if(trackedItem == null) return null;

            return trackedItem;
            
        }

        public async Task UpdateTrackerItem(int id, Tracker trackerObj)
        {
            
            
            if(trackerObj == null) return;



            if(id != trackerObj.ID)
            {
                return;
            }


            try
            {
                _ctx.Entry(trackerObj).State = EntityState.Modified;
                await _ctx.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                throw new Exception();
            }

            return;
            
          
        }

        //TODO:
        //Create a tracker exist property for this repo
        /*private bool TrackerExists(int id)
        {
            return _ctx.Trackers?.Any(e => e.ID == id).GetValueOrDefault();
        }*/
    }
}
