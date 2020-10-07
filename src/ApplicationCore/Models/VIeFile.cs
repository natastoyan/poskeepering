using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIeFile
    {
        public decimal? Iie { get; set; }
        public decimal? Nfilekey { get; set; }
        public decimal? Nlaunchkey { get; set; }
        public string Cfilename { get; set; }
        public string Cfolder { get; set; }
        public string Cfile { get; set; }
        public DateTime? Dcreatedate { get; set; }
        public DateTime? Dprocessdate { get; set; }
        public decimal? Nrecordcount { get; set; }
        public string Cstatus { get; set; }
        public string Cresult { get; set; }
    }
}
