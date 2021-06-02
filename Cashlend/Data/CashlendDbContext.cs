using Microsoft.EntityFrameworkCore;

namespace Cashlend.Data
{
    public class CashlendDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Cashlend;Integrate Security=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
