using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Futures
    {
        public decimal Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public string Cticket { get; set; }
        public DateTime? Dtradedate { get; set; }
        public decimal? Isb { get; set; }
        public decimal? Nprice { get; set; }
        public decimal? Nvalue { get; set; }
        public decimal? Nquantity { get; set; }
        public string Ccontractname { get; set; }
        public string Cmonth { get; set; }
        public string Cbookcode { get; set; }
        public string Ccurrcode { get; set; }
        public int? Ntradenum { get; set; }
        public string Csummitstatus { get; set; }
        public decimal? Ilogverify { get; set; }
        public DateTime? Dregdate { get; set; }
        public DateTime? Dtimestamp { get; set; }
        public decimal? Imatchathena { get; set; }
        public bool? Bnosummit { get; set; }
        public DateTime? Dmaturitycont { get; set; }
        public string Cdealercode { get; set; }
    }
}
