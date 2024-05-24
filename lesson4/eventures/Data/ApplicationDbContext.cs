using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eventures.Models;

namespace eventures.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<eventures.Models.User> User { get; set; } = default!;
        public DbSet<eventures.Models.Event> Event { get; set; } = default!;
    }
}
