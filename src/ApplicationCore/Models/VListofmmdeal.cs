using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VListofmmdeal
    {
        public decimal? Nrecnumber { get; set; }
        public DateTime? Dtradedate { get; set; }
        public DateTime? Daudittimestamp { get; set; }
        public string Ctrader { get; set; }
        public string Cticket { get; set; }
        public decimal? Ndealkey { get; set; }
        public string Ctype { get; set; }
        public string Ccontrcode { get; set; }
        public DateTime? Dstartdate { get; set; }
        public DateTime? Dmaturitydate { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nprincipal { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Ninterest { get; set; }
        public DateTime? Dreportdate { get; set; }
        public string Binternal { get; set; }
        public string Ndealstatus { get; set; }
    }
}
