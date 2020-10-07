using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIeDealsummit
    {
        public decimal? Exttradeid { get; set; }
        public string Cdealtype { get; set; }
        public string Cdealtable { get; set; }
        public DateTime? Tradedate { get; set; }
        public decimal? Nsummitdealkey { get; set; }
        public string Csummitreference { get; set; }
        public string Ctype { get; set; }
        public string Action { get; set; }
        public string Cdealbody { get; set; }
    }
}
