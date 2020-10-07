using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRptGkorskBook
    {
        public string Cbookcode { get; set; }
        public string Cbondcomment { get; set; }
        public string Isin { get; set; }
        public decimal? Nfaceamount { get; set; }
        public DateTime Dt { get; set; }
        public decimal? Npricet { get; set; }
        public DateTime Dt1 { get; set; }
        public decimal? Npricet1 { get; set; }
        public decimal? Nmtmprofit { get; set; }
        public decimal? Naccruedcoupon { get; set; }
    }
}
