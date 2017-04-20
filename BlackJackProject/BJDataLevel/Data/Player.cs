namespace BJDataLevel.Data
{
    public class Player:BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public int CreditBalance { get; set; }
    }
}
