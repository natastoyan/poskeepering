using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VDepoutil
    {
        public DateTime Ddate { get; set; }
        public string Ccontrcode { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nfull { get; set; }
        public decimal? Nutil { get; set; }
        public decimal? Navail { get; set; }
        public decimal? Nex { get; set; }
        public decimal? Nrate { get; set; }
    }
}
