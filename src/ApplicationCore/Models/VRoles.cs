using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRoles
    {
        public string Owner { get; set; }
        public decimal Nrolekey { get; set; }
        public string Crolecode { get; set; }
        public string Crolename { get; set; }
        public decimal? Bmandatory { get; set; }
        public decimal? Nsysytemkey { get; set; }
        public decimal? Nsystemkey { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Ilogverify { get; set; }
    }
}
