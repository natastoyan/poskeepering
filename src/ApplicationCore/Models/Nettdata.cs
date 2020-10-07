using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Nettdata
    {
        public decimal? Nacckey { get; set; }
        public DateTime Dvaluedate { get; set; }
        public string Ccurrcode { get; set; }
        public string Cnettcode { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nacckeyminus { get; set; }
        public decimal? Nacckeyplus { get; set; }
    }
}
