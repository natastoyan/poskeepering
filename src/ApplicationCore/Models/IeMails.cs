using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeMails
    {
        public decimal Nmailkey { get; set; }
        public string Crecipient { get; set; }
        public string Csubject { get; set; }
        public string Cbody { get; set; }
        public string Cstatus { get; set; }
        public DateTime? Dprocessdate { get; set; }
        public DateTime? Dcreatedate { get; set; }
        public string Creason { get; set; }
        public decimal? Neventkey { get; set; }
        public bool? Bhtml { get; set; }
        public string Crecipientcopy { get; set; }
        public string Cgenresult { get; set; }
    }
}
