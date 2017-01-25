using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsDatabase
{
    class SportStatsContext : DbContext
    {
        public DbSet<Player>Player { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Stats> Stats { get; set; }
    }
}
