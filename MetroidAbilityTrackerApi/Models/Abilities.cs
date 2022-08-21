using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MetroidAbilityTrackerApi.Models
{
    public class Abilities
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(25)]
        public string? AbilityName { get; set; }
        [Required]
        [MaxLength(100)]
        public string? AbilityDescription { get; set; }


        //TODO: Change these to make sure abilities isnt continously increamting with every ability made.
        //after an instance is created we need to make sure that the auto increament value stays within the tracker scoop

        [JsonIgnore]
        public ICollection<Tracker>? Tracker { get; set; }
    }
}