using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VCurrentfxexp
    {
        public string Ccurrcode { get; set; }
        public DateTime Ddate { get; set; }
        public decimal? Nexp { get; set; }
        public decimal? Nfx { get; set; }
        public decimal? Ntot { get; set; }
        public decimal? Ntraderesult { get; set; }
    }
}
