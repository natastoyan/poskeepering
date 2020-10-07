using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Ourbankcapital
    {
        public DateTime Ddate { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nsum { get; set; }

        public virtual Currency CcurrcodeNavigation { get; set; }
    }
}
