using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Tmpirrdata
    {
        public DateTime Ddate { get; set; }
        public decimal? Nbuyavgprice { get; set; }
        public decimal? Nirr { get; set; }
        public decimal? Ndur { get; set; }
        public decimal? Nfulldur { get; set; }
        public decimal? Nfullirr { get; set; }
        public decimal? Nfullytm { get; set; }
        public decimal Ntranshkey { get; set; }
    }
}
