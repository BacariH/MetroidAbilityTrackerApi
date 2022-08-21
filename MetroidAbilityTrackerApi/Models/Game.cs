using System.ComponentModel.DataAnnotations;

namespace MetroidAbilityTrackerApi.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string? GameName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime GameReleaseDate { get; set; }

        //public virtual Tracker Tracker { get; set; }

    }
}
