using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSwpdpl
    {
        public DateTime Ddate { get; set; }
        public decimal Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public DateTime? Dvaluedateb { get; set; }
        public DateTime? Dvaluedateb2 { get; set; }
        public string Ccurrcodeb { get; set; }
        public string Ccurrcodes { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nsumb { get; set; }
        public decimal? Nsums { get; set; }
        public decimal? Nsumb2 { get; set; }
        public decimal? Nsums2 { get; set; }
        public string Cswaprate { get; set; }
        public string Ccontrcode { get; set; }
        public decimal? Ncbrate { get; set; }
        public decimal? Ndplrur { get; set; }
        public decimal? Ndplusd { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Nrate2 { get; set; }
        public string Cdealercode { get; set; }
        public string Cdepartcode { get; set; }
    }
}
