using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VClosebonds
    {
        public decimal Ntranshkey { get; set; }
        public DateTime Ddate { get; set; }
        public string Cseccode { get; set; }
        public string Ccouponrate { get; set; }
        public DateTime Dmaturitydate { get; set; }
        public decimal? Navgrate { get; set; }
        public string Cclassif { get; set; }
        public decimal Nbuydealkey { get; set; }
        public decimal Nselldealkey { get; set; }
        public decimal? Nsumnom { get; set; }
        public string Crefbuy { get; set; }
        public string Cdealnumberbuy { get; set; }
        public DateTime? Ddeliverydatebuy { get; set; }
        public decimal? Npricebuy { get; set; }
        public string Crefsell { get; set; }
        public string Cdealnumbersell { get; set; }
        public DateTime? Ddeliverydatesell { get; set; }
        public DateTime? Dcontrdatesell { get; set; }
        public decimal? Npricesell { get; set; }
        public decimal? Nsumbuy { get; set; }
        public decimal? Nsumsell { get; set; }
        public decimal? Nsumfullbuy { get; set; }
        public decimal? Nsumfullsell { get; set; }
        public decimal? Npl { get; set; }
        public decimal? Ncuryield { get; set; }
    }
}
