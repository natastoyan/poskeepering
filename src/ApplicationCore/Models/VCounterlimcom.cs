using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VCounterlimcom
    {
        public string Corgcode { get; set; }
        public string Ccrossgroupcode { get; set; }
        public string Cperiodcode { get; set; }
        public string Csubperiodcode { get; set; }
        public decimal? Ncommonlimit { get; set; }
        public DateTime Ddate { get; set; }
        public decimal? Nutillim { get; set; }
        public decimal? Navaillim { get; set; }
        public decimal? Iorder { get; set; }
    }
}
