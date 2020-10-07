using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Userprofiles
    {
        public decimal Nuserkey { get; set; }
        public decimal Nsystemkey { get; set; }
        public decimal Nprofilekey { get; set; }
        public decimal Nrolekey { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Bmandatory { get; set; }
    }
}
