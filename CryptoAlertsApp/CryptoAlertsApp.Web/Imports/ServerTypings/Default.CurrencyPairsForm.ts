
namespace CryptoAlerts.web.Default {
    export class CurrencyPairsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.CurrencyPairs';
    }

    export interface CurrencyPairsForm {
        SName: Serenity.StringEditor;
        SDescription: Serenity.StringEditor;
        DtCreated: Serenity.DateEditor;
        DtDeleted: Serenity.DateEditor;
    }

    [,
        ['SName', () => Serenity.StringEditor],
        ['SDescription', () => Serenity.StringEditor],
        ['DtCreated', () => Serenity.DateEditor],
        ['DtDeleted', () => Serenity.DateEditor]
    ].forEach(x => Object.defineProperty(CurrencyPairsForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}