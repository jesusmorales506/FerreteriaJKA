using Microsoft.EntityFrameworkCore;

namespace FerreteriaJKA.DAL
{
    public class FerreteriaContext: DbContext
    {   
            public FerreteriaContext() { }

            public FerreteriaContext(DbContextOptions<FerreteriaContext> options) : base(options) { }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer();
            }

        }
    }