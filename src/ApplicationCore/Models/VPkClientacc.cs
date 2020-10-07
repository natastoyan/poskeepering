using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPkClientacc
    {
        public decimal Nclientacckey { get; set; }
        public bool? Bactive { get; set; }
        public string Cathenenum { get; set; }
        public string Ccurrcode { get; set; }
        public string Cficlass { get; set; }
        public string Corgcode { get; set; }
        public decimal? Nacckey { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
        public decimal? Naccesscontrolfield { get; set; }
    }
}
