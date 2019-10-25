using System.Collections.Generic;

namespace Treats.Models
{
  public class Treat
    {
        public Treat()
        {
            this.TreatList = new HashSet<TreatFlavor>();
        }

        public int TreatId { get; set; }
        public string Type { get; set; }
        public virtual ICollection<TreatFlavor> TreatList { get; set; } 
    }
}