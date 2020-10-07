using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIrr
    {
        public DateTime? Dcoupondate { get; set; }
        public DateTime Ddate { get; set; }
        public string Ctransh { get; set; }
        public decimal? Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public string Ccouponrate { get; set; }
        public DateTime? Dmaturitydate { get; set; }
        public decimal? Nfacevalue { get; set; }
        public decimal? Nnom { get; set; }
        public decimal? Nytm { get; set; }
        public decimal? Navgbuyprice { get; set; }
        public decimal? Nmtmprice { get; set; }
        public string Cyear { get; set; }
        public string Cnumberperiod { get; set; }
        public decimal? Npay { get; set; }
        public decimal? Ncurpv { get; set; }
        public decimal? Ncurpvmult { get; set; }
        public decimal? Nirr { get; set; }
        public decimal? Ndur { get; set; }
        public string Cinrrep { get; set; }
        public string Cdurrep { get; set; }
        public decimal? Ndaystomatur { get; set; }
        public decimal? Nfulldur { get; set; }
        public decimal? Nfullirr { get; set; }
        public decimal? Nfullytm { get; set; }
        public decimal? Nprirr { get; set; }
    }
}
