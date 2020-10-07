using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSecurityprofiles
    {
        public string Owner { get; set; }
        public decimal Nprofilekey { get; set; }
        public string Cprofilekey { get; set; }
        public string Cprofilename { get; set; }
        public decimal? Ipasswtrycount { get; set; }
        public DateTime? Dexpirationdate { get; set; }
        public decimal? Nminpasswlength { get; set; }
        public decimal? Nchangeperiod { get; set; }
        public decimal? Ioneusersess { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }
    }
}
