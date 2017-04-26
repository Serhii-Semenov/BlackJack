namespace BJDataLevel.Model
{
    public partial class BalansPlayers
    {
        public int Id { get; set; }

        public int IdPlayer { get; set; }

        public int Balance { get; set; }

        public int CreditBalance { get; set; }

        public virtual Players Players { get; set; }
    }
}
