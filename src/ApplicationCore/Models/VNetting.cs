using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VNetting
    {
        public string Cnettcode { get; set; }
        public string Ccurrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
    }
}
