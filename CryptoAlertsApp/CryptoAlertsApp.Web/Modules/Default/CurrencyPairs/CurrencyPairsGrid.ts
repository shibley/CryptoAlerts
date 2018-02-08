
namespace CryptoAlerts.web.Default {

    @Serenity.Decorators.registerClass()
    export class CurrencyPairsGrid extends Serenity.EntityGrid<CurrencyPairsRow, any> {
        protected getColumnsKey() { return 'Default.CurrencyPairs'; }
        protected getDialogType() { return CurrencyPairsDialog; }
        protected getIdProperty() { return CurrencyPairsRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyPairsRow.localTextPrefix; }
        protected getService() { return CurrencyPairsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}