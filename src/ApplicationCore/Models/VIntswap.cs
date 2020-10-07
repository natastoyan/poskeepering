using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIntswap
    {
        public DateTime? Dcontrdate { get; set; }
        public DateTime? Dvaluedateb { get; set; }
        public DateTime? Dvaluedateb2 { get; set; }
        public string Ccontrcode { get; set; }
        public string Cdepartcode { get; set; }
        public string Ccurrcodeb { get; set; }
        public string Ccurrcodes { get; set; }
        public decimal? Nsums { get; set; }
        public decimal? Nsums2 { get; set; }
        public decimal? Nsumb { get; set; }
        public decimal? Nsumb2 { get; set; }
        public decimal? Isb { get; set; }
        public decimal? Ndeporate { get; set; }
        public decimal? Nrate2 { get; set; }
        public string Cfixcurrcode { get; set; }
        public decimal? Nswaprate { get; set; }
    }
}
