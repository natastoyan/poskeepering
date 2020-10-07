using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeLaunch
    {
        public IeLaunch()
        {
            IeImportfile = new HashSet<IeImportfile>();
        }

        public decimal? Nsettingkey { get; set; }
        public decimal Nlaunchkey { get; set; }
        public DateTime? Ddate { get; set; }
        public string Cresult { get; set; }
        public string Cstatus { get; set; }

        public virtual ICollection<IeImportfile> IeImportfile { get; set; }
    }
}
