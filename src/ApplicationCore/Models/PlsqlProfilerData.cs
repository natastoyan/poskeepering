using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PlsqlProfilerData
    {
        public decimal Runid { get; set; }
        public decimal UnitNumber { get; set; }
        public decimal Line { get; set; }
        public decimal? TotalOccur { get; set; }
        public decimal? TotalTime { get; set; }
        public decimal? MinTime { get; set; }
        public decimal? MaxTime { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public decimal? Spare4 { get; set; }

        public virtual PlsqlProfilerUnits PlsqlProfilerUnits { get; set; }
    }
}
