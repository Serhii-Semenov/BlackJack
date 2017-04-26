using BJDataLevel.Data;
using System.Data.Entity;

namespace BJDataLevel
{
    class UserContext : DbContext
    {
        public UserContext() : base("DbConnection") { }

        public DbSet<Player> Players { get; set; }

    }
}
