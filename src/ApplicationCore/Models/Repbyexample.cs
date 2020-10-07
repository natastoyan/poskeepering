using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Repbyexample
    {
        public decimal Ntemprepkey { get; set; }
        public decimal? Nrepkey { get; set; }
        public string Crepname { get; set; }
        public string Crepfile { get; set; }
        public decimal? Nparentrepkey { get; set; }
        public string Cparentcode { get; set; }
    }
}
