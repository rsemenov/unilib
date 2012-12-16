using FluentNHibernate.Mapping;
using Unilib.Common.DataEntities;

namespace Unilib.Common.Mappings
{
    public class AuthorMap : ClassMap<AuthorEntity>
    {
        public AuthorMap()
        {
            //Schema("UniLib");
            Id(x => x.AuthorId).Column("Id").GeneratedBy.Assigned();
            Map(x => x.FirstPart).Not.Nullable();
            Map(x => x.FullName).Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            Map(x => x.NameAddition).Nullable();
            Map(x => x.OtherNames).Nullable();
            Map(x => x.SufixPart).Not.Nullable();
            Table("Authors");
        }
    }
}
