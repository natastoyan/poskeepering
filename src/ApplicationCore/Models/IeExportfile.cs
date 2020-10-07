using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeExportfile
    {
        public decimal Nfilekey { get; set; }
        public string Cfilename { get; set; }
        public string Cfile { get; set; }
        public DateTime? Dcreatedate { get; set; }
        public DateTime? Dprocessdate { get; set; }
        public string Cmessage { get; set; }
        public decimal? Nlaunchkey { get; set; }
        public decimal? Nrecordcount { get; set; }
        public string Cstatus { get; set; }
        public string Cfolder { get; set; }
        public decimal? Nsettingkey { get; set; }
        public DateTime? Dreadydate { get; set; }
    }
}
