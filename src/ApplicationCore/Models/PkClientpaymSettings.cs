using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkClientpaymSettings
    {
        public decimal Nclientpaymsettkey { get; set; }
        public string Crulename { get; set; }
        public string Cclientname { get; set; }
        public decimal? Nclientid { get; set; }
        public string Cclienttaxid { get; set; }
        public string Caccountcode { get; set; }
        public decimal? Naction { get; set; }
        public string Ccomment { get; set; }
        public decimal? Ndoctype { get; set; }
        public string Cdoctypelable { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
    }
}
