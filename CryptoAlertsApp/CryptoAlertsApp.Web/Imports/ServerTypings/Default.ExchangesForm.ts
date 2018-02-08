
namespace CryptoAlerts.web.Default {
    export class ExchangesForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Exchanges';
    }

    export interface ExchangesForm {
        SName: Serenity.StringEditor;
        DtCreated: Serenity.DateEditor;
        DtDeleted: Serenity.DateEditor;
    }

    [,
        ['SName', () => Serenity.StringEditor],
        ['DtCreated', () => Serenity.DateEditor],
        ['DtDeleted', () => Serenity.DateEditor]
    ].forEach(x => Object.defineProperty(ExchangesForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}