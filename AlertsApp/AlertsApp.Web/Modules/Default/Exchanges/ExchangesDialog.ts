
namespace AlertsApp.web.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ExchangesDialog extends Serenity.EntityDialog<ExchangesRow, any> {
        protected getFormKey() { return ExchangesForm.formKey; }
        protected getIdProperty() { return ExchangesRow.idProperty; }
        protected getLocalTextPrefix() { return ExchangesRow.localTextPrefix; }
        protected getNameProperty() { return ExchangesRow.nameProperty; }
        protected getService() { return ExchangesService.baseUrl; }

        protected form = new ExchangesForm(this.idPrefix);

    }
}