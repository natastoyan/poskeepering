using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PlsqlProfilerUnits
    {
        public PlsqlProfilerUnits()
        {
            PlsqlProfilerData = new HashSet<PlsqlProfilerData>();
        }

        public decimal Runid { get; set; }
        public decimal UnitNumber { get; set; }
        public string UnitType { get; set; }
        public string UnitOwner { get; set; }
        public string UnitName { get; set; }
        public DateTime? UnitTimestamp { get; set; }
        public decimal? TotalTime { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }

        public virtual PlsqlProfilerRuns Run { get; set; }
        public virtual ICollection<PlsqlProfilerData> PlsqlProfilerData { get; set; }
    }
}
