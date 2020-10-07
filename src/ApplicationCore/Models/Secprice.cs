using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Secprice
    {
        public DateTime Ddate { get; set; }
        public decimal? Nprice { get; set; }
        public string Csourcecode { get; set; }
        public decimal? Npricebid { get; set; }
        public decimal? Npriceoffer { get; set; }
        public string Cpricetype { get; set; }
        public decimal? Nvol { get; set; }
        public decimal? Npricebuymax { get; set; }
        public decimal? Npriceoffermin { get; set; }
        public decimal? Npricedealmin { get; set; }
        public decimal? Npricedealmax { get; set; }
        public decimal? Npriceclose { get; set; }
        public decimal? Npriceopen { get; set; }
        public decimal? Nchangeprice { get; set; }
        public decimal? Ncountvol { get; set; }
        public decimal? Nytmour { get; set; }
        public decimal? Npvbp { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nytmirr { get; set; }
        public decimal? Nytmclose { get; set; }
        public decimal Ntranshkey { get; set; }

        public virtual Pricesource CsourcecodeNavigation { get; set; }
    }
}
