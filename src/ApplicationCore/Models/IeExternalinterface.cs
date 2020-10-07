using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeExternalinterface
    {
        public IeExternalinterface()
        {
            IeInterfacedealstatus = new HashSet<IeInterfacedealstatus>();
            IeInterfacedealstatuslog = new HashSet<IeInterfacedealstatuslog>();
            IeLaunchsettings = new HashSet<IeLaunchsettings>();
        }

        public decimal Ninterfacekey { get; set; }
        public decimal? Idirection { get; set; }
        public string Ccode { get; set; }
        public string Cdescription { get; set; }
        public bool? Bmanual { get; set; }
        public bool? Ballowpayments { get; set; }

        public virtual ICollection<IeInterfacedealstatus> IeInterfacedealstatus { get; set; }
        public virtual ICollection<IeInterfacedealstatuslog> IeInterfacedealstatuslog { get; set; }
        public virtual ICollection<IeLaunchsettings> IeLaunchsettings { get; set; }
    }
}
