using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class CurraccOld
    {
        public CurraccOld()
        {
            Currpaym = new HashSet<Currpaym>();
            Remains = new HashSet<Remains>();
        }

        public decimal Nacckey { get; set; }
        public string Ccurrcode { get; set; }
        public string Corgcode { get; set; }
        public string Cacctypecode { get; set; }
        public string Cacc { get; set; }
        public string Crequivisits { get; set; }
        public decimal? Iorder { get; set; }
        public string Cdefopers { get; set; }
        public decimal? Isb { get; set; }
        public string Ccorrcode { get; set; }
        public string Caccbal { get; set; }
        public string Cpaymforinter { get; set; }
        public decimal? Bincludedealpos { get; set; }
        public string Cdiasoftcode { get; set; }
        public string Ctradingvenue { get; set; }
        public string Caccnum { get; set; }
        public string Csettplace { get; set; }
        public string Cathenenum { get; set; }

        public virtual Curracctypes CacctypecodeNavigation { get; set; }
        public virtual Currency CcurrcodeNavigation { get; set; }
        public virtual ICollection<Currpaym> Currpaym { get; set; }
        public virtual ICollection<Remains> Remains { get; set; }
    }
}
