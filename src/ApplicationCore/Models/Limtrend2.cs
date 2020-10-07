using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Limtrend2
    {
        public string Ccontrcode { get; set; }
        public decimal? Nsettl { get; set; }
        public decimal? Npre { get; set; }
        public decimal? Nlend { get; set; }
        public decimal? NsettlL { get; set; }
        public decimal? NpreL { get; set; }
        public decimal? NlendL { get; set; }
        public DateTime Ddate { get; set; }
        public string Cperiodcode { get; set; }
    }
}
