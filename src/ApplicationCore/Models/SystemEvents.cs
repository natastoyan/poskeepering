using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class SystemEvents
    {
        public decimal Neventkey { get; set; }
        public DateTime? Ddatetime { get; set; }
        public string Neventtypekey { get; set; }
        public string Cpcname { get; set; }
        public string Cusername { get; set; }
        public string Cdetails2 { get; set; }
        public string Cdetails1 { get; set; }
        public string Cobjectname { get; set; }

        public virtual EventType NeventtypekeyNavigation { get; set; }
    }
}
