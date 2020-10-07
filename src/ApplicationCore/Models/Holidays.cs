using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Holidays
    {
        public string Ccurrcode { get; set; }
        public string Cholname { get; set; }
        public DateTime Dholdate { get; set; }
        public decimal? Bholiday { get; set; }
    }
}
