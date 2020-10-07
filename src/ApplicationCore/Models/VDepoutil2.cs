using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VDepoutil2
    {
        public DateTime Ddate { get; set; }
        public string Ccontrcode { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nrate { get; set; }
    }
}
