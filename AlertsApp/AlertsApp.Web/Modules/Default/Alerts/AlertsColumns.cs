
namespace AlertsApp.web.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Alerts")]
    [BasedOnRow(typeof(Entities.AlertsRow))]
    public class AlertsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IAlertId { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtSent { get; set; }
        public DateTime DtDeleted { get; set; }
        public Int32 IUserId { get; set; }
        [EditLink]
        public String SMessage { get; set; }
        public String STitle { get; set; }
        public String IAlertSettingSTitle { get; set; }
    }
}