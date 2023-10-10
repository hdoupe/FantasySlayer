namespace FantasySlayer
{
    public class Team
    {
        public List<Player> Players {  get; set; }

        public bool IsValid()
        {
            return this.Players is not null && this.Players.Count > 0;
        }
    }
}
