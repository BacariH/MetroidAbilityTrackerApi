using MetroidAbilityTrackerApi.Models;

namespace MetroidAbilityTrackerApi.Data
{
    public class DbInitializer
    {

        public static void Seed(MetroidAbilityTrackerApiContext context)
        {

            //Understand this class more
            if (context.Trackers.Any() && context.Abilities.Any()) return; //DB has already been seeded


            var firstMetroidGame = new Game()
            {
                GameName = "Metroid",
                GameReleaseDate = DateTime.Parse("1986-02-18")
            };

            var secondMetroidGame = new Game()
            {
                GameName = "Metroid 2 Return of Samus",
                GameReleaseDate = DateTime.Parse("1996-12-11")
            };


            var abilities = new Abilities[]
            {
                     new Abilities()
                    {
                        AbilityName = "Morph Ball",
                        AbilityDescription = "Transform into a ball and roll around"
                    },

                    new Abilities()
                    {
                        AbilityName = "Charge Beam",
                        AbilityDescription = "Charge your power beam to unleash more damage"
                    },

                    new Abilities()
                    {
                        AbilityName = "Space Jump",
                        AbilityDescription = "Jump even higher than before!!"
                    }
            };

            var trackerOne = new Tracker()
            {
                Game = firstMetroidGame,
                Abilities = abilities
            };

            var trackerTwo = new Tracker()
            {
                Game = secondMetroidGame,
                Abilities = abilities
            };

            context.Trackers.Add(trackerOne);
            context.Trackers.Add(trackerTwo);
            context.SaveChanges();
        }
    
    }
}
