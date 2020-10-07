using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VDpldepo
    {
        public string Ccurrcode { get; set; }
        public decimal? Boncall { get; set; }
        public decimal? Isb { get; set; }
        public DateTime Ddate { get; set; }
        public decimal Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public DateTime? Dvaluedate2 { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nsum2 { get; set; }
        public decimal? Nint { get; set; }
        public string Ccontrcode { get; set; }
        public decimal? Ndpl { get; set; }
        public decimal? Ndplusd { get; set; }
        public decimal? Ndplrur { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Ncbrate { get; set; }
        public decimal? Binternal { get; set; }
        public string Cbookcode { get; set; }
        public string Cintcounter { get; set; }
        public decimal? Blfmm { get; set; }
    }
}
