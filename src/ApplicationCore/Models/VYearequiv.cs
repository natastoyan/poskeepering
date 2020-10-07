using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VYearequiv
    {
        public DateTime Ddate { get; set; }
        public string Cperiod { get; set; }
        public decimal? Nequiv { get; set; }
        public decimal? Nyield { get; set; }
        public decimal? Npldown { get; set; }
        public decimal? Nmtm { get; set; }
        public decimal? Nnom { get; set; }
        public decimal? Iorder { get; set; }
    }
}
