using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPkSecacc
    {
        public decimal Nacckey { get; set; }
        public string Corgcode { get; set; }
        public string Csecacccode { get; set; }
        public string Cseccode { get; set; }
        public string Cacc { get; set; }
        public string Cacceq { get; set; }
        public string Cmicexid { get; set; }
        public decimal? Ncombps { get; set; }
        public decimal? Ncomrepo { get; set; }
    }
}
