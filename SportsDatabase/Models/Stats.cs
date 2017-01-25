using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsDatabase
{
    class Stats
    {
        public int Id { get; set; }
        public int Touchdowns { get; set; }
        public int PassingYards { get; set; }
        public int RushingYards { get; set; }
        public int Compleations { get; set; }
        public int CompleationPercentage { get; set; }
        public int Interceptions { get; set; }
        public int Fumbles { get; set; }
        public Player Player { get; set; }
        public Team Team { get; set; }

    }
}
