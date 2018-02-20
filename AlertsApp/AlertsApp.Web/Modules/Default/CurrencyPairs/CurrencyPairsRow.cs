
namespace AlertsApp.web.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[CurrencyPairs]")]
    [DisplayName("Currency Pairs"), InstanceName("Currency Pairs"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Alerts)]
    [ModifyPermission(Administration.PermissionKeys.Alerts)]
    public sealed class CurrencyPairsRow : Row, IIdRow, INameRow
    {
        [DisplayName("I Currency Pair Id"), Column("iCurrencyPairId"), Identity]
        public Int32? ICurrencyPairId
        {
            get { return Fields.ICurrencyPairId[this]; }
            set { Fields.ICurrencyPairId[this] = value; }
        }

        [DisplayName("S Name"), Column("sName"), Size(50), NotNull, QuickSearch]
        public String SName
        {
            get { return Fields.SName[this]; }
            set { Fields.SName[this] = value; }
        }

        [DisplayName("S Description"), Column("sDescription"), Size(100)]
        public String SDescription
        {
            get { return Fields.SDescription[this]; }
            set { Fields.SDescription[this] = value; }
        }

        [DisplayName("Dt Created"), Column("dtCreated"), NotNull]
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

        IIdField IIdRow.IdField
        {
            get { return Fields.ICurrencyPairId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CurrencyPairsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ICurrencyPairId;
            public StringField SName;
            public StringField SDescription;
            public DateTimeField DtCreated;
            public DateTimeField DtDeleted;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.CurrencyPairs";
            }
        }
    }
}
