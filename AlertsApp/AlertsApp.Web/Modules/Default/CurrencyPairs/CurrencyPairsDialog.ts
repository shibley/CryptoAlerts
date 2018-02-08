
namespace AlertsApp.web.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CurrencyPairsDialog extends Serenity.EntityDialog<CurrencyPairsRow, any> {
        protected getFormKey() { return CurrencyPairsForm.formKey; }
        protected getIdProperty() { return CurrencyPairsRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyPairsRow.localTextPrefix; }
        protected getNameProperty() { return CurrencyPairsRow.nameProperty; }
        protected getService() { return CurrencyPairsService.baseUrl; }

        protected form = new CurrencyPairsForm(this.idPrefix);

    }
}