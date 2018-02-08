
namespace CryptoAlerts.web.Default {
    export class AlertSettingsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.AlertSettings';
    }

    export interface AlertSettingsForm {
        AlertTypeId: Serenity.IntegerEditor;
        IExchangeId: Serenity.IntegerEditor;
        PriceLow: Serenity.DecimalEditor;
        PriceHigh: Serenity.DecimalEditor;
        DtCreated: Serenity.DateEditor;
        DtDeleted: Serenity.DateEditor;
        IUserId: Serenity.IntegerEditor;
        STitle: Serenity.StringEditor;
        ICurrencyPairId: Serenity.IntegerEditor;
        BActive: Serenity.BooleanEditor;
    }

    [,
        ['AlertTypeId', () => Serenity.IntegerEditor],
        ['IExchangeId', () => Serenity.IntegerEditor],
        ['PriceLow', () => Serenity.DecimalEditor],
        ['PriceHigh', () => Serenity.DecimalEditor],
        ['DtCreated', () => Serenity.DateEditor],
        ['DtDeleted', () => Serenity.DateEditor],
        ['IUserId', () => Serenity.IntegerEditor],
        ['STitle', () => Serenity.StringEditor],
        ['ICurrencyPairId', () => Serenity.IntegerEditor],
        ['BActive', () => Serenity.BooleanEditor]
    ].forEach(x => Object.defineProperty(AlertSettingsForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}