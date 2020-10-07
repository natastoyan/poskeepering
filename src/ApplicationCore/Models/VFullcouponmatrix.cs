using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VFullcouponmatrix
    {
        public decimal? Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public DateTime? Dmaturitydate { get; set; }
        public string Ccouponrate { get; set; }
        public DateTime? Dcoupondate { get; set; }
        public decimal? Nkupsum { get; set; }
    }
}
