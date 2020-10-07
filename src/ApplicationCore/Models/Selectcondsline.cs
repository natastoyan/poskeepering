using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Selectcondsline
    {
        public decimal Ncondlinefkey { get; set; }
        public decimal? Nselectcondkey { get; set; }
        public decimal? Navailfkey { get; set; }
        public decimal? Binterval { get; set; }
        public decimal? Blist { get; set; }
        public decimal? Idefvalue { get; set; }
        public string Cdefvalue { get; set; }
        public decimal? Itodayfrom { get; set; }
        public decimal? Itodayto { get; set; }
        public decimal? Bminavailable { get; set; }
        public decimal? Bmaxavailable { get; set; }
        public decimal? Bdefaultflag { get; set; }
        public decimal? Bworkdays { get; set; }

        public virtual Availablefields NavailfkeyNavigation { get; set; }
        public virtual Selectconds NselectcondkeyNavigation { get; set; }
    }
}
