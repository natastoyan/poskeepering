using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Eqdiasoftexchange
    {
        public DateTime? Ddate { get; set; }
        public decimal? Ndealkey { get; set; }
        public string Cstatus { get; set; }
        public string Cfilename { get; set; }

        public virtual Equitingdeals NdealkeyNavigation { get; set; }
    }
}
