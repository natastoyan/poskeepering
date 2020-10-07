using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Rates
    {
        public string Ccurrcode2 { get; set; }
        public string Ccurrcode1 { get; set; }
        public DateTime Ddate { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Icot { get; set; }
        public string Csourcecode { get; set; }
        public decimal? Ncbrcoeff { get; set; }

        public virtual Currency Ccurrcode1Navigation { get; set; }
        public virtual Currency Ccurrcode2Navigation { get; set; }
        public virtual Pricesource CsourcecodeNavigation { get; set; }
    }
}
