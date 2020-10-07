using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VBankballance
    {
        public DateTime? Ddate { get; set; }
        public string Cacc { get; set; }
        public decimal? Iorder { get; set; }
        public string Ccurr { get; set; }
        public decimal? Nsysrem { get; set; }
        public decimal? Nsettlrem { get; set; }
        public decimal? Ntomrem { get; set; }
        public decimal? Nspotrem { get; set; }
        public decimal? Nclientrem { get; set; }
        public decimal? Ncash { get; set; }
    }
}
