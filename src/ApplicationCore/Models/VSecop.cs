using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSecop
    {
        public string Corgcode { get; set; }
        public decimal? Nsum { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public string Cseccode { get; set; }
    }
}
