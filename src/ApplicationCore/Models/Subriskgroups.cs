using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Subriskgroups
    {
        public string Criskgroupcode { get; set; }
        public string Csubriskgroupcode { get; set; }
        public decimal? Iorder { get; set; }

        public virtual Riskgroups CriskgroupcodeNavigation { get; set; }
    }
}
