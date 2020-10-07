using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPkCurrweights
    {
        public decimal Ncurrweightskey { get; set; }
        public decimal? Bweight { get; set; }
        public string Ccurrcode1 { get; set; }
        public string Ccurrcode2 { get; set; }
        public decimal? Iregulusweight { get; set; }
        public decimal? Ndelta { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
        public decimal? Naccesscontrolfield { get; set; }
    }
}
