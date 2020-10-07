using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Counterlimits
    {
        public DateTime? Dlimitdate { get; set; }
        public decimal Nlimitkey { get; set; }
        public string Criskgroupcode { get; set; }
        public string Ccurrcode { get; set; }
        public string Corgcode { get; set; }
        public string Ccrossgroupcode { get; set; }
        public decimal? Ncommonlimit { get; set; }
        public string Cperiodcode { get; set; }
        public string Ccomment { get; set; }
        public string Csubperiodcode { get; set; }
        public DateTime? Dlimitdateto { get; set; }

        public virtual Subperiods C { get; set; }
        public virtual Crosscountergroups CcrossgroupcodeNavigation { get; set; }
        public virtual Currency CcurrcodeNavigation { get; set; }
        public virtual Riskperiodscodes CperiodcodeNavigation { get; set; }
        public virtual Riskgroups CriskgroupcodeNavigation { get; set; }
    }
}
