using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Couponmatrix
    {
        public DateTime Dcoupondate { get; set; }
        public decimal? Nkupsum { get; set; }
        public decimal? Ncouponcorr { get; set; }
        public decimal Ntranshkey { get; set; }
    }
}
