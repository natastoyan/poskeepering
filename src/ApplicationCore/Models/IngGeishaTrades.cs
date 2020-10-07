using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IngGeishaTrades
    {
        public string ExternalTradeSource { get; set; }
        public string ExternalTradeId { get; set; }
        public byte VersionNum { get; set; }
        public string OriginalTradePlace { get; set; }
        public string OriginalTradeId { get; set; }
        public string Action { get; set; }
        public string TradeDirection { get; set; }
        public string SecIsin { get; set; }
        public string SecTicker { get; set; }
        public string InstrumentType { get; set; }
        public decimal? SecQuantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public string BookId { get; set; }
        public int? Counterparty { get; set; }
        public string TradeDate { get; set; }
        public string TradeTime { get; set; }
        public string SettType { get; set; }
        public string EqSettDate { get; set; }
        public string CurrencyId { get; set; }
        public string SettCurrencyId { get; set; }
        public decimal? FxRate { get; set; }
        public decimal? ChargesAmount { get; set; }
        public string TraderName { get; set; }
        public string Notes { get; set; }
        public int? SequenceNumber { get; set; }
        public string ConnectionName { get; set; }
        public byte Fidessa2geishaVersionNum { get; set; }
        public string InsertTradeDate { get; set; }
        public string InsertTradeTime { get; set; }
    }
}
