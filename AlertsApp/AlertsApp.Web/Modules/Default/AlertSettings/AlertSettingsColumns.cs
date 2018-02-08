
namespace AlertsApp.web.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.AlertSettings")]
    [BasedOnRow(typeof(Entities.AlertSettingsRow))]
    public class AlertSettingsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IAlertSettingId { get; set; }
        public Int32 AlertTypeId { get; set; }
        public String IExchangeSName { get; set; }
        public Decimal PriceLow { get; set; }
        public Decimal PriceHigh { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtDeleted { get; set; }
        public Int32 IUserId { get; set; }
        [EditLink]
        public String STitle { get; set; }
        public String ICurrencyPairSName { get; set; }
        public Boolean BActive { get; set; }
    }
}