using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FerreteriaJKA.DAL
{
    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public AuthContext() { }
        public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer();
        }
    }
}
