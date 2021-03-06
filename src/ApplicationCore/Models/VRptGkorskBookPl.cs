using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRptGkorskBookPl
    {
        public string Cbookcode { get; set; }
        public string Cbondcomment { get; set; }
        public string Isin { get; set; }
        public decimal Ntranshkey { get; set; }
        public decimal? Nfaceamount { get; set; }
        public decimal? NfaceamountT1 { get; set; }
        public DateTime Dt { get; set; }
        public DateTime Dstartdate { get; set; }
        public decimal? Ncouponrate { get; set; }
        public decimal? Npricet { get; set; }
        public DateTime Dt1 { get; set; }
        public decimal? Npricet1 { get; set; }
        public decimal? Nsellamount { get; set; }
        public decimal? Nbuyamount { get; set; }
        public decimal? Navgpricesell { get; set; }
        public decimal? Navgpricebuy { get; set; }
        public decimal? Nmtmprofit { get; set; }
        public decimal? NmtmprofitT1 { get; set; }
        public decimal? Nincomingbalancerev { get; set; }
        public decimal? Naccruedcoupon { get; set; }
        public decimal? Naccruedcoupont1 { get; set; }
    }
}
