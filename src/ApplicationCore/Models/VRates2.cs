using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRates2
    {
        public string Csource { get; set; }
        public string Ccurrcode1 { get; set; }
        public string Ccurrcode2 { get; set; }
        public decimal? Ncbrate1 { get; set; }
        public decimal? Ncbrateold1 { get; set; }
        public decimal? Ncbrate2 { get; set; }
        public decimal? Ncbrateold2 { get; set; }
        public decimal? Npresrate { get; set; }
        public decimal? Nrrurusdrate { get; set; }
        public DateTime? Ddate { get; set; }
    }
}
