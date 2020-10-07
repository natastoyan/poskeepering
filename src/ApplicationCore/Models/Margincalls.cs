using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Margincalls
    {
        public decimal Ndealkey { get; set; }
        public DateTime Ddate { get; set; }
        public decimal? Nmargin { get; set; }
        public decimal? Nmarginsumlast { get; set; }
        public decimal Ntranshkey { get; set; }
    }
}
