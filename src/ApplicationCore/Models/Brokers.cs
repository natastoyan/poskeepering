using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Brokers : BaseIntIdModel
    {
       // public decimal Nbrokerkey { get; set; }
        public string Ccode { get; set; }
        public string Cname { get; set; }
        public string Creutercode { get; set; }
    }
}
