using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Treats.Models
{
  public class TreatsContext : IdentityDbContext<IdentityUser>
  {
    public virtual DbSet<Treat> Treat { get; set; }
    public DbSet<Flavor> Flavor { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }
    public DbSet<ApplicationUser> ApplicationUser { get; set; }
    public TreatsContext(DbContextOptions options) : base(options) { }
  }
}