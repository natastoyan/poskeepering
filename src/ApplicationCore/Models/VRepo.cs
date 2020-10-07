using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VRepo
    {
        public decimal? Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public decimal? Isb { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public string Ccontrcode { get; set; }
        public string Cseccode { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nreposum { get; set; }
        public string Creporate { get; set; }
        public decimal? Nreposum2 { get; set; }
        public DateTime? Dstartdate { get; set; }
        public DateTime? Dclosedate { get; set; }
        public decimal? Nheircut { get; set; }
        public decimal? Nstep { get; set; }
    }
}
