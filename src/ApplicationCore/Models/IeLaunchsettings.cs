using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeLaunchsettings
    {
        public IeLaunchsettings()
        {
            IeImportfile = new HashSet<IeImportfile>();
        }

        public decimal? Ninterfacekey { get; set; }
        public decimal Nsettingkey { get; set; }
        public string Cjobinterval { get; set; }
        public string Cjobname { get; set; }
        public bool? Benabled { get; set; }
        public string Cdescription { get; set; }
        public string Cfilenametemplate { get; set; }
        public string Carchivefolder { get; set; }
        public string Cfolder { get; set; }
        public string Cjobbody1 { get; set; }
        public string Cjobbody2 { get; set; }
        public string Cflagfile { get; set; }
        public string Cjobparams { get; set; }
        public DateTime? Dstartdate { get; set; }
        public bool? Bmultiplefolders { get; set; }
        public decimal? Nmaxrecordcount { get; set; }

        public virtual IeExternalinterface NinterfacekeyNavigation { get; set; }
        public virtual ICollection<IeImportfile> IeImportfile { get; set; }
    }
}
