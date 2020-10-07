using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VReportstatTick
    {
        public decimal Nkey { get; set; }
        public decimal? Nuserkey { get; set; }
        public string Creportfilename { get; set; }
        public DateTime? Dreportdate { get; set; }
        public string Cdealtype { get; set; }
        public string Cparams { get; set; }
        public string Cvalues { get; set; }
        public DateTime? Dlaunchtime { get; set; }
        public DateTime? Dreadydate { get; set; }
        public DateTime? Dreadytime { get; set; }
        public string Cdealnumber { get; set; }
        public string Cprinter { get; set; }
        public string Cusername { get; set; }
        public string Ccomment { get; set; }
    }
}
