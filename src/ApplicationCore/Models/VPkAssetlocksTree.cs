using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPkAssetlocksTree
    {
        public string Ctreekey { get; set; }
        public string Ckey { get; set; }
        public string Caccount { get; set; }
        public string Ctrdacc { get; set; }
        public string Cclientcode { get; set; }
        public string Casset { get; set; }
        public string Cisin { get; set; }
        public decimal? Ncurrentbalance { get; set; }
        public decimal? Nlockedonexchange { get; set; }
        public decimal? Navailableonexchange { get; set; }
        public decimal? Nlocked { get; set; }
        public decimal? Nlocked2leg { get; set; }
        public decimal? Navalable { get; set; }
        public decimal? Openbal { get; set; }
    }
}
