using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Bondstat
    {
        public decimal? Ndealkey { get; set; }
        public DateTime? Ddealdate { get; set; }
        public decimal? Ntranshkey { get; set; }
        public decimal? Nsumb { get; set; }
        public decimal? Nsums { get; set; }
        public decimal? Nposbefore { get; set; }
        public decimal? Nposafter { get; set; }
        public decimal? Ndealprice { get; set; }
        public bool? Isb { get; set; }
        public decimal? Nweightedprice { get; set; }
        public decimal? Npl { get; set; }
    }
}
