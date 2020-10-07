using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Norm6coeff
    {
        public DateTime Dvalidfrom { get; set; }
        public DateTime Dvalidto { get; set; }
        public decimal Ndealtype { get; set; }
        public decimal Bresident { get; set; }
        public decimal Nperiodfrom { get; set; }
        public decimal? Ncoeff { get; set; }
    }
}
