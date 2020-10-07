using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class TmpBondsstat
    {
        public string Cclassif { get; set; }
        public string Cseccode { get; set; }
        public string Ccouponrate { get; set; }
        public DateTime? Dmaturitydate { get; set; }
        public DateTime? Ddatefrom { get; set; }
        public DateTime? Ddateto { get; set; }
        public decimal? Navgposition { get; set; }
        public decimal? Nturnover { get; set; }
        public decimal? Nratio { get; set; }
        public decimal? Ndayscount { get; set; }
        public decimal? Ntranshkey { get; set; }
    }
}
