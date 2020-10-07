using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRptDepoatlas
    {
        public DateTime? Dcontrdate { get; set; }
        public string Cdealnumber { get; set; }
        public string Ccurrcode { get; set; }
        public string Ccontrcode { get; set; }
        public decimal? Isb { get; set; }
        public string Crate { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public DateTime? Dvaluedate2 { get; set; }
        public string Cbookcode { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Ninterest { get; set; }
        public string Cticket { get; set; }
        public decimal? Binternal { get; set; }
        public decimal? Nsum2 { get; set; }
        public string BooksCbookcode { get; set; }
        public decimal? Ninterfacekey { get; set; }
        public string Cbookname { get; set; }
        public bool? Batlasexport { get; set; }
        public string Cmessage { get; set; }
        public string Cstatus { get; set; }
    }
}
