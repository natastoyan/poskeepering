using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Currweights
    {
        public string Ccurrcode2 { get; set; }
        public string Ccurrcode1 { get; set; }
        public decimal? Bweight { get; set; }
        public decimal? Iregulusweight { get; set; }
        public decimal? Ndelta { get; set; }

        public virtual Currency Ccurrcode1Navigation { get; set; }
        public virtual Currency Ccurrcode2Navigation { get; set; }
    }
}
