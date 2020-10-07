using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PVClientpl
    {
        public DateTime Ddate { get; set; }
        public string Ccontrcode { get; set; }
        public decimal? Fxd { get; set; }
        public decimal? Fxw { get; set; }
        public decimal? Fxm { get; set; }
        public decimal? Fxy { get; set; }
        public decimal? Mmd { get; set; }
        public decimal? Mmw { get; set; }
        public decimal? Mmm { get; set; }
        public decimal? Mmy { get; set; }
    }
}
