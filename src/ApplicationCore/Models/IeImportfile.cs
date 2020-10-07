using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeImportfile
    {
        public IeImportfile()
        {
            IeImportfilerecords = new HashSet<IeImportfilerecords>();
        }

        public decimal Nfilekey { get; set; }
        public string Cfilename { get; set; }
        public string Cfile { get; set; }
        public string Cresult { get; set; }
        public DateTime? Dcreatedate { get; set; }
        public DateTime? Dprocessdate { get; set; }
        public string Cstatus { get; set; }
        public decimal? Nsettingkey { get; set; }
        public decimal? Nrecordcount { get; set; }
        public decimal? Nlaunchkey { get; set; }

        public virtual IeLaunch NlaunchkeyNavigation { get; set; }
        public virtual IeLaunchsettings NsettingkeyNavigation { get; set; }
        public virtual ICollection<IeImportfilerecords> IeImportfilerecords { get; set; }
    }
}
