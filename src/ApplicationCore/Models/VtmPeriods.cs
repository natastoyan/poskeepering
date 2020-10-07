using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VtmPeriods
    {
        public VtmPeriods()
        {
            VtmSpreads = new HashSet<VtmSpreads>();
        }

        public decimal Nperiodkey { get; set; }
        public string Cperiodcode { get; set; }
        public string Copcode { get; set; }
        public decimal? Nstart { get; set; }
        public decimal? Nend { get; set; }
        public decimal? Norder { get; set; }

        public virtual ICollection<VtmSpreads> VtmSpreads { get; set; }
    }
}
