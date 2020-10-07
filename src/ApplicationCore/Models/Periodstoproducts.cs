using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Periodstoproducts
    {
        public string Criskgroupcode { get; set; }
        public string Cperiodcode { get; set; }
        public decimal? Iorder { get; set; }

        public virtual Riskperiodscodes CperiodcodeNavigation { get; set; }
        public virtual Riskgroups CriskgroupcodeNavigation { get; set; }
    }
}
