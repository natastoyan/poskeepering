using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Remains
    {
        public DateTime? Dvaluedate { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nacckey { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Ndeb { get; set; }
        public decimal? Ncred { get; set; }
        public decimal? Btrueflag { get; set; }
        public decimal? Navail { get; set; }
        public decimal? Nremocp { get; set; }
        public decimal? Nremliq { get; set; }
        public decimal? Nsettcred { get; set; }

        public virtual Currency CcurrcodeNavigation { get; set; }
        public virtual CurraccOld NacckeyNavigation { get; set; }
    }
}
