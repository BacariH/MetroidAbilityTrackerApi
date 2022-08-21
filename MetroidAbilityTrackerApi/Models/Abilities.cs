using System.Text.Json.Serialization;

namespace MetroidAbilityTrackerApi.Models
{
    public class Abilities
    {
        public int ID { get; set; }
        public string AbilityName { get; set; }
        public string AbilityDescription { get; set; }

        [JsonIgnore]
        public ICollection<Tracker> Tracker { get; set; }
    }
}