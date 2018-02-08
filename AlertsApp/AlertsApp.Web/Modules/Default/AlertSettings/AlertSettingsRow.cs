
namespace AlertsApp.web.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[AlertSettings]")]
    [DisplayName("Alert Settings"), InstanceName("Alert Settings"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AlertSettingsRow : Row, IIdRow, INameRow
    {
        [DisplayName("I Alert Setting Id"), Column("iAlertSettingId"), Identity]
        public Int32? IAlertSettingId
        {
            get { return Fields.IAlertSettingId[this]; }
            set { Fields.IAlertSettingId[this] = value; }
        }

        [DisplayName("Alert Type Id")]
        public Int32? AlertTypeId
        {
            get { return Fields.AlertTypeId[this]; }
            set { Fields.AlertTypeId[this] = value; }
        }

        [DisplayName("I Exchange"), Column("iExchangeId"), ForeignKey("[dbo].[Exchanges]", "iExchangeId"), LeftJoin("jIExchange"), TextualField("IExchangeSName")]
        public Int32? IExchangeId
        {
            get { return Fields.IExchangeId[this]; }
            set { Fields.IExchangeId[this] = value; }
        }

        [DisplayName("Price Low"), Size(18)]
        public Decimal? PriceLow
        {
            get { return Fields.PriceLow[this]; }
            set { Fields.PriceLow[this] = value; }
        }

        [DisplayName("Price High"), Size(18)]
        public Decimal? PriceHigh
        {
            get { return Fields.PriceHigh[this]; }
            set { Fields.PriceHigh[this] = value; }
        }

        [DisplayName("Dt Created"), Column("dtCreated")]
        public DateTime? DtCreated
        {
            get { return Fields.DtCreated[this]; }
            set { Fields.DtCreated[this] = value; }
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

        [DisplayName("S Title"), Column("sTitle"), Size(100), QuickSearch]
        public String STitle
        {
            get { return Fields.STitle[this]; }
            set { Fields.STitle[this] = value; }
        }

        [DisplayName("I Currency Pair"), Column("iCurrencyPairID"), ForeignKey("[dbo].[CurrencyPairs]", "iCurrencyPairId"), LeftJoin("jICurrencyPair"), TextualField("ICurrencyPairSName")]
        public Int32? ICurrencyPairId
        {
            get { return Fields.ICurrencyPairId[this]; }
            set { Fields.ICurrencyPairId[this] = value; }
        }

        [DisplayName("B Active"), Column("bActive"), NotNull]
        public Boolean? BActive
        {
            get { return Fields.BActive[this]; }
            set { Fields.BActive[this] = value; }
        }

        [DisplayName("I Exchange S Name"), Expression("jIExchange.[sName]")]
        public String IExchangeSName
        {
            get { return Fields.IExchangeSName[this]; }
            set { Fields.IExchangeSName[this] = value; }
        }

        [DisplayName("I Exchange Dt Created"), Expression("jIExchange.[dtCreated]")]
        public DateTime? IExchangeDtCreated
        {
            get { return Fields.IExchangeDtCreated[this]; }
            set { Fields.IExchangeDtCreated[this] = value; }
        }

        [DisplayName("I Exchange Dt Deleted"), Expression("jIExchange.[dtDeleted]")]
        public DateTime? IExchangeDtDeleted
        {
            get { return Fields.IExchangeDtDeleted[this]; }
            set { Fields.IExchangeDtDeleted[this] = value; }
        }

        [DisplayName("I Currency Pair S Name"), Expression("jICurrencyPair.[sName]")]
        public String ICurrencyPairSName
        {
            get { return Fields.ICurrencyPairSName[this]; }
            set { Fields.ICurrencyPairSName[this] = value; }
        }

        [DisplayName("I Currency Pair S Description"), Expression("jICurrencyPair.[sDescription]")]
        public String ICurrencyPairSDescription
        {
            get { return Fields.ICurrencyPairSDescription[this]; }
            set { Fields.ICurrencyPairSDescription[this] = value; }
        }

        [DisplayName("I Currency Pair Dt Created"), Expression("jICurrencyPair.[dtCreated]")]
        public DateTime? ICurrencyPairDtCreated
        {
            get { return Fields.ICurrencyPairDtCreated[this]; }
            set { Fields.ICurrencyPairDtCreated[this] = value; }
        }

        [DisplayName("I Currency Pair Dt Deleted"), Expression("jICurrencyPair.[dtDeleted]")]
        public DateTime? ICurrencyPairDtDeleted
        {
            get { return Fields.ICurrencyPairDtDeleted[this]; }
            set { Fields.ICurrencyPairDtDeleted[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.IAlertSettingId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.STitle; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AlertSettingsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IAlertSettingId;
            public Int32Field AlertTypeId;
            public Int32Field IExchangeId;
            public DecimalField PriceLow;
            public DecimalField PriceHigh;
            public DateTimeField DtCreated;
            public DateTimeField DtDeleted;
            public Int32Field IUserId;
            public StringField STitle;
            public Int32Field ICurrencyPairId;
            public BooleanField BActive;

            public StringField IExchangeSName;
            public DateTimeField IExchangeDtCreated;
            public DateTimeField IExchangeDtDeleted;

            public StringField ICurrencyPairSName;
            public StringField ICurrencyPairSDescription;
            public DateTimeField ICurrencyPairDtCreated;
            public DateTimeField ICurrencyPairDtDeleted;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.AlertSettings";
            }
        }
    }
}
