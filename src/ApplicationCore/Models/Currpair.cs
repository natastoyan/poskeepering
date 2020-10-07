using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Currpair
    {
        public Currpair()
        {
            Swap = new HashSet<Swap>();
        }

        public string Cpair { get; set; }
        public string Ccurrcode1 { get; set; }
        public string Ccurrcode2 { get; set; }

        public virtual Currency Ccurrcode1Navigation { get; set; }
        public virtual Currency Ccurrcode2Navigation { get; set; }
        public virtual ICollection<Swap> Swap { get; set; }
    }
}
