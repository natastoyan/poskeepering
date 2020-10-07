using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSystemmenu
    {
        public string Owner { get; set; }
        public decimal Nmenukey { get; set; }
        public decimal? Nrepkey { get; set; }
        public decimal? Nsystemkey { get; set; }
        public string Cmenuname { get; set; }
        public string Cfunctioncode { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nparentmenukey { get; set; }
        public decimal? Nlevel { get; set; }
    }
}
