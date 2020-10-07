using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VEqIsDealsTab
    {
        public DateTime? Dtradedate { get; set; }
        public string Cclient { get; set; }
        public decimal? Nowndealscount { get; set; }
        public decimal? Nbrokdealscount { get; set; }
        public decimal? Nownorderscount { get; set; }
        public decimal? Nbrokorderscount { get; set; }
        public bool? Bismaxdeals { get; set; }
        public bool? Bisactual { get; set; }
        public DateTime? Drefreshdate { get; set; }
        public string Cclientcode { get; set; }
        public string Caccount { get; set; }
        public bool? Bismaxorders { get; set; }
    }
}
