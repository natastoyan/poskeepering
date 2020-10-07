using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeQuikorgsexport
    {
        public decimal Nexportkey { get; set; }
        public DateTime Dcreatedate { get; set; }
        public DateTime? Dprocessdate { get; set; }
        public string Cresult { get; set; }
        public string Cstatus { get; set; }
    }
}
