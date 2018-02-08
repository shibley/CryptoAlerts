
namespace AlertsApp.web.Default {

    @Serenity.Decorators.registerClass()
    export class AlertSettingsGrid extends Serenity.EntityGrid<AlertSettingsRow, any> {
        protected getColumnsKey() { return 'Default.AlertSettings'; }
        protected getDialogType() { return AlertSettingsDialog; }
        protected getIdProperty() { return AlertSettingsRow.idProperty; }
        protected getLocalTextPrefix() { return AlertSettingsRow.localTextPrefix; }
        protected getService() { return AlertSettingsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}