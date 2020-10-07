using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Customreports
    {
        public decimal Ngroupcondkey { get; set; }
        public decimal Nselectcondkey { get; set; }
        public decimal? Nrepkey { get; set; }
        public decimal Ncollistkey { get; set; }
        public string Ccustomrepname { get; set; }
        public string Ccrystalfile { get; set; }
        public string Cexcelfile { get; set; }
        public string Cexcellist { get; set; }
        public string Cbasecell { get; set; }

        public virtual Columnlists NcollistkeyNavigation { get; set; }
        public virtual Groupconds NgroupcondkeyNavigation { get; set; }
        public virtual Basereports NrepkeyNavigation { get; set; }
        public virtual Selectconds NselectcondkeyNavigation { get; set; }
    }
}
