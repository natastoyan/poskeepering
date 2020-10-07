using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSummitFutures
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
        public string Trader { get; set; }
        public string Contractname { get; set; }
        public string Contractmonth { get; set; }
        public decimal? Futureprice { get; set; }
        public decimal? Futureamount { get; set; }
        public decimal? Clearbrokerrate { get; set; }
        public decimal? Clearbrokervalue { get; set; }
        public string Execbroker { get; set; }
        public decimal? Execbrokerrate { get; set; }
        public decimal? Execbrokervalue { get; set; }
        public string Exportaction { get; set; }
        public decimal? Exttradeid1 { get; set; }
        public DateTime? Tradedate1 { get; set; }
        public string Ctype { get; set; }
        public string Cdealtype { get; set; }
        public string Cdealtable { get; set; }
        public string Ccontrcode { get; set; }
        public string Cclientcode { get; set; }
        public string Csummitreference { get; set; }
        public decimal? Nsummitdealkey { get; set; }
    }
}
