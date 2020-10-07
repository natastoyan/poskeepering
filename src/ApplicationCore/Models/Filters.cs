using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Filters
    {
        public decimal Iuserid { get; set; }
        public decimal Nselectcondkey { get; set; }
        public string Cfieldname { get; set; }
        public string Cminfieldvalue { get; set; }
        public string Cmaxfieldvalue { get; set; }
        public decimal? Noperator { get; set; }
        public decimal? Binterval { get; set; }
        public decimal? Bactive { get; set; }
        public decimal? Btoday { get; set; }
        public decimal? Btoday2 { get; set; }
        public decimal? Bworkdays { get; set; }
        public decimal? Bworkdays2 { get; set; }
        public decimal? Ndays { get; set; }
        public decimal? Ndays2 { get; set; }
        public decimal? Ibindtype { get; set; }

        public virtual Selectconds NselectcondkeyNavigation { get; set; }
    }
}
