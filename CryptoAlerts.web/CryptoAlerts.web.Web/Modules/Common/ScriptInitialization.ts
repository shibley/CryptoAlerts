/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace CryptoAlerts.web.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('CryptoAlerts.web');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}