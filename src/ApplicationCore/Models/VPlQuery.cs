using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPlQuery
    {
        public string Cbookcode { get; set; }
        public decimal? Ntranshkey { get; set; }
        public DateTime Ddate { get; set; }
        public decimal? Position0 { get; set; }
        public decimal? Marketprice { get; set; }
        public decimal? Mtm { get; set; }
        public decimal? Intrday { get; set; }
        public decimal? Coupon { get; set; }
        public decimal? PAndL { get; set; }
    }
}
