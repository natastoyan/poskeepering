using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Couponcalcmethod
    {
        public Couponcalcmethod()
        {
            Securities = new HashSet<Securities>();
        }

        public string Csposcode { get; set; }
        public string Csposname { get; set; }

        public virtual ICollection<Securities> Securities { get; set; }
    }
}
