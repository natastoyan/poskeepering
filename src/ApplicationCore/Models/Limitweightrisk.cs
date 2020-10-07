using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Limitweightrisk
    {
        public string Ccurrcode { get; set; }
        public DateTime Dsetdate { get; set; }
        public string Copcode { get; set; }
        public decimal? Ipresettldays { get; set; }
        public decimal? Nriskweight { get; set; }
        public decimal? Bflagdays { get; set; }

        public virtual Currency CcurrcodeNavigation { get; set; }
        public virtual Operation CopcodeNavigation { get; set; }
    }
}
