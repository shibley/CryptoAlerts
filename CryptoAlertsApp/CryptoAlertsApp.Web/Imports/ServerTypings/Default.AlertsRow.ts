
namespace CryptoAlerts.web.Default {
    export interface AlertsRow {
        IAlertId?: number;
        DtCreated?: string;
        DtSent?: string;
        DtDeleted?: string;
        IUserId?: number;
        SMessage?: string;
        STitle?: string;
        IAlertSettingId?: number;
        IAlertSettingAlertTypeId?: number;
        IAlertSettingIExchangeId?: number;
        IAlertSettingPriceLow?: number;
        IAlertSettingPriceHigh?: number;
        IAlertSettingDtCreated?: string;
        IAlertSettingDtDeleted?: string;
        IAlertSettingIUserId?: number;
        IAlertSettingSTitle?: string;
        IAlertSettingICurrencyPairId?: number;
        IAlertSettingBActive?: boolean;
    }

    export namespace AlertsRow {
        export const idProperty = 'IAlertId';
        export const nameProperty = 'SMessage';
        export const localTextPrefix = 'Default.Alerts';

        export namespace Fields {
            export declare const IAlertId;
            export declare const DtCreated;
            export declare const DtSent;
            export declare const DtDeleted;
            export declare const IUserId;
            export declare const SMessage;
            export declare const STitle;
            export declare const IAlertSettingId;
            export declare const IAlertSettingAlertTypeId;
            export declare const IAlertSettingIExchangeId;
            export declare const IAlertSettingPriceLow;
            export declare const IAlertSettingPriceHigh;
            export declare const IAlertSettingDtCreated;
            export declare const IAlertSettingDtDeleted;
            export declare const IAlertSettingIUserId;
            export declare const IAlertSettingSTitle;
            export declare const IAlertSettingICurrencyPairId;
            export declare const IAlertSettingBActive;
        }

        [
            'IAlertId',
            'DtCreated',
            'DtSent',
            'DtDeleted',
            'IUserId',
            'SMessage',
            'STitle',
            'IAlertSettingId',
            'IAlertSettingAlertTypeId',
            'IAlertSettingIExchangeId',
            'IAlertSettingPriceLow',
            'IAlertSettingPriceHigh',
            'IAlertSettingDtCreated',
            'IAlertSettingDtDeleted',
            'IAlertSettingIUserId',
            'IAlertSettingSTitle',
            'IAlertSettingICurrencyPairId',
            'IAlertSettingBActive'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}