using Microsoft.EntityFrameworkCore;

using Happy.Models;

namespace Happy.Database
{
  public class HappyDbContext : DbContext 
  {
    public HappyDbContext(DbContextOptions<HappyDbContext> options) : base(options)
    {
        
    }

    public DbSet<Orphanage> Orphanages { get; set; }
    public DbSet<ImageFile> Images { get; set; }
  }
}