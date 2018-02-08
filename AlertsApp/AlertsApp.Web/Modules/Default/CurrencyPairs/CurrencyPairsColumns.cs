
namespace AlertsApp.web.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.CurrencyPairs")]
    [BasedOnRow(typeof(Entities.CurrencyPairsRow))]
    public class CurrencyPairsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ICurrencyPairId { get; set; }
        [EditLink]
        public String SName { get; set; }
        public String SDescription { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtDeleted { get; set; }
    }
}