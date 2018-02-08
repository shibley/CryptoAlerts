
namespace CryptoAlerts.web.Default {
    export interface AlertSettingsRow {
        IAlertSettingId?: number;
        AlertTypeId?: number;
        IExchangeId?: number;
        PriceLow?: number;
        PriceHigh?: number;
        DtCreated?: string;
        DtDeleted?: string;
        IUserId?: number;
        STitle?: string;
        ICurrencyPairId?: number;
        BActive?: boolean;
        IExchangeSName?: string;
        IExchangeDtCreated?: string;
        IExchangeDtDeleted?: string;
        ICurrencyPairSName?: string;
        ICurrencyPairSDescription?: string;
        ICurrencyPairDtCreated?: string;
        ICurrencyPairDtDeleted?: string;
    }

    export namespace AlertSettingsRow {
        export const idProperty = 'IAlertSettingId';
        export const nameProperty = 'STitle';
        export const localTextPrefix = 'Default.AlertSettings';

        export namespace Fields {
            export declare const IAlertSettingId;
            export declare const AlertTypeId;
            export declare const IExchangeId;
            export declare const PriceLow;
            export declare const PriceHigh;
            export declare const DtCreated;
            export declare const DtDeleted;
            export declare const IUserId;
            export declare const STitle;
            export declare const ICurrencyPairId;
            export declare const BActive;
            export declare const IExchangeSName;
            export declare const IExchangeDtCreated;
            export declare const IExchangeDtDeleted;
            export declare const ICurrencyPairSName;
            export declare const ICurrencyPairSDescription;
            export declare const ICurrencyPairDtCreated;
            export declare const ICurrencyPairDtDeleted;
        }

        [
            'IAlertSettingId',
            'AlertTypeId',
            'IExchangeId',
            'PriceLow',
            'PriceHigh',
            'DtCreated',
            'DtDeleted',
            'IUserId',
            'STitle',
            'ICurrencyPairId',
            'BActive',
            'IExchangeSName',
            'IExchangeDtCreated',
            'IExchangeDtDeleted',
            'ICurrencyPairSName',
            'ICurrencyPairSDescription',
            'ICurrencyPairDtCreated',
            'ICurrencyPairDtDeleted'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}