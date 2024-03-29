using System.Collections.Generic;

namespace Treats.Models
{
  public class Flavor
  {
    public Flavor()

        {
            this.TreatFlavors = new HashSet<TreatFlavor>();
        }
    public int FlavorId { get; set; }
    public string FlavorType { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<TreatFlavor> TreatFlavors { get; set;}
  }
}