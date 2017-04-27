namespace BJDataLevel.Model
{
    using System.Data.Entity;
    
    public class BJContext : DbContext
    {
        public BJContext()
            : base("name=BJContext")
       {
            // Database.SetInitializer<Model1>(new CreateDatabaseIfNotExists<Model1>());
                //Database.SetInitializer<Model1>(new DropCreateDatabaseAlways<Model1>());                  
        }

        public virtual DbSet<BalansPlayers> BalansPlayers { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Statistics> Statistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Players>()
                .HasMany(e => e.BalansPlayers)
                .WithRequired(e => e.Players)
                .HasForeignKey(e => e.IdPlayer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Players>()
                .HasMany(e => e.Statistics)
                .WithRequired(e => e.Players)
                .HasForeignKey(e => e.IdPlayer)
                .WillCascadeOnDelete(false);
        }
    }
}