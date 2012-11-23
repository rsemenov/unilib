using FluentNHibernate.Mapping;
using Unilib.CommunicationServer.DataEntities;

namespace Unilib.CommunicationServer.Mappings
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

    public class ThemeClassificationMap : ClassMap<ThemeClassificationEntity>
    {
        public ThemeClassificationMap()
        {
            Id(x => x.Id).Column("Id").Unique();
            //TODO
        }
    }
}