using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Subperioddays
    {
        public string Criskgroupcode { get; set; }
        public string Cperiodcode { get; set; }
        public decimal? Idaysfrom { get; set; }
        public string Csubperiodcode { get; set; }
        public decimal? Idaysto { get; set; }
        public decimal? Bworkdays { get; set; }
        public decimal? Bworkdaysto { get; set; }

        public virtual Riskgroups CriskgroupcodeNavigation { get; set; }
    }
}
