using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Reportstat
    {
        public decimal Nkey { get; set; }
        public decimal? Nuserkey { get; set; }
        public string Creportfilename { get; set; }
        public string Cparams { get; set; }
        public string Cvalues { get; set; }
        public DateTime? Dlaunchtime { get; set; }
        public DateTime? Dreadytime { get; set; }
        public string Cdealnumber { get; set; }
        public string Cprinter { get; set; }
        public decimal? Nwhandler { get; set; }
    }
}
