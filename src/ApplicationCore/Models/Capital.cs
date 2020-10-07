using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Capital
    {
        public DateTime Ddate { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Ncapital { get; set; }
        public decimal? Nlimit { get; set; }

        public virtual Currency CcurrcodeNavigation { get; set; }
    }
}
