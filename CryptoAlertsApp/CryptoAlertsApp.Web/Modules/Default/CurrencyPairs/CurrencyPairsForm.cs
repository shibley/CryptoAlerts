
namespace CryptoAlerts.web.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.CurrencyPairs")]
    [BasedOnRow(typeof(Entities.CurrencyPairsRow))]
    public class CurrencyPairsForm
    {
        public String SName { get; set; }
        public String SDescription { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtDeleted { get; set; }
    }
}