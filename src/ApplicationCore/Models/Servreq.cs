using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Servreq
    {
        public decimal Nservreqkey { get; set; }
        public string Cservreqstatus { get; set; }
        public DateTime? Dchangestatus { get; set; }
        public decimal? Nuserkey { get; set; }
        public string Csubject { get; set; }
        public string Ccomment { get; set; }
        public DateTime? Dexportdate { get; set; }
        public DateTime? Drespdate { get; set; }
        public decimal? Nexpfilekey { get; set; }
        public decimal? Nimpfilekey { get; set; }
        public DateTime? Dmailnoanswersend { get; set; }
    }
}
