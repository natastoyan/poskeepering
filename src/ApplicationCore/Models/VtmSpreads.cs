using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VtmSpreads
    {
        public decimal Nproductkey { get; set; }
        public decimal Nperiodkey { get; set; }
        public DateTime Ddate { get; set; }
        public decimal? Nvalue { get; set; }
        public string Cvtmgroup { get; set; }

        public virtual VtmPeriods NperiodkeyNavigation { get; set; }
        public virtual VtmProducts NproductkeyNavigation { get; set; }
    }
}
