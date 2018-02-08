/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace AlertsApp.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('AlertsApp');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}