using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VFxexp
    {
        public string Ccurrcode { get; set; }
        public DateTime Ddate { get; set; }
        public decimal? Nexp { get; set; }
        public decimal? Nexpres { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Nexpusd { get; set; }
        public decimal? Nexusdres { get; set; }
    }
}
