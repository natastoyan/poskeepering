using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Secacc
    {
        public Secacc()
        {
            Remainsbysec = new HashSet<Remainsbysec>();
            Remainsbytransh = new HashSet<Remainsbytransh>();
            Secpaym = new HashSet<Secpaym>();
        }

        public decimal Nacckey { get; set; }
        public string Corgcode { get; set; }
        public string Csecacccode { get; set; }
        public string Cseccode { get; set; }
        public string Cacc { get; set; }
        public string Cacceq { get; set; }
        public string Cmicexid { get; set; }
        public decimal? Ncombps { get; set; }
        public decimal? Ncomrepo { get; set; }
        public decimal? Ncomrepoyear { get; set; }

        public virtual Secacctypes CsecacccodeNavigation { get; set; }
        public virtual ICollection<Remainsbysec> Remainsbysec { get; set; }
        public virtual ICollection<Remainsbytransh> Remainsbytransh { get; set; }
        public virtual ICollection<Secpaym> Secpaym { get; set; }
    }
}
