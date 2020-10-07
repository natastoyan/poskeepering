using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPkOrgnett
    {
        public decimal Norgnettkey { get; set; }
        public decimal? Bnetting { get; set; }
        public string Ccurrcode { get; set; }
        public string Corgcode { get; set; }
        public decimal? Inettingtype { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
        public decimal? Naccesscontrolfield { get; set; }
    }
}
