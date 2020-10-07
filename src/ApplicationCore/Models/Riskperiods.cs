using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Riskperiods
    {
        public string Cperiodcode { get; set; }
        public string Csubperiodcode { get; set; }
        public decimal? Idaysfrom { get; set; }
        public string Criskgroupcode { get; set; }
        public decimal? Idaysto { get; set; }
        public decimal? Iworkdays { get; set; }
        public decimal? Nriskweight { get; set; }
        public decimal? Iorder { get; set; }

        public virtual Riskperiodscodes CperiodcodeNavigation { get; set; }
        public virtual Riskgroups CriskgroupcodeNavigation { get; set; }
    }
}
