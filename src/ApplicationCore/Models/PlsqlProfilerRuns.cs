using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PlsqlProfilerRuns
    {
        public PlsqlProfilerRuns()
        {
            PlsqlProfilerUnits = new HashSet<PlsqlProfilerUnits>();
        }

        public decimal Runid { get; set; }
        public decimal? RelatedRun { get; set; }
        public string RunOwner { get; set; }
        public DateTime? RunDate { get; set; }
        public string RunComment { get; set; }
        public decimal? RunTotalTime { get; set; }
        public string RunSystemInfo { get; set; }
        public string RunComment1 { get; set; }
        public string Spare1 { get; set; }

        public virtual ICollection<PlsqlProfilerUnits> PlsqlProfilerUnits { get; set; }
    }
}
