using System.Collections.Generic;

namespace Treats.Models
{
  public class Treat
    {
        public Treat()
        {
            this.TreatFlavors = new HashSet<TreatFlavor>();
        }

        public int TreatId { get; set; }
        public string Type { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<TreatFlavor> TreatFlavors { get; set; } 
    }
}