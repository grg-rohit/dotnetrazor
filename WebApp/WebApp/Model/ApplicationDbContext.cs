using Microsoft.EntityFrameworkCore;

namespace WebApp.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
            
        public DbSet<Item> Item { get; set; }
    }
}
