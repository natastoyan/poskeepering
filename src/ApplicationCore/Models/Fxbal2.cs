using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Fxbal2
    {
        public DateTime Ddate { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nbal { get; set; }
        public decimal? Nvneb { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nday { get; set; }
    }
}
