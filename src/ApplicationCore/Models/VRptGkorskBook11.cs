using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRptGkorskBook11
    {
        public string Isin { get; set; }
        public string Ccomment { get; set; }
        public DateTime Dreportdate { get; set; }
        public string Cbookcode { get; set; }
        public decimal? Ntranshkey { get; set; }
        public decimal? Position0 { get; set; }
        public decimal? Position1 { get; set; }
        public decimal? Marketprice0 { get; set; }
        public decimal? Mtm0 { get; set; }
        public decimal? Intrday { get; set; }
        public decimal? Coupon { get; set; }
        public decimal? PAndL { get; set; }
        public decimal? Mtm1 { get; set; }
        public decimal? Marketprice1 { get; set; }
        public decimal? Posreval { get; set; }
    }
}
