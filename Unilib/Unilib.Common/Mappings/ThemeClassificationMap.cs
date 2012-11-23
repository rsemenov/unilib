using FluentNHibernate.Mapping;
using Unilib.Common.DataEntities;

namespace Unilib.Common.Mappings
{
    public class ThemeClassificationMap : ClassMap<ThemeClassificationEntity>
    {
        public ThemeClassificationMap()
        {
            Id(x => x.Id).Column("Id").Unique();
            Map(x => x.ParentId);
            Map(x => x.Title);
            Map(x => x.IsLeaf);
            Map(x => x.Title);
            Map(x => x.Description);
            Table("ThemeClassification");
        }
    }
}