﻿
using Serenity.Extensibility;
using System.ComponentModel;

namespace AlertsApp.Administration
{
    [NestedPermissionKeys]
    [DisplayName("Administration")]
    public class PermissionKeys
    {
        [Description("User, Role Management and Permissions")]
        public const string Security = "Administration:Security";

        [Description("Languages and Translations")]
        public const string Translation = "Administration:Translation";

        [Description("Alerts")]
        public const string Alerts = "Administration:Alerts";
    }
}
