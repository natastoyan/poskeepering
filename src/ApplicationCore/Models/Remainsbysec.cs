using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Remainsbysec
    {
        public string Cseccode { get; set; }
        public decimal Nacckey { get; set; }
        public DateTime Ddeliverydate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Ndeb { get; set; }
        public decimal? Ncred { get; set; }
        public decimal? Btrueflag { get; set; }

        public virtual Secacc NacckeyNavigation { get; set; }
    }
}
