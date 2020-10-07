using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VNettpos1
    {
        public string Ccurrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public string Cdealnumber { get; set; }
        public string Cticket { get; set; }
        public string Cnettcode { get; set; }
        public string Ccontrcode { get; set; }
    }
}
