
namespace CryptoAlerts.web.Default {
    export interface CurrencyPairsRow {
        ICurrencyPairId?: number;
        SName?: string;
        SDescription?: string;
        DtCreated?: string;
        DtDeleted?: string;
    }

    export namespace CurrencyPairsRow {
        export const idProperty = 'ICurrencyPairId';
        export const nameProperty = 'SName';
        export const localTextPrefix = 'Default.CurrencyPairs';

        export namespace Fields {
            export declare const ICurrencyPairId;
            export declare const SName;
            export declare const SDescription;
            export declare const DtCreated;
            export declare const DtDeleted;
        }

        [
            'ICurrencyPairId',
            'SName',
            'SDescription',
            'DtCreated',
            'DtDeleted'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}