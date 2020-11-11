using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.CustomModels
{
    public class CurrencyPosition
    {
        public string Account { get; set; }
        public string AccountTypeCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? AccountKey { get; set; }
        public decimal? Sum { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? In { get; set; }
        public bool? Active { get; set; }
    }
}

