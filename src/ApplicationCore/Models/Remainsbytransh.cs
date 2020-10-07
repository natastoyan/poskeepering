using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Remainsbytransh
    {
        public decimal Nacckey { get; set; }
        public DateTime Ddeliverydate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Ndeb { get; set; }
        public decimal? Ncred { get; set; }
        public decimal? Btrueflag { get; set; }
        public decimal Ntranshkey { get; set; }

        public virtual Secacc NacckeyNavigation { get; set; }
    }
}
