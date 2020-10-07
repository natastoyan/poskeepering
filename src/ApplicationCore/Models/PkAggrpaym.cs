using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkAggrpaym
    {
        public decimal Naggrpaymkey { get; set; }
        public decimal? Nclientacckey { get; set; }
        public decimal? Nsum { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nacckey { get; set; }
    }
}
