using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Closedbondsdelivrub
    {
        public DateTime? Dclosedate { get; set; }
        public decimal Nbuydealkey { get; set; }
        public decimal Nselldealkey { get; set; }
        public decimal? Nsumnom { get; set; }
        public decimal? Icpf { get; set; }
        public DateTime Dportdate { get; set; }
        public decimal? Nytm { get; set; }
        public decimal Ntranshkey { get; set; }
        public DateTime? Daudittimestamp { get; set; }
    }
}
