namespace FantasySlayer
{
    public record Player
    {
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsBenched { get; set; }
        public string Position { get; set; }
        public double ProjectedPoints { get; set; }
    }
}
