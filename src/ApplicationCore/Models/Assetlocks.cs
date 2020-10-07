using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Assetlocks
    {
        public decimal? Nid { get; set; }
        public string Ctradercode { get; set; }
        public DateTime? Dtimestamp { get; set; }
        public decimal? Nlocked { get; set; }
        public string Ctype { get; set; }
        public string Corgcode { get; set; }
        public string Casset { get; set; }
    }
}
