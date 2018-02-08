
namespace AlertsApp.web.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[Exchanges]")]
    [DisplayName("Exchanges"), InstanceName("Exchanges"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ExchangesRow : Row, IIdRow, INameRow
    {
        [DisplayName("I Exchange Id"), Column("iExchangeId"), Identity]
        public Int32? IExchangeId
        {
            get { return Fields.IExchangeId[this]; }
            set { Fields.IExchangeId[this] = value; }
        }

        [DisplayName("S Name"), Column("sName"), Size(50), NotNull, QuickSearch]
        public String SName
        {
            get { return Fields.SName[this]; }
            set { Fields.SName[this] = value; }
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
            get { return Fields.IExchangeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ExchangesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field IExchangeId;
            public StringField SName;
            public DateTimeField DtCreated;
            public DateTimeField DtDeleted;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Exchanges";
            }
        }
    }
}
