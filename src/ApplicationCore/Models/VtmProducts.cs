using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VtmProducts
    {
        public VtmProducts()
        {
            VtmSpreads = new HashSet<VtmSpreads>();
        }

        public decimal Nproductkey { get; set; }
        public string Cproductcode { get; set; }
        public string Copcode { get; set; }
        public decimal? Norder { get; set; }

        public virtual ICollection<VtmSpreads> VtmSpreads { get; set; }
    }
}
