using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRptRepobrockTurnover
    {
        public string Cacckey { get; set; }
        public DateTime? Ddate { get; set; }
        public decimal? Nsum { get; set; }
        public string Casset { get; set; }
        public string Cticker { get; set; }
        public string Cclientcode { get; set; }
        public decimal? Crpttype { get; set; }
    }
}
