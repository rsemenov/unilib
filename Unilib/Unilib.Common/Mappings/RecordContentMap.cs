using FluentNHibernate.Mapping;
using Unilib.Common.DataEntities;

namespace Unilib.Common.Mappings
{
    public class RecordContentMap : ClassMap<RecordContentEntity>
    {
        public RecordContentMap()
        {
            Id(x => x.RecordId).Column("RecordId").GeneratedBy.Assigned();
            Map(x => x.DataType).CustomType<DataTypes>().Not.Nullable();
            Map(x => x.FileContent).Not.Nullable();
            Map(x => x.DescriptionContent).Nullable();
            Table("RecordContent");
        }
    }
}