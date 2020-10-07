using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSecrates
    {
        public DateTime Ddate { get; set; }
        public decimal? Nsecnom { get; set; }
        public string Cclassif { get; set; }
        public decimal Ntranshkey { get; set; }
        public string Cseccode { get; set; }
        public DateTime Dmaturitydate { get; set; }
        public string Ccouponrate { get; set; }
        public decimal? Nbid { get; set; }
        public decimal? Noffer { get; set; }
        public decimal? Nmidbuy { get; set; }
        public decimal? Navgrate { get; set; }
        public decimal? Nmiddays { get; set; }
        public decimal? Nreserv { get; set; }
        public decimal? Nacrint { get; set; }
        public decimal? Nacrfull { get; set; }
    }
}
