using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSummitFi
    {
        public string Headerword { get; set; }
        public string Feed { get; set; }
        public string Action { get; set; }
        public string Exttradeid { get; set; }
        public string Company { get; set; }
        public string Desk { get; set; }
        public string Book { get; set; }
        public string Cust { get; set; }
        public string Tradedate { get; set; }
        public string Pors { get; set; }
        public decimal? Notional { get; set; }
        public string Securityid { get; set; }
        public decimal? Bondprice { get; set; }
        public string Settledate { get; set; }
        public string Bondvaluedate { get; set; }
        public string Exportaction { get; set; }
        public decimal? Exttradeid1 { get; set; }
        public DateTime? Tradedate1 { get; set; }
        public string Cdealtype { get; set; }
        public string Ctype { get; set; }
        public string Cdealtable { get; set; }
        public string Ccontrcode { get; set; }
        public string Cclientcode { get; set; }
        public string Csummitreference { get; set; }
        public decimal? Nsummitdealkey { get; set; }
    }
}
