using System.Text.Json.Serialization;

namespace MetroidAbilityTrackerApi.Models
{
    public class Tracker
    {
        public int ID { get; set; }

        public Game? Game { get; set; } 


        public ICollection<Abilities>? Abilities { get; set; }

    }
}
