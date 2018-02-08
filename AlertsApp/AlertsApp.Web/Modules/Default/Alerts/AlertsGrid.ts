
namespace AlertsApp.web.Default {

    @Serenity.Decorators.registerClass()
    export class AlertsGrid extends Serenity.EntityGrid<AlertsRow, any> {
        protected getColumnsKey() { return 'Default.Alerts'; }
        protected getDialogType() { return AlertsDialog; }
        protected getIdProperty() { return AlertsRow.idProperty; }
        protected getLocalTextPrefix() { return AlertsRow.localTextPrefix; }
        protected getService() { return AlertsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}