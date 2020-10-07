using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VCouponmatrix
    {
        public decimal Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public DateTime Dmaturitydate { get; set; }
        public string Ccouponrate { get; set; }
        public DateTime Dstartdate { get; set; }
        public DateTime Dcoupondate { get; set; }
        public decimal? Nkupsum { get; set; }
        public decimal? Ncouponcorr { get; set; }
        public DateTime? Dperiodstart { get; set; }
        public decimal? Nkupvalue { get; set; }
        public decimal? Ncouponrate { get; set; }
        public string Ccurrcode { get; set; }
    }
}
