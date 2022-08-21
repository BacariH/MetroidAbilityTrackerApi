using MetroidAbilityTrackerApi.Models;

namespace MetroidAbilityTrackerApi.Data.Interfaces
{
    public interface ITrackerRepository
    {
        Task<ICollection<Tracker>> GetAllTrackersItems();
        Task<Tracker> GetSpecificTrackerItem(int id);
        Task<Tracker> CreateTrackerItem(Tracker item);
        Task UpdateTrackerItem(int id,Tracker trackerObj);
        Task DeleteTrackerItem(int id);

    }
}
