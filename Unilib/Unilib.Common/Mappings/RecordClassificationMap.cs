using FluentNHibernate.Mapping;
using Unilib.Common.DataEntities;

namespace Unilib.Common.Mappings
{
    public class RecordClassificationMap : ClassMap<RecordClassificationEntity>
    {
        public RecordClassificationMap()
        {
            Id(x => x.Id).Column("Id").Unique();
            Map(x => x.ISBN);
            Map(x => x.ISSN);
            Map(x => x.NationalNumber);
            Map(x => x.OtherIdentifier);
            Map(x => x.ThemeClassificationId);
            Map(x => x.DocumentNumber);
            Table("RecordClassification");
        }
    }
}