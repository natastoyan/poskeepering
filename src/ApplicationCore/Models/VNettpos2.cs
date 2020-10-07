using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VNettpos2
    {
        public string Ccurrcode1 { get; set; }
        public string Ccurrcode2 { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum1 { get; set; }
        public decimal? Nsum2 { get; set; }
        public string Cdealnumber { get; set; }
        public string Cticket { get; set; }
        public string Cnettcode { get; set; }
        public string Ccontrcode { get; set; }
    }
}
