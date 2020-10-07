using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Riskcrosslimit
    {
        public string Ccrossgroupcode { get; set; }
        public string Criskgroupcode { get; set; }

        public virtual Crosscountergroups CcrossgroupcodeNavigation { get; set; }
        public virtual Riskgroups CriskgroupcodeNavigation { get; set; }
    }
}
