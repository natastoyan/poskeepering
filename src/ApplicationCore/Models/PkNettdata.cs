using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkNettdata
    {
        public decimal? Nacckey { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public string Ccurrcode { get; set; }
        public string Cnettcode { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nacckeyminus { get; set; }
        public decimal? Nacckeyplus { get; set; }
        public decimal Nnettdatakey { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
    }
}
