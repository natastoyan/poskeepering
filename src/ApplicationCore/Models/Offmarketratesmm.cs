using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Offmarketratesmm
    {
        public DateTime? Ddate { get; set; }
        public decimal? Nterm { get; set; }
        public decimal? Nratemin { get; set; }
        public decimal? Nratemax { get; set; }
        public string Cccy { get; set; }
        public decimal Noffmrmmkey { get; set; }
    }
}
