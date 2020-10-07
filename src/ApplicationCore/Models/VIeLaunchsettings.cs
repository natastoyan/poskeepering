using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIeLaunchsettings
    {
        public decimal Ninterfacekey { get; set; }
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
        public string Ccode { get; set; }
        public decimal? Idirection { get; set; }
        public string Cinterfacedescription { get; set; }
        public bool? Bmanual { get; set; }
        public DateTimeOffset? Dnextrundate { get; set; }
    }
}
