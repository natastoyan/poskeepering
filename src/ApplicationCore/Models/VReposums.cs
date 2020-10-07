using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VReposums
    {
        public DateTime Ddate { get; set; }
        public decimal Ndealkey { get; set; }
        public decimal Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public string Ccouponrate { get; set; }
        public DateTime Dmaturitydate { get; set; }
        public string Cclassif { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nsumnom { get; set; }
        public decimal? Nprice { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nlastmc { get; set; }
        public decimal? Nnewmc { get; set; }
        public decimal? Nmtmprice { get; set; }
        public decimal? Nmtm { get; set; }
        public decimal? Nmtmplusmc { get; set; }
        public decimal? Nmarginsum { get; set; }
    }
}
