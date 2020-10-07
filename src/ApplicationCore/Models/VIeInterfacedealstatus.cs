using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIeInterfacedealstatus
    {
        public decimal Ninterfacekey { get; set; }
        public decimal Ninterfacedealstatuskey { get; set; }
        public decimal? Ndealkey { get; set; }
        public string Ctablename { get; set; }
        public DateTime? Ddate { get; set; }
        public string Cstatus { get; set; }
        public string Cfilename { get; set; }
        public string Cmessage { get; set; }
    }
}
