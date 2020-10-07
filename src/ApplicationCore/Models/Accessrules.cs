using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Accessrules
    {
        public decimal? Nmenukey { get; set; }
        public decimal? Nrolekey { get; set; }
        public decimal? Naccrightkey { get; set; }
        public decimal? Baddtosystem { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }

        public virtual Roles NrolekeyNavigation { get; set; }
    }
}
