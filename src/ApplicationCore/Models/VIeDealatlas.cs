using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIeDealatlas
    {
        public decimal Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dregdate { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public decimal? Nprincipalamount { get; set; }
        public string Crecord { get; set; }
    }
}
