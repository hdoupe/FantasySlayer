using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySlayer
{
    public record TeamConfig
    {
        public Team? team1 { get; set; }
        public Team? team2 { get; set; }

        public TeamConfig() { }

        public TeamConfig(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }
    }
}
