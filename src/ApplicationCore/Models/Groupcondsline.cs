using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Groupcondsline
    {
        public decimal Ncondlinegrkey { get; set; }
        public decimal? Ngroupcondkey { get; set; }
        public decimal? Navalgrkey { get; set; }
        public decimal? Bheader { get; set; }
        public decimal? Bfooter { get; set; }

        public virtual Availablegroups NavalgrkeyNavigation { get; set; }
        public virtual Groupconds NgroupcondkeyNavigation { get; set; }
    }
}
