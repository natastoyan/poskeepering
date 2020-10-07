using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPkCurrency
    {
        public string Ccurrcode { get; set; }
        public string Ccurrname { get; set; }
        public decimal? Iorder { get; set; }
        public decimal? Iocporder { get; set; }
        public decimal? Neurrate { get; set; }
        public decimal? Beurgroup { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Nisocode { get; set; }
    }
}
