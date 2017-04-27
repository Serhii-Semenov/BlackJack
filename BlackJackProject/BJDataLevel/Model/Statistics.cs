namespace BJDataLevel.Model
{
    public partial class Statistics
    {
        public int Id { get; set; }

        public int IdPlayer { get; set; }

        public int TotalGames { get; set; }

        public int WinGames { get; set; }

        public int LostGames { get; set; }

        public int DrawGames { get; set; }

        public virtual Players Players { get; set; }
    }
}
