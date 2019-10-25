using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Treats.Models
{
  public class TreatsContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treat> Treat { get; set; }
    public DbSet<Flavor> Flavor { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }
    
    public TreatsContext(DbContextOptions options) : base(options) { }
  }
}