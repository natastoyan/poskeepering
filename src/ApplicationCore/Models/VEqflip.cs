using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VEqflip
    {
        public DateTime? Ddate { get; set; }
        public string Cbookcode { get; set; }
        public decimal? Nequitykey { get; set; }
        public string Cmarketcode { get; set; }
        public decimal? Nquantity { get; set; }
        public decimal Ndealkeyfrom { get; set; }
        public string Cfromref { get; set; }
        public string Ccurrfrom { get; set; }
        public decimal Ndealkeyto { get; set; }
        public string Ccurrto { get; set; }
        public string Ctoref { get; set; }
        public decimal? Nusdprice { get; set; }
        public decimal? Nrubprice { get; set; }
    }
}
