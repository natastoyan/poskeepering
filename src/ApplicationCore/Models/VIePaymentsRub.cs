using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIePaymentsRub
    {
        public string Copcode { get; set; }
        public decimal Ndealkey { get; set; }
        public string Ctablename { get; set; }
        public decimal? Ngridid { get; set; }
        public string Cdealbody { get; set; }
    }
}
