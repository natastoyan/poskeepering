using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VFilemonitoring
    {
        public decimal Nservreqkey { get; set; }
        public string Cservreqstatus { get; set; }
        public string Cathenastatus { get; set; }
        public string Cexpfilename { get; set; }
        public DateTime? Dexpdatetime { get; set; }
        public string Cexpdatetime { get; set; }
        public string Cimpfilename { get; set; }
        public DateTime? Dimpdatetime { get; set; }
        public string Cimpdatetime { get; set; }
    }
}
