using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VNetting1
    {
        public decimal? Nacckey { get; set; }
        public string Cnettcode { get; set; }
        public string Ccurrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
    }
}
