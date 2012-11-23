using FluentNHibernate.Mapping;
using Unilib.Common.DataEntities;

namespace Unilib.Common.Mappings
{
    public class RecordMap : ClassMap<RecordEntity>
    {
        public RecordMap()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.ChapterName).Not.Nullable();
            Map(x => x.FullTitle).Not.Nullable();
            Map(x => x.OtherTitle).Nullable();
            Map(x => x.Publication).Not.Nullable();
            Map(x => x.PublicationInfo).Nullable();
            Map(x => x.PublicationYear).Nullable();
            Map(x => x.Responsibility).Not.Nullable();
            Map(x => x.SortTitle).Not.Nullable();
            Map(x => x.TitleDescription).Nullable();
            Table("Records");
        }
    }
}