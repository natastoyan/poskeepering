using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkAssetlocks
    {
        public decimal Nassetlockskey { get; set; }
        public string Ctradercode { get; set; }
        public DateTime? Dtimestamp { get; set; }
        public decimal? Nlocked { get; set; }
        public string Corgcode { get; set; }
        public string Casset { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
        public string Ntypekey { get; set; }
        public bool? Bactive { get; set; }
        public decimal? Ndealkey { get; set; }
        public string Ctrdacc { get; set; }
    }
}
