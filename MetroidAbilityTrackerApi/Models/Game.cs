using System.ComponentModel.DataAnnotations;

namespace MetroidAbilityTrackerApi.Models
{
    public class Game
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(20)]
        public string? GameName { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime GameReleaseDate { get; set; }


    }
}
