using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSbsecsaldo
    {
        public DateTime Ddate { get; set; }
        public decimal Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public DateTime Dmaturitydate { get; set; }
        public string Ccouponrate { get; set; }
        public decimal? Nsumnomb { get; set; }
        public decimal? Ncoupb { get; set; }
        public decimal? Nsumb { get; set; }
        public decimal? Nfullsumb { get; set; }
        public decimal? Nsumnoms { get; set; }
        public decimal? Ncoups { get; set; }
        public decimal? Nsums { get; set; }
        public decimal? Nfullsums { get; set; }
        public decimal? Noffer { get; set; }
    }
}
