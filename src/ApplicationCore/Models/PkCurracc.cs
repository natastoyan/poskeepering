using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkCurracc
    {
        public decimal Nacckey { get; set; }
        public string Ccurrcode { get; set; }
        public string Corgcode { get; set; }
        public string Cacctypecode { get; set; }
        public string Cacc { get; set; }
        public string Crequivisits { get; set; }
        public decimal? Iorder { get; set; }
        public string Cdefopers { get; set; }
        public decimal? Isb { get; set; }
        public string Caccbal { get; set; }
        public string Cpaymforinter { get; set; }
        public decimal? Bincludedealpos { get; set; }
        public string Cdiasoftcode { get; set; }
        public string Ccorrcode { get; set; }
        public string Caccnum { get; set; }
        public string Csettplace { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
        public string Ctradingvenue { get; set; }
        public string Cathenenum { get; set; }
        public bool? Bactive { get; set; }
        public bool? Baggregate { get; set; }
        public bool? Bnostro { get; set; }
        public bool? Inostrobalance { get; set; }
        public decimal? Cminnostrobalance { get; set; }
    }
}
