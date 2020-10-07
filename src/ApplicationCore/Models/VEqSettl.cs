using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VEqSettl
    {
        public DateTime? Dtradedate { get; set; }
        public DateTime? Dcashsettldate { get; set; }
        public decimal Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public string Csecurity { get; set; }
        public bool? Isb { get; set; }
        public decimal? Nquantity { get; set; }
        public decimal? Nprice { get; set; }
        public string Ctradecurrcode { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nacckey { get; set; }
        public string Cacc { get; set; }
        public string Cacccurrcode { get; set; }
        public decimal? Nsum1 { get; set; }
    }
}
