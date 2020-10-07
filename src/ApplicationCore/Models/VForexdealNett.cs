using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VForexdealNett
    {
        public decimal Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public string Ccontrcode { get; set; }
        public string Cticket { get; set; }
        public string Ccurrcodeb { get; set; }
        public string Ccurrcodes { get; set; }
        public decimal? Nsumb { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Nsums { get; set; }
        public DateTime? Dvaluedateb { get; set; }
        public string Csalespersonid { get; set; }
        public DateTime? Dvaluedates { get; set; }
        public string Caccb { get; set; }
        public string Caccs { get; set; }
        public string Cathenabookcode { get; set; }
        public string Catlascounter { get; set; }
        public string Corgtypecode { get; set; }
    }
}
