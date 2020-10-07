using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VEqIsDeals
    {
        public DateTime? Dtradedate { get; set; }
        public string Cclient { get; set; }
        public decimal? Nowndealscount { get; set; }
        public decimal? Nbrokdealscount { get; set; }
        public decimal? Nownorderscount { get; set; }
        public decimal? Nbrokorderscount { get; set; }
        public bool? Bismaxdeals { get; set; }
        public bool? Bismaxorders { get; set; }
    }
}
