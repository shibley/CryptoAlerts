
namespace AlertsApp.web.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Alerts")]
    [BasedOnRow(typeof(Entities.AlertsRow))]
    public class AlertsForm
    {
        public DateTime DtCreated { get; set; }
        public DateTime DtSent { get; set; }
        public DateTime DtDeleted { get; set; }
        public Int32 IUserId { get; set; }
        public String SMessage { get; set; }
        public String STitle { get; set; }
        public Int32 IAlertSettingId { get; set; }
    }
}