using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace FantasySlayer
{
    public class FantasySlayer
    {
        public Team team1;
        public Team team2;

        public FantasySlayer(Team team1, Team team2) {
            this.team1 = team1;
            this.team2 = team2;
            this.ValidateTeams();
        }

        public FantasySlayer(string filePath)
        {
            (Team team1, Team team2) teams = this.LoadTeams(filePath);
            this.team1 = teams.team1;
            this.team2 = teams.team2;
            this.ValidateTeams();
        }

        public double CalculateWinProbability()
        {
            // TODO: Use team points to calculate the win probability for team1.
            double team1Points = 1;
            double team2Points = 1;

            // TODO: Hmmm, this could be improved...
            return team1Points > team2Points ? 1 : 0;
        }

        public List<String> SuggestedChanges()
        {
            // TODO:
            // - Flag players that are not playing this week (i.e. IsAvailable is False)
            // - Flag players that are injured (i.e. IsAvailable is False)
            // - Flag players that have a lower projected points value than their counterpart
            //   on the opposing team
            return new List<string> { "Come on, just do better."};
        }

        public void ValidateTeams()
        {
            // TODO: How could this provide the user with more information?
            if (!this.team1.IsValid() || !this.team2.IsValid())
            {
                throw new Exception("Team data not valid!");
            }
        }

        private (Team, Team) LoadTeams(string filePath)
        {
            var teamData = new TeamConfig { };
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                teamData = JsonConvert.DeserializeObject<TeamConfig>(json);
            }

            return (teamData.team1, teamData.team2);
        }

        public override string ToString()
        {
            string teamJson = JsonConvert.SerializeObject(new TeamConfig(this.team1, this.team2), Formatting.Indented);
            return teamJson;
        }
    }
}
