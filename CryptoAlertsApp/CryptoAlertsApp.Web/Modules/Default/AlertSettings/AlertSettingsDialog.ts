
namespace CryptoAlerts.web.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AlertSettingsDialog extends Serenity.EntityDialog<AlertSettingsRow, any> {
        protected getFormKey() { return AlertSettingsForm.formKey; }
        protected getIdProperty() { return AlertSettingsRow.idProperty; }
        protected getLocalTextPrefix() { return AlertSettingsRow.localTextPrefix; }
        protected getNameProperty() { return AlertSettingsRow.nameProperty; }
        protected getService() { return AlertSettingsService.baseUrl; }

        protected form = new AlertSettingsForm(this.idPrefix);

    }
}