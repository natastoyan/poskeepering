using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VBondcoupons
    {
        public decimal? Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public DateTime? Dmaturitydate { get; set; }
        public string Ccouponrate { get; set; }
        public string Cclassif { get; set; }
        public decimal? Nsecnom { get; set; }
        public DateTime? Dcoupondate { get; set; }
        public decimal? Nkupsum { get; set; }
        public decimal? Nport { get; set; }
        public decimal? Nkupport { get; set; }
        public decimal? Igroup { get; set; }
    }
}
