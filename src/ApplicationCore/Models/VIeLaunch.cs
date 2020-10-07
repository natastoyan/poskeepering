using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIeLaunch
    {
        public string Ccode { get; set; }
        public string Cjobname { get; set; }
        public decimal? Nsettingkey { get; set; }
        public decimal? Nlaunchkey { get; set; }
        public DateTime? Ddate { get; set; }
        public string Cresult { get; set; }
        public string Cstatus { get; set; }
        public decimal? Nfilekey { get; set; }
        public string Cfilename { get; set; }
        public string Cfolder { get; set; }
        public string Cfile { get; set; }
        public string Cfileresult { get; set; }
        public string Cfilestatus { get; set; }
        public DateTime? Dcreatedate { get; set; }
        public DateTime? Dprocessdate { get; set; }
        public decimal? Nrecordcount { get; set; }
    }
}
