using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Secpaym
    {
        public decimal Nsecpaymkey { get; set; }
        public decimal? Nacckey { get; set; }
        public string Copcode { get; set; }
        public DateTime? Ddeliverydate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Ndealkey { get; set; }
        public decimal? Bstorno { get; set; }
        public decimal? Isb { get; set; }
        public decimal? Ntranshkey { get; set; }

        public virtual Secacc NacckeyNavigation { get; set; }
    }
}
