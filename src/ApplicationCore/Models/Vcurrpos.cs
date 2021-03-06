using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Vcurrpos
    {
        public int Id { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nacckey { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public short? Isb { get; set; }
        public decimal? Ndealkey { get; set; }
        public string Copcode { get; set; }
        public string Ccontrcode { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Ddealdatetime { get; set; }
        public string Cusername { get; set; }
        public decimal? Nmurexoid { get; set; }
        public string Cdealercode { get; set; }
        public string Cticket { get; set; }
        public decimal? Iorder { get; set; }
    }
}
