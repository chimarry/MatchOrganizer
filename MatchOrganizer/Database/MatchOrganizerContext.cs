using Database.Entities;
using Database.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class MatchOrganizerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<PlayerStatistics> PlayerStatistics { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public MatchOrganizerContext(DbContextOptions<MatchOrganizerContext> dbContextOptions) : base(dbContextOptions)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Player>(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration<Team>(new TeamConfiguration());
            modelBuilder.ApplyConfiguration<Match>(new MatchConfiguration());
            modelBuilder.ApplyConfiguration<PlayerStatistics>(new PlayerStatisticsConfiguration());
            modelBuilder.ApplyConfiguration<Status>(new StatusConfiguration());
        }
    }
}
