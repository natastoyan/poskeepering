using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VNettposfx
    {
        public string Ccurrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public bool? Isb { get; set; }
        public decimal? Ndealkey { get; set; }
        public string Copcode { get; set; }
        public string Cnettcode { get; set; }
        public string Ccontrcode { get; set; }
        public string Cdealnumber { get; set; }
        public string Cticket { get; set; }
        public decimal? Iorder { get; set; }
        public bool? Bnetting { get; set; }
        public decimal? Nrate { get; set; }
    }
}
