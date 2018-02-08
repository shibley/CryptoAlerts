
namespace AlertsApp.web.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Exchanges")]
    [BasedOnRow(typeof(Entities.ExchangesRow))]
    public class ExchangesForm
    {
        public String SName { get; set; }
        public DateTime DtCreated { get; set; }
        public DateTime DtDeleted { get; set; }
    }
}