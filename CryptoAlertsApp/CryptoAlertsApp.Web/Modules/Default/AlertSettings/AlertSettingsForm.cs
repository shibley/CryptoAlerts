
namespace CryptoAlerts.web.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.AlertSettings")]
    [BasedOnRow(typeof(Entities.AlertSettingsRow))]
    public class AlertSettingsForm
    {
        public Int32 AlertTypeId { get; set; }
        public Int32 IExchangeId { get; set; }
        public Decimal PriceLow { get; set; }
        public Decimal PriceHigh { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtDeleted { get; set; }
        public Int32 IUserId { get; set; }
        public String STitle { get; set; }
        public Int32 ICurrencyPairId { get; set; }
        public Boolean BActive { get; set; }
    }
}