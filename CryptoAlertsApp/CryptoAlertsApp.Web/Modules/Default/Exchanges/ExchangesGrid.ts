
namespace CryptoAlerts.web.Default {

    @Serenity.Decorators.registerClass()
    export class ExchangesGrid extends Serenity.EntityGrid<ExchangesRow, any> {
        protected getColumnsKey() { return 'Default.Exchanges'; }
        protected getDialogType() { return ExchangesDialog; }
        protected getIdProperty() { return ExchangesRow.idProperty; }
        protected getLocalTextPrefix() { return ExchangesRow.localTextPrefix; }
        protected getService() { return ExchangesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}