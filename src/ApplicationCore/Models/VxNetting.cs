using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VxNetting
    {
        public string Ccurr1 { get; set; }
        public string Ccurr2 { get; set; }
        public string Cnettcode { get; set; }
        public string Ccontrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum1 { get; set; }
        public decimal? Nsum2 { get; set; }
    }
}
