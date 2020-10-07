using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VNorm6coeff
    {
        public DateTime Ddate { get; set; }
        public DateTime Dvalidfrom { get; set; }
        public DateTime Dvalidto { get; set; }
        public decimal Ndealtype { get; set; }
        public decimal Bresident { get; set; }
        public decimal Nperiodfrom { get; set; }
        public decimal? Nperiodto { get; set; }
        public decimal? Ncoeff { get; set; }
        public string RowId { get; set; }
    }
}
