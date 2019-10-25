using System.Collections.Generic;
using System;

namespace Treats.Models
{
  public class Flavor
  {
    public Flavor()

        {
            this.AllTreats = new HashSet<TreatFlavor>();
        }
    public int FlavorId { get; set; }
    public string FlavorType { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<TreatFlavor> AllTreats { get;}
  }
}