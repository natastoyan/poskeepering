using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkRatecbrf
    {
        public DateTime? Dstartdate { get; set; }
        public decimal Nratekey { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
    }
}
