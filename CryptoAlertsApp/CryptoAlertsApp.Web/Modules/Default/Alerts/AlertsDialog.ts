
namespace CryptoAlerts.web.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AlertsDialog extends Serenity.EntityDialog<AlertsRow, any> {
        protected getFormKey() { return AlertsForm.formKey; }
        protected getIdProperty() { return AlertsRow.idProperty; }
        protected getLocalTextPrefix() { return AlertsRow.localTextPrefix; }
        protected getNameProperty() { return AlertsRow.nameProperty; }
        protected getService() { return AlertsService.baseUrl; }

        protected form = new AlertsForm(this.idPrefix);

    }
}