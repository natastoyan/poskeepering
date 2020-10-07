using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Logrecord
    {
        public Logrecord()
        {
            Recres = new HashSet<Recres>();
            Trans = new HashSet<Trans>();
        }

        public decimal Nlogreckey { get; set; }
        public decimal? Ncreateuser { get; set; }
        public DateTime? Dcreatedate { get; set; }
        public decimal? Nmodifyuser { get; set; }
        public DateTime? Dlastmodifydate { get; set; }
        public string Cdealcomment { get; set; }
        public DateTime? Ddeldate { get; set; }
        public decimal? Ndeluser { get; set; }

        public virtual ICollection<Recres> Recres { get; set; }
        public virtual ICollection<Trans> Trans { get; set; }
    }
}
