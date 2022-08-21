using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MetroidAbilityTrackerApi.Models;

namespace MetroidAbilityTrackerApi.Data
{
    public class MetroidAbilityTrackerApiContext : DbContext
    {
        public MetroidAbilityTrackerApiContext (DbContextOptions<MetroidAbilityTrackerApiContext> options)
            : base(options)
        {
            
        }

        public DbSet<Game> Game { get; set; }

        public DbSet<Abilities> Abilities { get; set; }

        public DbSet<Tracker>Trackers { get; set; }







    }
}
