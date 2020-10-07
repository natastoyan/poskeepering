using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VOpenbondsDelivRub
    {
        public string Cdealnumber { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public DateTime Ddate { get; set; }
        public string Cclassif { get; set; }
        public decimal Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public string Ccouponrate { get; set; }
        public DateTime Dmaturitydate { get; set; }
        public decimal Ndealkey { get; set; }
        public decimal? Isb { get; set; }
        public decimal? Nsumnom { get; set; }
        public string Crefbuy { get; set; }
        public decimal? Nprice { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Ntot { get; set; }
        public decimal? Navgrate { get; set; }
        public decimal? Ytm { get; set; }
        public decimal? Ncuryield { get; set; }
        public decimal? Ncuryieldres { get; set; }
        public decimal? Npl { get; set; }
        public decimal? Nplacr { get; set; }
        public decimal? Nplfull { get; set; }
        public decimal? Nrecalc { get; set; }
        public decimal? Nreserv { get; set; }
        public decimal? Navgrateres { get; set; }
        public decimal? Nrecalcres { get; set; }
        public decimal? Nplres { get; set; }
        public decimal? Nplfullres { get; set; }
        public decimal? Nsumkup { get; set; }
        public decimal? Nacrfull { get; set; }
        public DateTime? Ddeliverydate { get; set; }
    }
}
