using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPkSecurities
    {
        public string Cseccode { get; set; }
        public string Ccurrcode { get; set; }
        public string Csposcode { get; set; }
        public string Csecname { get; set; }
        public decimal? Icouponyear { get; set; }
        public decimal Ikupbase { get; set; }
        public decimal? Idaystodelivery { get; set; }
        public string Cissuer { get; set; }
        public decimal Bsubfederal { get; set; }
    }
}
