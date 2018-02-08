
namespace AlertsApp.web.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Exchanges")]
    [BasedOnRow(typeof(Entities.ExchangesRow))]
    public class ExchangesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IExchangeId { get; set; }
        [EditLink]
        public String SName { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtDeleted { get; set; }
    }
}