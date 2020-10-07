using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VDaylyportb
    {
        public string Ccurrcode { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public decimal? Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public DateTime? Dmaturitydate { get; set; }
        public string Ccouponrate { get; set; }
        public decimal? Nsumnombuy { get; set; }
        public decimal? Nsumbuy { get; set; }
        public decimal? Nsumkupbuy { get; set; }
        public decimal? Nfullsumbuy { get; set; }
        public decimal? Nsumnomsell { get; set; }
        public decimal? Nsumsell { get; set; }
        public decimal? Nsumkupsell { get; set; }
        public decimal? Nfullsumsell { get; set; }
    }
}
