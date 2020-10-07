using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VOffmarkettradesfx
    {
        public decimal Dealkey { get; set; }
        public string Ccy { get; set; }
        public DateTime? Dealdate { get; set; }
        public decimal? Dealrate { get; set; }
        public decimal? Minrate { get; set; }
        public decimal? Maxrate { get; set; }
        public decimal? Sumbuy { get; set; }
        public decimal? Sumsell { get; set; }
        public decimal? Term { get; set; }
    }
}
