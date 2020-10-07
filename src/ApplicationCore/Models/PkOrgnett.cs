using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkOrgnett
    {
        public decimal Norgnettkey { get; set; }
        public string Corgcode { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Bnetting { get; set; }
        public decimal? Inettingtype { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
    }
}
