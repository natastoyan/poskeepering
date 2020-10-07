using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class FvsTestAutoinsert
    {
        public decimal? ColNumber { get; set; }
        public decimal? ColNumber23 { get; set; }
        public string ColVarchar220 { get; set; }
        public string ColChar50 { get; set; }
        public DateTime? D { get; set; }
        public decimal Key { get; set; }
        public string Fk { get; set; }
        public decimal? Number32 { get; set; }
        public string Fk1 { get; set; }

        public virtual Currency Fk1Navigation { get; set; }
        public virtual Currency FkNavigation { get; set; }
    }
}
