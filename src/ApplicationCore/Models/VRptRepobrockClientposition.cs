using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRptRepobrockClientposition
    {
        public string Csecdesc { get; set; }
        public string Cissuer { get; set; }
        public string Cisin { get; set; }
        public DateTime? Ddate { get; set; }
        public decimal? Nsecuritytypekey { get; set; }
        public string Cclientcode { get; set; }
        public decimal? NsumnomProp { get; set; }
        public decimal? NsumnomDirect { get; set; }
        public decimal? NsumnomReverce { get; set; }
        public decimal? NsumnomNett { get; set; }
    }
}
