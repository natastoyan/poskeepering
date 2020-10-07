using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Ticketprint
    {
        public decimal Ntprintkey { get; set; }
        public decimal Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public string Ctablename { get; set; }
        public string Cstatus { get; set; }
        public DateTime Dadddate { get; set; }
        public DateTime? Dprintdate { get; set; }
        public string Clog { get; set; }
        public decimal? Ndealversion { get; set; }
        public string Cbookcode { get; set; }
        public string Ccontrcode { get; set; }
        public decimal? Nprinttype { get; set; }
    }
}
