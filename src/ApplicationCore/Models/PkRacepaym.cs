using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkRacepaym
    {
        public decimal Nracepaymkey { get; set; }
        public decimal? Nsum { get; set; }
        public string Cpayer { get; set; }
        public string Creciver { get; set; }
        public string Cdescription { get; set; }
        public string Cchannel { get; set; }
        public string Cracenumber { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
    }
}
