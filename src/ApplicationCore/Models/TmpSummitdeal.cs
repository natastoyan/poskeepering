using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class TmpSummitdeal
    {
        public decimal? Nsummitdealkey { get; set; }
        public DateTime? Dtimestamp { get; set; }
        public string Cdealtype { get; set; }
        public decimal? Ndealkey { get; set; }
        public DateTime? Ddealdate { get; set; }
        public string Creference { get; set; }
        public string Cdealstatus { get; set; }
        public string Cexportstatus { get; set; }
        public decimal? Npreviouskey { get; set; }
        public string Cfilename { get; set; }
        public string Ctype { get; set; }
    }
}
