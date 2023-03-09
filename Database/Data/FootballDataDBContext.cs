using Database.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Data
{
    public class FootballDataDBContext : DbContext
    {
        public FootballDataDBContext()
        {

        }

        public FootballDataDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring (DbContextOptionsBuilder builder)
        {
            if(!builder.IsConfigured)
            {
                builder.UseSqlServer(@"Server=DESKTOP-Q3OSTOP;Database=FootballData;Trusted_Connection=True; trustServerCertificate=true");
            }
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
