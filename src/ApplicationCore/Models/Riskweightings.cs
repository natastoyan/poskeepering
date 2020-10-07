using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Riskweightings
    {
        public string Cperiodcode { get; set; }
        public string Csubperiodcode { get; set; }
        public string Criskgroupcode { get; set; }
        public string Csubriskgroupcode { get; set; }
        public decimal? Nriskweight { get; set; }
    }
}
