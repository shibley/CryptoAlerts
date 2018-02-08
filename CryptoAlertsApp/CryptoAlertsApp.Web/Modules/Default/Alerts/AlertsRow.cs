
namespace CryptoAlerts.web.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Alerts]")]
    [DisplayName("Alerts"), InstanceName("Alerts"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AlertsRow : Row, IIdRow, INameRow
    {
        [DisplayName("I Alert Id"), Column("iAlertId"), Identity]
        public Int32? IAlertId
        {
            get { return Fields.IAlertId[this]; }
            set { Fields.IAlertId[this] = value; }
        }

        [DisplayName("Dt Created"), Column("dtCreated"), NotNull]
        public DateTime? DtCreated
        {
            get { return Fields.DtCreated[this]; }
            set { Fields.DtCreated[this] = value; }
        }

        [DisplayName("Dt Sent"), Column("dtSent")]
        public DateTime? DtSent
        {
            get { return Fields.DtSent[this]; }
            set { Fields.DtSent[this] = value; }
        }

        [DisplayName("Dt Deleted"), Column("dtDeleted")]
        public DateTime? DtDeleted
        {
            get { return Fields.DtDeleted[this]; }
            set { Fields.DtDeleted[this] = value; }
        }

        [DisplayName("I User Id"), Column("iUserId")]
        public Int32? IUserId
        {
            get { return Fields.IUserId[this]; }
            set { Fields.IUserId[this] = value; }
        }

        [DisplayName("S Message"), Column("sMessage"), Size(500), QuickSearch]
        public String SMessage
        {
            get { return Fields.SMessage[this]; }
            set { Fields.SMessage[this] = value; }
        }

        [DisplayName("S Title"), Column("sTitle"), Size(100)]
        public String STitle
        {
            get { return Fields.STitle[this]; }
            set { Fields.STitle[this] = value; }
        }

        [DisplayName("I Alert Setting"), Column("iAlertSettingId"), NotNull, ForeignKey("[dbo].[AlertSettings]", "iAlertSettingId"), LeftJoin("jIAlertSetting"), TextualField("IAlertSettingSTitle")]
        public Int32? IAlertSettingId
        {
            get { return Fields.IAlertSettingId[this]; }
            set { Fields.IAlertSettingId[this] = value; }
        }

        [DisplayName("I Alert Setting Alert Type Id"), Expression("jIAlertSetting.[AlertTypeId]")]
        public Int32? IAlertSettingAlertTypeId
        {
            get { return Fields.IAlertSettingAlertTypeId[this]; }
            set { Fields.IAlertSettingAlertTypeId[this] = value; }
        }

        [DisplayName("I Alert Setting I Exchange Id"), Expression("jIAlertSetting.[iExchangeId]")]
        public Int32? IAlertSettingIExchangeId
        {
            get { return Fields.IAlertSettingIExchangeId[this]; }
            set { Fields.IAlertSettingIExchangeId[this] = value; }
        }

        [DisplayName("I Alert Setting Price Low"), Expression("jIAlertSetting.[PriceLow]")]
        public Decimal? IAlertSettingPriceLow
        {
            get { return Fields.IAlertSettingPriceLow[this]; }
            set { Fields.IAlertSettingPriceLow[this] = value; }
        }

        [DisplayName("I Alert Setting Price High"), Expression("jIAlertSetting.[PriceHigh]")]
        public Decimal? IAlertSettingPriceHigh
        {
            get { return Fields.IAlertSettingPriceHigh[this]; }
            set { Fields.IAlertSettingPriceHigh[this] = value; }
        }

        [DisplayName("I Alert Setting Dt Created"), Expression("jIAlertSetting.[dtCreated]")]
        public DateTime? IAlertSettingDtCreated
        {
            get { return Fields.IAlertSettingDtCreated[this]; }
            set { Fields.IAlertSettingDtCreated[this] = value; }
        }

        [DisplayName("I Alert Setting Dt Deleted"), Expression("jIAlertSetting.[dtDeleted]")]
        public DateTime? IAlertSettingDtDeleted
        {
            get { return Fields.IAlertSettingDtDeleted[this]; }
            set { Fields.IAlertSettingDtDeleted[this] = value; }
        }

        [DisplayName("I Alert Setting I User Id"), Expression("jIAlertSetting.[iUserId]")]
        public Int32? IAlertSettingIUserId
        {
            get { return Fields.IAlertSettingIUserId[this]; }
            set { Fields.IAlertSettingIUserId[this] = value; }
        }

        [DisplayName("I Alert Setting S Title"), Expression("jIAlertSetting.[sTitle]")]
        public String IAlertSettingSTitle
        {
            get { return Fields.IAlertSettingSTitle[this]; }
            set { Fields.IAlertSettingSTitle[this] = value; }
        }

        [DisplayName("I Alert Setting I Currency Pair Id"), Expression("jIAlertSetting.[iCurrencyPairID]")]
        public Int32? IAlertSettingICurrencyPairId
        {
            get { return Fields.IAlertSettingICurrencyPairId[this]; }
            set { Fields.IAlertSettingICurrencyPairId[this] = value; }
        }

        [DisplayName("I Alert Setting B Active"), Expression("jIAlertSetting.[bActive]")]
        public Boolean? IAlertSettingBActive
        {
            get { return Fields.IAlertSettingBActive[this]; }
            set { Fields.IAlertSettingBActive[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IAlertId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SMessage; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AlertsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IAlertId;
            public DateTimeField DtCreated;
            public DateTimeField DtSent;
            public DateTimeField DtDeleted;
            public Int32Field IUserId;
            public StringField SMessage;
            public StringField STitle;
            public Int32Field IAlertSettingId;

            public Int32Field IAlertSettingAlertTypeId;
            public Int32Field IAlertSettingIExchangeId;
            public DecimalField IAlertSettingPriceLow;
            public DecimalField IAlertSettingPriceHigh;
            public DateTimeField IAlertSettingDtCreated;
            public DateTimeField IAlertSettingDtDeleted;
            public Int32Field IAlertSettingIUserId;
            public StringField IAlertSettingSTitle;
            public Int32Field IAlertSettingICurrencyPairId;
            public BooleanField IAlertSettingBActive;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Alerts";
            }
        }
    }
}
