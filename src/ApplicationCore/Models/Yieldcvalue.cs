using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Yieldcvalue
    {
        public string Cperiodcode { get; set; }
        public string Csource { get; set; }
        public DateTime Ddate { get; set; }
        public decimal? Ncurveval { get; set; }
        public decimal? Noneyeareq { get; set; }
        public decimal? Ntenpctmove { get; set; }
        public decimal? Nmtm { get; set; }
        public decimal? Nprice1 { get; set; }
        public decimal? Nprice2 { get; set; }
    }
}
