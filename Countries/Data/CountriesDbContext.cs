using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Data
{
    namespace Countries.Models
    {
        public class CountriesDbContext : DbContext
        {
            public DbSet<Country> Countries { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=.;Database=Countries;Integrated Security=True");
                }

                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
