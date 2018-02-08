
namespace CryptoAlerts.web.Default {
    export class AlertsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Alerts';
    }

    export interface AlertsForm {
        DtCreated: Serenity.DateEditor;
        DtSent: Serenity.DateEditor;
        DtDeleted: Serenity.DateEditor;
        IUserId: Serenity.IntegerEditor;
        SMessage: Serenity.StringEditor;
        STitle: Serenity.StringEditor;
        IAlertSettingId: Serenity.IntegerEditor;
    }

    [,
        ['DtCreated', () => Serenity.DateEditor],
        ['DtSent', () => Serenity.DateEditor],
        ['DtDeleted', () => Serenity.DateEditor],
        ['IUserId', () => Serenity.IntegerEditor],
        ['SMessage', () => Serenity.StringEditor],
        ['STitle', () => Serenity.StringEditor],
        ['IAlertSettingId', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(AlertsForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}