using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeEvents
    {
        public decimal Neventkey { get; set; }
        public string Ceventname { get; set; }
        public decimal? Benabled { get; set; }
        public string Crecipient { get; set; }
        public string Ccopy { get; set; }
        public string Csubject { get; set; }
        public decimal? Ninterfacekey { get; set; }
        public string Cparams { get; set; }
        public bool? Bhtml { get; set; }
        public string Cbody { get; set; }
        public byte[] Cbodyrv { get; set; }
        public bool? Bedithtml { get; set; }
    }
}
