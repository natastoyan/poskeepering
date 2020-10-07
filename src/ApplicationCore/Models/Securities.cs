using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Securities
    {
        public Securities()
        {
            Transhes = new HashSet<Transhes>();
        }

        public string Cseccode { get; set; }
        public string Ccurrcode { get; set; }
        public string Csposcode { get; set; }
        public string Csecname { get; set; }
        public decimal? Icouponyear { get; set; }
        public decimal Ikupbase { get; set; }
        public decimal? Idaystodelivery { get; set; }
        public string Cissuer { get; set; }
        public decimal Bsubfederal { get; set; }
        public string Cissuername { get; set; }

        public virtual Currency CcurrcodeNavigation { get; set; }
        public virtual Couponcalcmethod CsposcodeNavigation { get; set; }
        public virtual ICollection<Transhes> Transhes { get; set; }
    }
}
