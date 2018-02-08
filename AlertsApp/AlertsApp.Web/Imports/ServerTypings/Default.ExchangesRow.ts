
namespace AlertsApp.web.Default {
    export interface ExchangesRow {
        IExchangeId?: number;
        SName?: string;
        DtCreated?: string;
        DtDeleted?: string;
    }

    export namespace ExchangesRow {
        export const idProperty = 'IExchangeId';
        export const nameProperty = 'SName';
        export const localTextPrefix = 'Default.Exchanges';

        export namespace Fields {
            export declare const IExchangeId;
            export declare const SName;
            export declare const DtCreated;
            export declare const DtDeleted;
        }

        [
            'IExchangeId',
            'SName',
            'DtCreated',
            'DtDeleted'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}