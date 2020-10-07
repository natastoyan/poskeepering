using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VFxn
    {
        public string Cnettcode { get; set; }
        public string Ccontrcode { get; set; }
        public string Ccurrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Bnetting { get; set; }
    }
}
