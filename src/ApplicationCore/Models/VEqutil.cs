using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VEqutil
    {
        public DateTime Ddate { get; set; }
        public string Corgcode { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nfull { get; set; }
        public decimal? Nutil { get; set; }
        public decimal? Navail { get; set; }
        public decimal? Nex { get; set; }
    }
}
